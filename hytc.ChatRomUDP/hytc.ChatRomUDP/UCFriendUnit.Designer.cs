namespace hytc.ChatRomUDP
{
    partial class UCFriendUnit
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFriendUnit));
            this.picHeadImge = new System.Windows.Forms.PictureBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.lblshoushou = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImge)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeadImge
            // 
            this.picHeadImge.Image = ((System.Drawing.Image)(resources.GetObject("picHeadImge.Image")));
            this.picHeadImge.Location = new System.Drawing.Point(3, 3);
            this.picHeadImge.Name = "picHeadImge";
            this.picHeadImge.Size = new System.Drawing.Size(40, 40);
            this.picHeadImge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeadImge.TabIndex = 0;
            this.picHeadImge.TabStop = false;
            this.picHeadImge.DoubleClick += new System.EventHandler(this.picHeadImge_DoubleClick);
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(64, 8);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(41, 12);
            this.lblNickName.TabIndex = 1;
            this.lblNickName.Text = "label1";
            this.lblNickName.DoubleClick += new System.EventHandler(this.lblNickName_DoubleClick);
            // 
            // lblshoushou
            // 
            this.lblshoushou.AutoSize = true;
            this.lblshoushou.Location = new System.Drawing.Point(64, 27);
            this.lblshoushou.Name = "lblshoushou";
            this.lblshoushou.Size = new System.Drawing.Size(41, 12);
            this.lblshoushou.TabIndex = 2;
            this.lblshoushou.Text = "label2";
            this.lblshoushou.DoubleClick += new System.EventHandler(this.lblshoushou_DoubleClick);
            // 
            // UCFriendUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblshoushou);
            this.Controls.Add(this.lblNickName);
            this.Controls.Add(this.picHeadImge);
            this.Name = "UCFriendUnit";
            this.Size = new System.Drawing.Size(176, 42);
            this.Load += new System.EventHandler(this.UCFriendUnit_Load);
            this.DoubleClick += new System.EventHandler(this.UCFriendUnit_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeadImge;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.Label lblshoushou;
    }
}
