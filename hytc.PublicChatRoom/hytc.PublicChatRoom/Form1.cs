using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace hytc.PublicChatRoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Form1.CheckForIllegalCrossThreadCalls = false;

            Thread mythread = new Thread(reciver);
            mythread.IsBackground = true;
            mythread.Start();
        }

        void reciver()
        {
            UdpClient up = new UdpClient(9527);
            while (true)
            {
               IPEndPoint ipet = new IPEndPoint(IPAddress.Any,0);
               byte[] msgbyte = up.Receive(ref ipet);
               string msgstring = Encoding.Default.GetString(msgbyte);

               string[] split= msgstring.Split('|');
               if (split[0] == "PUBLIC") 
               {
                   this.richTextBox1.Text +=split[2] + "说:" + split[1] + "\r\n";   
               }
               if (split[0] == "INROOM") 
               {
                   this.richTextBox1.Text += split[1] + "登录了 \r\n";
               }
             

            }
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            UdpClient up = new UdpClient();
            string ip ="255.255.255.255";
            IPEndPoint ipet = new IPEndPoint(IPAddress.Parse(ip),9527);
            string msg = "PUBLIC|" + this.textBox1.Text + "|" + this.iptxt.Text;
            byte[] msgbyte = Encoding.Default.GetBytes(msg);
         
                up.Send(msgbyte,msgbyte.Length,ipet);
          
        }

        private void login_Click(object sender, EventArgs e)
        {
            UdpClient up = new UdpClient();
            string ip = "255.255.255.255";
            IPEndPoint ipet = new IPEndPoint(IPAddress.Parse(ip), 9527);
            string msg = "INROOM|" + this.iptxt.Text;
            byte[] msgbyte = Encoding.Default.GetBytes(msg);

            up.Send(msgbyte, msgbyte.Length, ipet);
        }


    }
}
