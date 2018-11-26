using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class Send : IDisposable

{
    int porta; 
    string ip; 
    string msg;
    UdpClient clientUDP;

    public Send()
    {
        porta = 80;
        ip = "localhost";
        

    }
    

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public void setMsg(string s)
    {
        clientUDP = new UdpClient();
        msg = s;
        clientUDP.Connect(ip, porta);
        Byte[] sendBytes = Encoding.ASCII.GetBytes(s);

        clientUDP.Send(sendBytes, sendBytes.Length);
        clientUDP.Close();
    }

   // public boid sendServer()




}
