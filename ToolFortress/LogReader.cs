using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToolFortress
{
    class LogReader
    {
        private string tfPath;
        private string logPath;

        private Thread readThread;
        private bool readActive = false;

        public delegate void LogUpdateHandler(string line);
        public event LogUpdateHandler OnLogUpdate;

        public LogReader(string pTfPath)
        {
            tfPath = pTfPath + @"\tf\";
            if (!Directory.Exists(tfPath))
            {
                throw new Exception("Team Fortress 2 folder couldn't be found!");
            }

            logPath = tfPath + @"\console.log";
            if (!File.Exists(logPath))
            {
                throw new Exception("The console log file doesn't exist!");
            }
        }

        public void Start()
        {
            readActive = true;
            readThread = new Thread(ReadLog);
            readThread.Start();
        }

        public void Stop()
        {
            readActive = false;
            /*if (readThread != null && readThread.IsAlive)
            {
                readThread.Abort();
            }*/
        }

        public void ReadLog()
        {
            using (FileStream fs = File.Open(logPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    fs.Position = fs.Length;

                    string line;
                    while (readActive)
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            OnLogUpdate(line);
                        }

                        Thread.Sleep(100);
                    }
                }
            }
        }
    }
}
