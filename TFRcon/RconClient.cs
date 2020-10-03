using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryMaster;
using QueryMaster.GameServer;

namespace TFRcon
{
    public class RconClient
    {
        private bool isConnected = false;

        private string ip;
        private ushort port;
        private string password;

        private Server gameServer;
        private Rcon gameRcon;

        public RconClient() { }

        public RconClient(string pIP, ushort pPort, string pPassword)
        {
            ip = pIP;
            port = pPort;
            password = pPassword;

            Connect(ip, port, password);
        }

        // Connect to a Rcon-Server
        public bool Connect(string pIP, ushort pPort, string pPassword)
        {
            gameServer = ServerQuery.GetServerInstance(EngineType.Source, pIP, pPort);
            bool hasControl = gameServer.GetControl(pPassword);
            if (hasControl)
            {
                isConnected = true;
                gameRcon = gameServer.Rcon;
                gameRcon.Enablelogging();
            }
            else
            {
                isConnected = false;
                throw new Exception("Rcon authentication failed! Please make sure that the password is correct.");
            }

            return isConnected;
        }

        // Disconnect from a Rcon-Server
        public void Disconnect()
        {
            if (gameServer != null)
            {
                gameServer.Dispose();
                isConnected = false;
            }
        }

        // Reconnect to the current Rcon-Server
        public bool Reconnect()
        {
            Disconnect();
            return Connect(ip, port, password);
        }

        // Reconnect to another Rcon-Server
        public bool Reconnect(string pIP, ushort pPort, string pPassword)
        {
            Disconnect();
            return Connect(pIP, pPort, pPassword);
        }

        // Send a command to the server
        public string SendCommand(string pCommand)
        {
            if (isConnected)
            {
                string response = gameRcon.SendCommand(pCommand);
                return response;
            } else
            {
                throw new Exception("The command couldn't be sent because you aren't connected to a Rcon-Server");
            }
        }

        // Returns whether the client is connected
        public bool IsConnected()
        {
            return isConnected;
        }

        // Get the current Rcon-IP
        public string GetIP()
        {
            return ip;
        }

        // Get the current Rcon-Port
        public int GetPort()
        {
            return port;
        }
    }
}
