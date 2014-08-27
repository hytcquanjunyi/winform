namespace hytc.ChatRomUDP
{
    partial class talkFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.talkhistroy = new System.Windows.Forms.RichTextBox();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // talkhistroy
            // 
            this.talkhistroy.Location = new System.Drawing.Point(12, 12);
            this.talkhistroy.Name = "talkhistroy";
            this.talkhistroy.Size = new System.Drawing.Size(449, 262);
            this.talkhistroy.TabIndex = 0;
            this.talkhistroy.Text = "";
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(12, 297);
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(388, 21);
            this.txtmessage.TabIndex = 1;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(410, 297);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(51, 22);
            this.btnsend.TabIndex = 2;
            this.btnsend.Text = "发送";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // talkFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 343);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.talkhistroy);
            this.Name = "talkFrm";
            this.Text = "talkFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.talkFrm_FormClosing);
            this.Load += new System.EventHandler(this.talkFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox talkhistroy;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.Button btnsend;
    }
}