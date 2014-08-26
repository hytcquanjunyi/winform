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

namespace hytc.Udpchat
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
           
            Thread mythread = new Thread(receiver);
            mythread.Start();

        }
        private void sendbtn_Click(object sender, EventArgs e)
        {
            string ip=this.IPaddress.Text;
            UdpClient udpclient = new UdpClient();
            IPEndPoint iept = new IPEndPoint(IPAddress.Parse(ip), 9528); 
            string txt = this.txtbox.Text;
            byte[] mesg = Encoding.Default.GetBytes(txt);
            udpclient.Send(mesg,mesg.Length,iept);
        }
        void receiver() 
        {  
            UdpClient udpclient = new UdpClient(9528);
            while(true)
            {
                
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any,0);
                byte[] by = udpclient.Receive(ref ipep);
                string ms = Encoding.Default.GetString(by);
                this.richTextBox1.Text += ms;
            }
        }

       
    }
}
