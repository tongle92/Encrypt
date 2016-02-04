namespace Encrypt
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.UnEncryptlbl = new System.Windows.Forms.Label();
            this.UnEncrypttxt = new System.Windows.Forms.TextBox();
            this.Encrypttxt = new System.Windows.Forms.TextBox();
            this.Encryptlbl = new System.Windows.Forms.Label();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.UnEncryptBtn = new System.Windows.Forms.Button();
            this.openidTxt = new System.Windows.Forms.TextBox();
            this.openidLbl = new System.Windows.Forms.Label();
            this.cookieTxt = new System.Windows.Forms.TextBox();
            this.cookieLbl = new System.Windows.Forms.Label();
            this.cookieBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UnEncryptlbl
            // 
            this.UnEncryptlbl.AutoSize = true;
            this.UnEncryptlbl.Location = new System.Drawing.Point(143, 75);
            this.UnEncryptlbl.Name = "UnEncryptlbl";
            this.UnEncryptlbl.Size = new System.Drawing.Size(77, 12);
            this.UnEncryptlbl.TabIndex = 0;
            this.UnEncryptlbl.Text = "加密前字符串";
            // 
            // UnEncrypttxt
            // 
            this.UnEncrypttxt.Location = new System.Drawing.Point(233, 15);
            this.UnEncrypttxt.Multiline = true;
            this.UnEncrypttxt.Name = "UnEncrypttxt";
            this.UnEncrypttxt.Size = new System.Drawing.Size(300, 150);
            this.UnEncrypttxt.TabIndex = 1;
            // 
            // Encrypttxt
            // 
            this.Encrypttxt.Location = new System.Drawing.Point(233, 182);
            this.Encrypttxt.Multiline = true;
            this.Encrypttxt.Name = "Encrypttxt";
            this.Encrypttxt.Size = new System.Drawing.Size(300, 150);
            this.Encrypttxt.TabIndex = 3;
            // 
            // Encryptlbl
            // 
            this.Encryptlbl.AutoSize = true;
            this.Encryptlbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Encryptlbl.Location = new System.Drawing.Point(143, 242);
            this.Encryptlbl.Name = "Encryptlbl";
            this.Encryptlbl.Size = new System.Drawing.Size(77, 12);
            this.Encryptlbl.TabIndex = 2;
            this.Encryptlbl.Text = "加密后字符串";
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(627, 75);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(90, 30);
            this.EncryptBtn.TabIndex = 4;
            this.EncryptBtn.Text = "加密";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // UnEncryptBtn
            // 
            this.UnEncryptBtn.Location = new System.Drawing.Point(627, 242);
            this.UnEncryptBtn.Name = "UnEncryptBtn";
            this.UnEncryptBtn.Size = new System.Drawing.Size(90, 30);
            this.UnEncryptBtn.TabIndex = 5;
            this.UnEncryptBtn.Text = "解密";
            this.UnEncryptBtn.UseVisualStyleBackColor = true;
            this.UnEncryptBtn.Click += new System.EventHandler(this.UnEncryptBtn_Click);
            // 
            // openidTxt
            // 
            this.openidTxt.Location = new System.Drawing.Point(233, 354);
            this.openidTxt.Multiline = true;
            this.openidTxt.Name = "openidTxt";
            this.openidTxt.Size = new System.Drawing.Size(300, 150);
            this.openidTxt.TabIndex = 9;
            // 
            // openidLbl
            // 
            this.openidLbl.AutoSize = true;
            this.openidLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openidLbl.Location = new System.Drawing.Point(143, 414);
            this.openidLbl.Name = "openidLbl";
            this.openidLbl.Size = new System.Drawing.Size(41, 12);
            this.openidLbl.TabIndex = 8;
            this.openidLbl.Text = "OpenId";
            // 
            // cookieTxt
            // 
            this.cookieTxt.Location = new System.Drawing.Point(233, 526);
            this.cookieTxt.Multiline = true;
            this.cookieTxt.Name = "cookieTxt";
            this.cookieTxt.Size = new System.Drawing.Size(300, 150);
            this.cookieTxt.TabIndex = 11;
            // 
            // cookieLbl
            // 
            this.cookieLbl.AutoSize = true;
            this.cookieLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cookieLbl.Location = new System.Drawing.Point(143, 586);
            this.cookieLbl.Name = "cookieLbl";
            this.cookieLbl.Size = new System.Drawing.Size(41, 12);
            this.cookieLbl.TabIndex = 10;
            this.cookieLbl.Text = "Cookie";
            // 
            // cookieBtn
            // 
            this.cookieBtn.Location = new System.Drawing.Point(627, 500);
            this.cookieBtn.Name = "cookieBtn";
            this.cookieBtn.Size = new System.Drawing.Size(90, 30);
            this.cookieBtn.TabIndex = 12;
            this.cookieBtn.Text = "生成cookie";
            this.cookieBtn.UseVisualStyleBackColor = true;
            this.cookieBtn.Click += new System.EventHandler(this.cookieBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.cookieBtn);
            this.Controls.Add(this.cookieTxt);
            this.Controls.Add(this.cookieLbl);
            this.Controls.Add(this.openidTxt);
            this.Controls.Add(this.openidLbl);
            this.Controls.Add(this.UnEncryptBtn);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.Encrypttxt);
            this.Controls.Add(this.Encryptlbl);
            this.Controls.Add(this.UnEncrypttxt);
            this.Controls.Add(this.UnEncryptlbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加密解密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UnEncryptlbl;
        private System.Windows.Forms.TextBox UnEncrypttxt;
        private System.Windows.Forms.TextBox Encrypttxt;
        private System.Windows.Forms.Label Encryptlbl;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Button UnEncryptBtn;
        private System.Windows.Forms.TextBox openidTxt;
        private System.Windows.Forms.Label openidLbl;
        private System.Windows.Forms.TextBox cookieTxt;
        private System.Windows.Forms.Label cookieLbl;
        private System.Windows.Forms.Button cookieBtn;

    }
}

