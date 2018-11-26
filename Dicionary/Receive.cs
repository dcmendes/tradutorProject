using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dicionary
{
    class Receive
    {
        int porta;
        string ip;
        string returnData;
        UdpClient clientUDP;
        IPEndPoint RemoteIpEndPoint;// = new IPEndPoint(IPAddress.Any, int porta);
 
        public Receive()
        {
            porta = 80;
            ip = "localhost";
            
        }

        /*public string getMsg()
        {
            thread = new Thread(new ThreadStart( run));
            thread.Start(this);
            return "oi";
        }

        public void run(){

            RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 80);

            Byte[] receiveBytes = clientUDP.Receive(ref RemoteIpEndPoint);
            string returnData = Encoding.ASCII.GetString(receiveBytes);

            //return returnData;
        }*/
       public string getMsg()
        {
            clientUDP = new UdpClient(ip, porta);
            RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            Byte[] receiveBytes = clientUDP.Receive(ref RemoteIpEndPoint);
            returnData = Encoding.ASCII.GetString(receiveBytes);

            return returnData;
        }

        public string getRetunData()
        {
            return returnData;
        }

        public void run(){
            clientUDP = new UdpClient(ip, porta);
            RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            Byte[] receiveBytes = clientUDP.Receive(ref RemoteIpEndPoint);
            returnData = Encoding.ASCII.GetString(receiveBytes);

        }

    }
}
