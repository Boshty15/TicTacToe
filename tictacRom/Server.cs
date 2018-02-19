using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tictacRom
{
    class Server
    {
        public delegate void recivedMessage(Protocol rezultat);
        public event recivedMessage recivedMsg;
        public delegate void EventStatus(NetworkType nType, StatusType sType, string status);
        public event EventStatus statusText;

        private readonly TcpListener _tcpListener;
        private readonly Thread _listenThread;

        private TcpClient _tcpClient;
        private bool _isListening;        
        private const int BUFFER_LENGTH = 1024;
        private byte[] buffer = new byte[BUFFER_LENGTH];

        public Server(string newIp, int newPort)
        {
            _isListening = true;
            //mainWindow = window;
            
            _tcpListener = new TcpListener(IPAddress.Parse(newIp), newPort);
            _tcpListener.Start();
            _listenThread = new Thread(new ThreadStart(startListening));
            _listenThread.Start();
        }

        private void startListening()
        {
            while (_isListening)
            {
                try { _tcpClient = _tcpListener.AcceptTcpClient(); }
                catch { _isListening = false; break; }

                statusText(NetworkType.Server, StatusType.Info, "Odjemalec se je povezal: " + ((IPEndPoint)_tcpClient.Client.RemoteEndPoint).ToString());
                handleClient();
            }
        }

        private void handleClient()
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
                    statusText(NetworkType.Server, StatusType.Error, "Odjemalec je prekinil povezavo");
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
            _isListening = false;
            _tcpListener.Stop();
        }

        public bool Connected
        {
            get
            {
                if (_tcpListener != null && _isListening)
                    return true;
                return false;
            }
        }
    }
}
