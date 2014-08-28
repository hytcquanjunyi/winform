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

       public string mynickName;

       public int myheadimage;

       public List<Friend> list = new List<Friend>();

       private void mainForm_Load(object sender, EventArgs e)
       {
            mainForm.CheckForIllegalCrossThreadCalls = false;

            Operation op = new Operation(this);

            IPAddress myIP=op.getMyIP();

            Thread mythread = new Thread(op.receiver);

            mythread.IsBackground = true;

            mythread.Start();

            Thread.Sleep(100);

            UdpClient client = new UdpClient();

            IPEndPoint ipet = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 9527);

            this.txtNickName.Text = myIP.ToString(); ;

            mynickName = this.txtNickName.Text;

            string msgstring = "LOGIN|" + this.txtNickName.Text + "|0|说薯片";

            this.picHeadImage.Image = this.imageList1.Images[0];

            byte[] msgbyte = Encoding.Default.GetBytes(msgstring);

            client.Send(msgbyte, msgbyte.Length, ipet);
           
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {

           
            UdpClient client = new UdpClient();
            
            IPEndPoint ipet = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 9527);

            this.txtNickName.Text = System.Environment.MachineName;

            mynickName = this.txtNickName.Text;
            
            string msgstring = "LOGIN|" + this.txtNickName.Text + "|0|说薯片";

             this.picHeadImage.Image=this.imageList1.Images[0];
            
            byte[] msgbyte = Encoding.Default.GetBytes(msgstring);
            
            client.Send(msgbyte,msgbyte.Length,ipet);
           
        }


       
       
        public void addUCFriendUnit(Friend fr) 
        {
            
            UCFriendUnit ucfriend = new UCFriendUnit();

            ucfriend.Mainfrm = this;
            
            ucfriend.mydbclik+=new EventHandler(ucfriend_mydbclik);
            //ucfriend.DoubleClick += new EventHandler(ucfriend_DoubleClick);

            ucfriend.CurFriend = fr;

            ucfriend.Top = panelFriendList.Controls.Count * ucfriend.Height;

            panelFriendList.Controls.Add(ucfriend);
          
           
        }

        void ucfriend_mydbclik(object sender, EventArgs e) 
        {
            UCFriendUnit ucf = (UCFriendUnit)sender;

            if (ucf.CurFriend.IsOpen != true)
            {
                talkFrm talk = new talkFrm(ucf.CurFriend);
                ucf.CurFriend.IsOpen = true;
                talk.Show();
            }
        }

        void ucfriend_DoubleClick(object sender, EventArgs e)
        {
            UCFriendUnit ucf = (UCFriendUnit)sender;
            
            if (ucf.CurFriend.IsOpen != true)
            {
                talkFrm talk = new talkFrm(ucf.CurFriend);
                ucf.CurFriend.IsOpen = true;
                talk.Show();   
            }
           
        }

        
        
        public void removeUCFriendUnit(Friend fr) 
        {
            UCFriendUnit ucfriend = new UCFriendUnit();
            
            ucfriend.Top = panelFriendList.Controls.Count * ucfriend.Height;

            panelFriendList.Controls.Remove(ucfriend);
        }

        public Panel getPanel() 
        {
            return this.panelFriendList;
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UdpClient client = new UdpClient();

            IPEndPoint ipet = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 9527);

            string msgstring = "LOGOUT";

            byte[] msgbyte = Encoding.Default.GetBytes(msgstring);

            client.Send(msgbyte, msgbyte.Length, ipet);
        }

       

    }
}
