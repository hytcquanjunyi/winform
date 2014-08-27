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

namespace hytc.ChatRomUDP
{
    public partial class talkFrm : Form
    {
        Friend curFriend;
        public talkFrm()
        {
            InitializeComponent();
        }


        public talkFrm(Friend fr)
        {
            InitializeComponent();

            curFriend = fr;

        }
        private void talkFrm_Load(object sender, EventArgs e)
        {
            this.Text = "与" + curFriend.NikNme + "聊天中";
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            UdpClient client = new UdpClient();

            IPEndPoint iept = new IPEndPoint(curFriend.IP,9527);

            string msgstring = "MSG|" + this.txtmessage.Text;

            byte[] msgbyte = Encoding.Default.GetBytes(msgstring);

            client.Send(msgbyte,msgbyte.Length,iept);

        }

        private void talkFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            curFriend.IsOpen = false;
        }
    }
}
