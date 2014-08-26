using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace hytc.ChatRomUDP
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }


        public delegate void delegateAdd(Friend fr);

        private void mainForm_Load(object sender, EventArgs e)
        {
             
            Thread mythread = new Thread(receiver);

            mythread.IsBackground = true;

            mythread.Start();
    
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            UdpClient client = new UdpClient();
            
            IPEndPoint ipet = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 9527);
            
            string msgstring = "LOGIN|" + this.txtNickName.Text + "|说说|1";
            
            byte[] msgbyte = Encoding.Default.GetBytes(msgstring);
            
            client.Send(msgbyte,msgbyte.Length,ipet);

           
        }


        private void receiver()
        {
            UdpClient client = new UdpClient(9527);

            while (true)
            {
                IPEndPoint iept = new IPEndPoint(IPAddress.Any, 0);

                byte[] msgbyte = client.Receive(ref iept);

                string msgstring = Encoding.Default.GetString(msgbyte);

                string[] split = msgstring.Split('|');

                if (split[0] == "LOGIN")
                {
                    Friend fr = new Friend();

                    fr.NikNme = split[1];

                    fr.ShouShou = split[2];

                    object[] pars=new object[1];

                    pars[0]=fr;

                    this.Invoke(new delegateAdd(this.addUCFriendUnit),pars );
                }
              

            }

        }

        private void addUCFriendUnit(Friend fr) 
        {
            

            UCFriendUnit ucfriend = new UCFriendUnit();
            ucfriend.Mainfrm = this;

            ucfriend.CurFriend = fr;

            ucfriend.Top = panelFriendList.Controls.Count * ucfriend.Height;
            
            panelFriendList.Controls.Add(ucfriend);
        }

    }
}
