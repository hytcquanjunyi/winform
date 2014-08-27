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
            
            string msgstring = "lOGIN|" + this.txtNickName.Text + "|0|说薯片";

             this.picHeadImage.Image=this.imageList1.Images[0];
            
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
                Friend fr = new Friend();

                if (split[0] == "lOGIN")
                {
                    
                    UCFriendUnit ucfriend = new UCFriendUnit();


                    fr.NikNme = split[1];

                    fr.ShouShou = split[3];
                    fr.PicIndex =Convert.ToInt32(split[2]);
                    fr.IP = iept.Address;

                    object[] pars=new object[1];

                    pars[0]=fr;

                    this.Invoke(new delegateAdd(this.addUCFriendUnit),pars );
                }
                if (split[0]=="mSG")
                {
                    fr.Message = msgstring;
                    
                }


                if (split[0] == "lOGOUT") 
                {
                   
                    object[] pars = new object[1];
                    pars[0] = fr;
                    this.Invoke(new delegateRemove(this.removeUCFriendUnit), pars);
                }
            }

        }
        public delegate void delegateAdd(Friend fr);
        private void addUCFriendUnit(Friend fr) 
        {
            
            UCFriendUnit ucfriend = new UCFriendUnit();

            ucfriend.Mainfrm = this;
         
            ucfriend.DoubleClick += new EventHandler(ucfriend_DoubleClick);

            ucfriend.CurFriend = fr;

            ucfriend.Top = panelFriendList.Controls.Count * ucfriend.Height;

            panelFriendList.Controls.Add(ucfriend);

           
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

        public delegate void delegateRemove(Friend fr);

        private void removeUCFriendUnit(Friend fr) 
        {
            UCFriendUnit ucfriend = new UCFriendUnit();
            
            ucfriend.Top = panelFriendList.Controls.Count * ucfriend.Height;

            panelFriendList.Controls.Remove(ucfriend);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UdpClient client = new UdpClient();

            IPEndPoint ipet = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 9527);

            string msgstring = "lOGOUT|" + this.txtNickName.Text;

            byte[] msgbyte = Encoding.Default.GetBytes(msgstring);

            client.Send(msgbyte, msgbyte.Length, ipet);
        }

    }
}
