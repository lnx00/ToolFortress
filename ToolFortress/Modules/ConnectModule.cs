using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Extensions;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ToolFortress.TF2;

namespace ToolFortress.Modules
{
    class ConnectModule : IModule
    {
        private string currentLobby = "";
        private string currentUser = "";
        private bool isConnected = false;

        private FirebaseConfig fbConfig;
        private FirebaseClient fbClient;
        private EventStreamResponse bcResponse;
        private EventStreamResponse userUpdateResponse;

        public delegate void BroadcastHandler(string message);
        public event BroadcastHandler OnBroadcast = delegate { };

        public delegate void UserUpdateHandler();
        public event UserUpdateHandler OnUserUpdate = delegate { };

        public void Enable()
        {
            fbConfig = new FirebaseConfig
            {
                AuthSecret = Settings.FB_AUTHSECRET,
                BasePath = Settings.FB_BASEPATH
            };

            fbClient = new FirebaseClient(fbConfig);

            OnBroadcast += HandleBroadcast;
        }

        public void Disable()
        {
            if (fbClient != null)
            {
                Disconnect();
            }
        }

        public void JoinLobby(string pLobby)
        {
            Disconnect();

            currentLobby = pLobby;
            Join();
        }

        public async void CreateLobby(string pLobby)
        {
            Disconnect();

            PushResponse lobbyResponse = await fbClient.PushAsync("lobbys/", pLobby);
            currentLobby = lobbyResponse.Result.name;

            Join();
            await fbClient.SetAsync("lobbys/" + currentLobby + "/name", pLobby);
        }

        public async void Disconnect()
        {
            if (!String.IsNullOrEmpty(currentLobby) && !String.IsNullOrEmpty(currentUser))
            {
                await fbClient.DeleteAsync("lobbys/" + currentLobby + "/users/" + currentUser);
                bcResponse.Dispose();
                userUpdateResponse.Dispose();
                isConnected = false;
            }
        }

        private async void Join()
        {
            PushResponse userResponse = await fbClient.PushAsync("lobbys/" + currentLobby + "/users", Settings.FB_USERNAME);
            currentUser = userResponse.Result.name;

            userUpdateResponse = await fbClient.OnAsync("lobbys/" + currentLobby + "/users", (sender, args, context) =>
            {
                OnUserUpdate();
            });

            bcResponse = await fbClient.OnAsync("lobbys/" + currentLobby + "/broadcast", (sender, args, context) =>
            {
                OnBroadcast(args.Data);
            });

            isConnected = true;
        }

        public async void BroadcastMessage(string pType, string pMessage)
        {
            pMessage = pMessage.Replace('|', 'l');
            await fbClient.PushAsync("lobbys/" + currentLobby + "/broadcast", pType + "|" + pMessage);
        }

        public Dictionary<string, string> GetUsers()
        {
            Dictionary<string, string> userDict = new Dictionary<string, string> { { "default", "Unknown User" } };

            try
            {
                FirebaseResponse response = fbClient.Get("lobbys/" + currentLobby + "/users");
                userDict = response.ResultAs<Dictionary<string, string>>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error @ GetUsers: " + ex.Message);
            }

            return userDict;
        }

        public Dictionary<string, string> GetLobbys()
        {
            Dictionary<string, string> lobbyDict = new Dictionary<string, string>();

            try
            {
                FirebaseResponse response = fbClient.Get("lobbys/");
                JObject jo = JObject.Parse(response.Body);
                foreach (KeyValuePair<string, JToken> item in jo)
                {
                    lobbyDict.Add(item.Key, item.Value["name"].ToString());
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Error @ GetLobbys: " + ex.Message);
            }

            return lobbyDict;
        }

        private void HandleBroadcast(string pMessage)
        {
            try
            {
                string[] msgData = pMessage.Split('|');
                string type = msgData[0];
                string data = pMessage.Substring(type.Length + 1);

                switch (type)
                {
                    case "msg":
                        Console.WriteLine("[MSG] " + data);
                        break;

                    case "cmd":
                        Game.SendCommand(data);
                        break;

                    case "say":
                        Game.SendChatMessage(data);
                        break;

                    case "taunt":
                        Game.SendCommand("taunt_by_name " + data);
                        break;
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Error @ HandleBroadcast: " + ex.Message);
            }
        }

        public bool IsConnected()
        {
            return isConnected;
        }
    }
}
