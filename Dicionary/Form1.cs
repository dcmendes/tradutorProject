using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dicionary
{
    public partial class Form1 : Form
    {
       
        private string input;
   

        public Form1()
        {
            InitializeComponent();           
        }

        private void translate_Click(object sender, EventArgs e)
        {
            
            try
            {

                
                UdpClient udpClient = new UdpClient();
                udpClient.Connect("127.0.0.1", 80);

                input = inputText.Text.ToString();

                Byte[] sendBytes = Encoding.ASCII.GetBytes(input);


                udpClient.Send(sendBytes, sendBytes.Length);

                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

               
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);

                receiveBox.Text = returnData;

                inputText.Text = "";
                

                udpClient.Close();

            }
            catch (Exception ex)
            {
                erroLabel.Text = ex.ToString();
            }

        }

    }
}
