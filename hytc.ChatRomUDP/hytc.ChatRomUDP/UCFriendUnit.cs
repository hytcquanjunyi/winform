using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hytc.ChatRomUDP
{
    public partial class UCFriendUnit : UserControl
    {
        private mainForm mainfrm;

        public mainForm Mainfrm
        {
            get { return mainfrm; }
            set { mainfrm = value; }
        }
        private Friend curFriend;

        public Friend CurFriend
        {
            get { return curFriend; }
            set { 
                curFriend = value;
                this.lblNickName.Text = value.NikNme;
                this.lblshoushou.Text = value.ShouShou;
                this.picHeadImge.Image = this.mainfrm.imageList1.Images[value.PicIndex];
            }
        }
    
        public UCFriendUnit()
        {
            InitializeComponent();
        }

        private void UCFriendUnit_Load(object sender, EventArgs e)
        {

        }
    }
}
