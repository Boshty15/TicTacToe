using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tictacRom
{
    class Client
    {
        public delegate void recivedMessage(Protocol rezultat);
        public event recivedMessage recivedMsg;
        public delegate void EventStatus(NetworkType nType, StatusType sType, string status);
        public event EventStatus statusText;

        private readonly TcpClient _tcpClient;
        private readonly IPEndPoint _ipEndPoint;
        private readonly Thread _thread;

        private const int BUFFER_LENGTH = 1024;
        private byte[] buffer = new byte[BUFFER_LENGTH];

        //inicializacija clienta za ip in port
        public Client(string newIp, int newPort)
        {
            _ipEndPoint = new IPEndPoint(IPAddress.Parse(newIp), newPort);
            _tcpClient = new TcpClient();
            _tcpClient.Connect(_ipEndPoint);
            _thread = new Thread(new ThreadStart(clientConnect));
            _thread.Start();
        }

        public void clientConnect()
        {
            NetworkStream clientStream = _tcpClient.GetStream();

            while (_tcpClient.Connected)
            {
                int bytesRead = 0;
                memset(buffer, 0);
                try
                {
                    bytesRead = clientStream.Read(buffer, 0, BUFFER_LENGTH);
                    if (bytesRead == 0)
                        throw new Exception();
                }
                catch
                {
                    statusText(NetworkType.Client, StatusType.Error, "Povezava prekinjena");
                    stop();
                    return;
                }

                Protocol recived = Protocol.ToProtocol(buffer);
                recivedMsg(recived);
            }
        }

        private void memset(byte[] array, byte number)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = number;
        }
        
        public void Send(Protocol msg)
        {
            NetworkStream clientStream = _tcpClient.GetStream();

            byte[] buffer = Protocol.ToByteArray(msg);
            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
        }

        public void stop()
        {
            _tcpClient.Close();
        }

        public bool Connected
        {
            get
            {
                if (_tcpClient.Connected)
                    return true;
                return false;
            }
        }
    }
}
