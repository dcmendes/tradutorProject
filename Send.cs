using System;
using System.Sockets;
 

public class Send 

{

    private DatagramSocket aSocket = null;
    private string msgSend;
    byte[] b = new byte[1024];

    public Send()
	{
        aSocket = new DatagramSocket();
        byte[] m = new byte[1204];
        InetAddress aHost = InetAddress.getByName("localhost");
        int serverPort = 80;

        DatagramPacket request = new DatagramPacket(msg.getBytes(), msg.getBytes().length, aHost,
                        serverPort);
        aSocket.send(request);
        byte[] buffer = new byte[1000];


    }

    public byte[] B { get => b; set => b = value; }
    public DatagramSocket ASocket { get => aSocket; set => aSocket = value; }
    public string MsgSend { get => msgSend; set => msgSend = value; }
}
