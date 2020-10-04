using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace ToolFortressConnect
{
    class Program
    {
        public const int SERVER_VERSION = 1;
        public const int SERVER_PORT = 2063;
        public struct User
        {
            public string Name;

            public User(string pName)
            {
                Name = pName;
            }
        }

        private static bool isRunning = true;
        private static List<User> userList = new List<User>();

        public delegate void BroadcastHandler(byte[] data);
        public static event BroadcastHandler OnBroadcast = delegate { };

        static void Main(string[] args)
        {
            Console.WriteLine("[>] Starting ToolFortress Connect v" + SERVER_VERSION + "...");

            TcpListener tcpListener = new TcpListener(IPAddress.Any, SERVER_PORT);
            tcpListener.Start();

            Console.WriteLine("[i] Server is running at port: " + SERVER_PORT);
            Console.WriteLine("[i] Local Endpoint: " + tcpListener.LocalEndpoint);
            Console.WriteLine("[>] Waiting for connections...");

            while (isRunning)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                Console.WriteLine("[<] New connection from: " + client.Client.RemoteEndPoint);

                User clientUser = new User("Guest");
                Thread clientThread = new Thread(() => { HandleClient(client, clientUser); });
                clientThread.Start();
                userList.Add(clientUser);
            }

            Console.WriteLine("[>] ToolFortress Connect stopped!");
        }

        private static void HandleClient(TcpClient pClient, User pUser)
        {
            try
            {
                NetworkStream ns = pClient.GetStream();

                BroadcastHandler bcHandler = (data) =>
                {
                    ns.Write(data, 0, data.Length);
                };
                OnBroadcast += bcHandler;

                while (pClient.Connected)
                {
                    byte[] msgBuffer = new byte[1024];
                    ns.Read(msgBuffer, 0, msgBuffer.Length);
                    Console.WriteLine("[<] Received " + msgBuffer[0].ToString() + " from: " + pClient.Client.RemoteEndPoint);

                    byte type = msgBuffer[0];
                    byte length = msgBuffer[1];
                    byte[] data = msgBuffer.Skip(2).ToArray();
                    switch (type)
                    {
                        case 0:
                            // Request shutdown
                            Environment.Exit(0);
                            break;

                        case 1:
                            // Change username
                            string username = Encoding.UTF8.GetString(data.Take(length).ToArray());
                            pUser.Name = username;
                            Console.WriteLine("[>] Set username to: " + username);
                            break;

                        case 2:
                            // Get all users
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Serialize(ns, userList);
                            Console.WriteLine("[>] Requested all users");
                            break;

                        case 3:
                            // Broadcast data
                            OnBroadcast(msgBuffer);
                            Console.WriteLine("[>] Sending Broadcast...");
                            break;

                        case 4:
                            // Broadcast Taunt
                            OnBroadcast(msgBuffer);
                            Console.WriteLine("[>] Sending Taunt...");
                            break;
                    }
                }

                OnBroadcast -= bcHandler;
                ns.Close();
            } catch (Exception ex)
            {
                Console.WriteLine("[!] Error @ Client: " + ex.Message);
            }
        }
    }
}
