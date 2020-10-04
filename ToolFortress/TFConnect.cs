using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToolFortress
{
    class TFConnect
    {
        public string Username { get; set; }

        private string ip;
        private int port;
        private TcpClient tcpClient;

        public delegate void NetworkDataHandler(byte[] data);
        public event NetworkDataHandler OnNetworkData = delegate { };

        public TFConnect() { }

        public bool Connect(string pIP, int pPort)
        {
            if (tcpClient != null && tcpClient.Connected) { return false; }

            ip = pIP;
            port = pPort;

            try
            {
                tcpClient = new TcpClient();
                Console.WriteLine("[TFC] Conneting...");
                tcpClient.Connect(pIP, pPort);
                Console.WriteLine("[TFC] Connected!");

                Thread clientThread = new Thread(HandleMessages);
                clientThread.Start();
                return true;
            } catch (Exception ex)
            {
                Console.WriteLine("[TFC] Error: " + ex.Message);
                return false;
            }
        }

        public bool Disconnect()
        {
            if (tcpClient != null)
            {
                try
                {
                    tcpClient.Close();
                    return true;
                } catch (Exception ex)
                {
                    Console.WriteLine("[TFC] Error @ Disconnect: " + ex.Message);
                }
            }

            return false;
        }

        public void SendData(byte[] pData)
        {
            if (tcpClient != null && tcpClient.Connected)
            {
                byte[] data = new byte[1024];
                pData.CopyTo(data, 0);
                tcpClient.GetStream().Write(data, 0, data.Length);
            }
        }

        public void BroadcastString(string pString)
        {
            byte[] textData = Encoding.UTF8.GetBytes(pString);

            byte[] data = new byte[1024];
            textData.CopyTo(data, 2);

            data[0] = 3; // Packet 3 = Broadcast
            data[1] = (byte)textData.Length;
            SendData(data);
        }

        public void RequestUserlist()
        {
            byte[] data = new byte[1] { 2 };
            SendData(data);
        }

        public void SetUsername(string pUsername)
        {
            byte[] textData = Encoding.UTF8.GetBytes(pUsername);

            byte[] data = new byte[1024];
            textData.CopyTo(data, 2);

            data[0] = 1; // Packet 3 = Broadcast
            data[1] = (byte)textData.Length;
            SendData(data);
        }

        private void HandleMessages()
        {
            try
            {
                while (tcpClient.Connected)
                {
                    byte[] readData = new byte[1024];
                    int bytesRead = tcpClient.GetStream().Read(readData, 0, readData.Length);
                    OnNetworkData(readData);
                }
            } catch (Exception ex)
            {
                Console.WriteLine("[TFC] Error: " + ex.Message);
            }
        }
    }
}
