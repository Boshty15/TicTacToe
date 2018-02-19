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
    enum NetworkType
    {
        Server, Client
    }

    enum StatusType
    {
        Error, Warning, Info
    }

    class Network
    {
        public delegate void recivedMessage(Protocol rezultat);
        public event recivedMessage recivedMsg;
        public delegate void EventStatus(NetworkType nType, StatusType sType, string status);
        public event EventStatus statusText;

        private NetworkType _networkType;
        private Client _client;
        private Server _server;

        /// <summary>
        /// create network handle and start listening or connect to server
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        public Network(NetworkType type, string ip, int port)
        {
            _networkType = type;

            if (type == NetworkType.Server)
                initServer(ip, port);
            else
                initClient(ip, port);
        }

        private void initServer(string ip, int port)
        {
            //inicializacija serverja in ustvarjaje na ip in port
            try
            {
                _server = new Server(ip, port);
                _server.recivedMsg += recvMsg;
                _server.statusText += statusText_event;
            }catch(Exception e)
            {
                
            }
        }

        private void initClient(string ip, int port)
        {
            //inicializacija clienta in rezervacija na ip in port
            try
            {
                _client = new Client(ip, port);
                _client.recivedMsg += recvMsg;
                _client.statusText += statusText_event;
            }
            catch (Exception e)
            {

            }
        }

        //izpis v statusno okno
        private void statusText_event(NetworkType nType, StatusType sType, string status)
        {
            statusText(nType, sType, status);
        }
        
        private void recvMsg(Protocol rezultat)
        {
            recivedMsg(rezultat);
        }
        
        public void Send(Protocol mesg)
        {
            if (_server != null)
                _server.Send(mesg);
            else if (_client != null)
                _client.Send(mesg);
        }

        public void Stop()
        {
            if (_server != null)
                _server.stop();
            if (_client != null)
                _client.stop();
        }
        
        //vzpostavljanje povezave
        public bool Connected
        {
            get
            {
                if (_server != null && _server.Connected)
                    return true;
                if (_client != null && _client.Connected)
                    return true;

                return false;
            }
        }
    }
}
