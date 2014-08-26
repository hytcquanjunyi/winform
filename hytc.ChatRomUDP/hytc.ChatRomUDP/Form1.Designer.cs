namespace hytc.ChatRomUDP
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnlogin = new System.Windows.Forms.Button();
            this.panelFriendList = new System.Windows.Forms.Panel();
            this.picHeadImage = new System.Windows.Forms.PictureBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.lblshoushou = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(211, 67);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(53, 23);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "登录";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // panelFriendList
            // 
            this.panelFriendList.AutoScroll = true;
            this.panelFriendList.Location = new System.Drawing.Point(7, 96);
            this.panelFriendList.Name = "panelFriendList";
            this.panelFriendList.Size = new System.Drawing.Size(257, 346);
            this.panelFriendList.TabIndex = 1;
            // 
            // picHeadImage
            // 
            this.picHeadImage.Location = new System.Drawing.Point(9, 9);
            this.picHeadImage.Name = "picHeadImage";
            this.picHeadImage.Size = new System.Drawing.Size(80, 80);
            this.picHeadImage.TabIndex = 2;
            this.picHeadImage.TabStop = false;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(95, 22);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(41, 12);
            this.lblNickName.TabIndex = 3;
            this.lblNickName.Text = "label1";
            // 
            // lblshoushou
            // 
            this.lblshoushou.AutoSize = true;
            this.lblshoushou.Location = new System.Drawing.Point(95, 52);
            this.lblshoushou.Name = "lblshoushou";
            this.lblshoushou.Size = new System.Drawing.Size(41, 12);
            this.lblshoushou.TabIndex = 4;
            this.lblshoushou.Text = "label2";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(142, 19);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(100, 21);
            this.txtNickName.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.png");
            this.imageList1.Images.SetKeyName(1, "1.png");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.png");
            this.imageList1.Images.SetKeyName(4, "4.png");
            this.imageList1.Images.SetKeyName(5, "5.png");
            this.imageList1.Images.SetKeyName(6, "6.png");
            this.imageList1.Images.SetKeyName(7, "7.png");
            this.imageList1.Images.SetKeyName(8, "8.png");
            this.imageList1.Images.SetKeyName(9, "9.png");
            this.imageList1.Images.SetKeyName(10, "10.png");
            this.imageList1.Images.SetKeyName(11, "Chogath_Square_0.png");
            this.imageList1.Images.SetKeyName(12, "Corki_Square_0.png");
            this.imageList1.Images.SetKeyName(13, "Darius_Square_0.png");
            this.imageList1.Images.SetKeyName(14, "Diana_Square_0.png");
            this.imageList1.Images.SetKeyName(15, "Draven_Square_0.png");
            this.imageList1.Images.SetKeyName(16, "DrMundo_Square_0.png");
            this.imageList1.Images.SetKeyName(17, "Evelynn_Square_0.png");
            this.imageList1.Images.SetKeyName(18, "Ezreal_Square_0.png");
            this.imageList1.Images.SetKeyName(19, "Fiddlesticks_Square_0.png");
            this.imageList1.Images.SetKeyName(20, "Fiora_Square_0.png");
            this.imageList1.Images.SetKeyName(21, "Fizz_square_0.png");
            this.imageList1.Images.SetKeyName(22, "Galio_Square_0.png");
            this.imageList1.Images.SetKeyName(23, "Gangplank_Square_0.png");
            this.imageList1.Images.SetKeyName(24, "Garen_Square_0.png");
            this.imageList1.Images.SetKeyName(25, "Gragas_Square_0.png");
            this.imageList1.Images.SetKeyName(26, "Graves_Square_0.png");
            this.imageList1.Images.SetKeyName(27, "Hecarim_Square_0.png");
            this.imageList1.Images.SetKeyName(28, "Heimerdinger_Square_0.png");
            this.imageList1.Images.SetKeyName(29, "Irelia_Square_0.png");
            this.imageList1.Images.SetKeyName(30, "Janna_Square_0.png");
            this.imageList1.Images.SetKeyName(31, "JarvanIV_Square_0.png");
            this.imageList1.Images.SetKeyName(32, "Jax_Square_0.png");
            this.imageList1.Images.SetKeyName(33, "Jayce_Square_0.png");
            this.imageList1.Images.SetKeyName(34, "Karma_Square_0.png");
            this.imageList1.Images.SetKeyName(35, "Karthus_Square_0.png");
            this.imageList1.Images.SetKeyName(36, "Kassadin_Square_0.png");
            this.imageList1.Images.SetKeyName(37, "Katarina_Square_0.png");
            this.imageList1.Images.SetKeyName(38, "Kayle_Square_0.png");
            this.imageList1.Images.SetKeyName(39, "Kennen_Square_0.png");
            this.imageList1.Images.SetKeyName(40, "KogMaw_Square_0.png");
            this.imageList1.Images.SetKeyName(41, "Leblanc_Square_0.png");
            this.imageList1.Images.SetKeyName(42, "LeeSin_Square_0.png");
            this.imageList1.Images.SetKeyName(43, "Leona_Square_0.png");
            this.imageList1.Images.SetKeyName(44, "Lulu_Square_0.png");
            this.imageList1.Images.SetKeyName(45, "Lux_Square_0.png");
            this.imageList1.Images.SetKeyName(46, "Malphite_Square_0.png");
            this.imageList1.Images.SetKeyName(47, "Malzahar_Square_0.png");
            this.imageList1.Images.SetKeyName(48, "Maokai_Square_0.png");
            this.imageList1.Images.SetKeyName(49, "MasterYi_Square_0.png");
            this.imageList1.Images.SetKeyName(50, "MissFortune_Square_0.png");
            this.imageList1.Images.SetKeyName(51, "MonkeyKing_Square_0.png");
            this.imageList1.Images.SetKeyName(52, "Mordekaiser_Square_0.png");
            this.imageList1.Images.SetKeyName(53, "Morgana_Square_0.png");
            this.imageList1.Images.SetKeyName(54, "Nasus_Square_0.png");
            this.imageList1.Images.SetKeyName(55, "Nautilus_Square_0.png");
            this.imageList1.Images.SetKeyName(56, "Nidalee_Square_0.png");
            this.imageList1.Images.SetKeyName(57, "Nocturne_Square_0.png");
            this.imageList1.Images.SetKeyName(58, "Nunu_Square_0.png");
            this.imageList1.Images.SetKeyName(59, "Olaf_Square_0.png");
            this.imageList1.Images.SetKeyName(60, "Orianna_Square_0.png");
            this.imageList1.Images.SetKeyName(61, "Pantheon_Square_0.png");
            this.imageList1.Images.SetKeyName(62, "Poppy_Square_0.png");
            this.imageList1.Images.SetKeyName(63, "Rammus_Square_0.png");
            this.imageList1.Images.SetKeyName(64, "Renekton_Square_0.png");
            this.imageList1.Images.SetKeyName(65, "Rengar_Square_0.png");
            this.imageList1.Images.SetKeyName(66, "Riven_Square_0.png");
            this.imageList1.Images.SetKeyName(67, "Rumble_Square_0.png");
            this.imageList1.Images.SetKeyName(68, "Ryze_Square_0.png");
            this.imageList1.Images.SetKeyName(69, "Sejuani_Square_0.png");
            this.imageList1.Images.SetKeyName(70, "Shaco_Square_0.png");
            this.imageList1.Images.SetKeyName(71, "Shen_Square_0.png");
            this.imageList1.Images.SetKeyName(72, "Shyvana_Square_0.png");
            this.imageList1.Images.SetKeyName(73, "Singed_Square_0.png");
            this.imageList1.Images.SetKeyName(74, "Sion_Square_0.png");
            this.imageList1.Images.SetKeyName(75, "Sivir_Square_0.png");
            this.imageList1.Images.SetKeyName(76, "Skarner_Square_0.png");
            this.imageList1.Images.SetKeyName(77, "Sona_Square_0.png");
            this.imageList1.Images.SetKeyName(78, "Soraka_Square_0.png");
            this.imageList1.Images.SetKeyName(79, "Swain_Square_0.png");
            this.imageList1.Images.SetKeyName(80, "Syndra_Square_0.png");
            this.imageList1.Images.SetKeyName(81, "Talon_Square_0.png");
            this.imageList1.Images.SetKeyName(82, "Taric_Square_0.png");
            this.imageList1.Images.SetKeyName(83, "Teemo_Square_0.png");
            this.imageList1.Images.SetKeyName(84, "Tristana_Square_0.png");
            this.imageList1.Images.SetKeyName(85, "Trundle_Square_0.png");
            this.imageList1.Images.SetKeyName(86, "Tryndamere_Square_0.png");
            this.imageList1.Images.SetKeyName(87, "TwistedFate_Square_0.png");
            this.imageList1.Images.SetKeyName(88, "Twitch_Square_0.png");
            this.imageList1.Images.SetKeyName(89, "Udyr_Square_0.png");
            this.imageList1.Images.SetKeyName(90, "Urgot_Square_0.png");
            this.imageList1.Images.SetKeyName(91, "Varus_Square_0.png");
            this.imageList1.Images.SetKeyName(92, "Vayne_Square_0.png");
            this.imageList1.Images.SetKeyName(93, "Veigar_Square_0.png");
            this.imageList1.Images.SetKeyName(94, "Viktor_Square_0.png");
            this.imageList1.Images.SetKeyName(95, "Vladimir_Square_0.png");
            this.imageList1.Images.SetKeyName(96, "Volibear_Square_0.png");
            this.imageList1.Images.SetKeyName(97, "Warwick_Square_0.png");
            this.imageList1.Images.SetKeyName(98, "Xerath_Square_0.png");
            this.imageList1.Images.SetKeyName(99, "XinZhao_Square_0.png");
            this.imageList1.Images.SetKeyName(100, "Yorick_Square_0.png");
            this.imageList1.Images.SetKeyName(101, "Ziggs_Square_0.png");
            this.imageList1.Images.SetKeyName(102, "Zilean_Square_0.png");
            this.imageList1.Images.SetKeyName(103, "Zyra_Square_0.png");
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 454);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.lblshoushou);
            this.Controls.Add(this.lblNickName);
            this.Controls.Add(this.picHeadImage);
            this.Controls.Add(this.panelFriendList);
            this.Controls.Add(this.btnlogin);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Panel panelFriendList;
        private System.Windows.Forms.PictureBox picHeadImage;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.Label lblshoushou;
        private System.Windows.Forms.TextBox txtNickName;
        public System.Windows.Forms.ImageList imageList1;
    }
}

