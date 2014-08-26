namespace hytc.Udpchat
{
    partial class Form1
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
            this.sendbtn = new System.Windows.Forms.Button();
            this.IPaddress = new System.Windows.Forms.TextBox();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(186, 315);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 23);
            this.sendbtn.TabIndex = 0;
            this.sendbtn.Text = "发送";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // IPaddress
            // 
            this.IPaddress.Location = new System.Drawing.Point(55, 38);
            this.IPaddress.Name = "IPaddress";
            this.IPaddress.Size = new System.Drawing.Size(206, 21);
            this.IPaddress.TabIndex = 1;
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(55, 273);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(206, 21);
            this.txtbox.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(55, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(206, 181);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 415);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.IPaddress);
            this.Controls.Add(this.sendbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.TextBox IPaddress;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

