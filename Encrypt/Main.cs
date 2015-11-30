using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;

namespace Encrypt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(UnEncrypttxt.Text))
            {
                Encrypttxt.Text = HttpUtility.UrlEncode(DES.Encode(UnEncrypttxt.Text, DES.SECRET), Encoding.UTF8);
            }
            else
            {
                MessageBox.Show("请输入待加密字符串！");
            }

        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnEncryptBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Encrypttxt.Text))
            {
                UnEncrypttxt.Text = DES.Decode(HttpUtility.UrlDecode(Encrypttxt.Text, Encoding.UTF8), DES.SECRET);
            }
            else
            {
                MessageBox.Show("请输入待解密字符串！");
            }
        }
    }
}
