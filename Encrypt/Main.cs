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
            Sunisoft.IrisSkin.SkinEngine se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinAllForm = true;//所有窗体应用此皮肤
            se.SkinFile = @"..\..\skin\MSN.ssk";
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(UnEncrypttxt.Text.Trim()))
            {
                Encrypttxt.Text = HttpUtility.UrlEncode(DES.Encode(UnEncrypttxt.Text.Trim(), DES.SECRET), Encoding.UTF8);
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
            if (!string.IsNullOrWhiteSpace(Encrypttxt.Text.Trim()))
            {
                UnEncrypttxt.Text = DES.Decode(HttpUtility.UrlDecode(Encrypttxt.Text.Trim(), Encoding.UTF8), DES.SECRET);
            }
            else
            {
                MessageBox.Show("请输入待解密字符串！");
            }
        }

        /// <summary>
        /// 生成cookie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cookieBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UnEncrypttxt.Text.Trim()))
            {
                MessageBox.Show("请输入待加密字符串！");
                return;
            }
            if (string.IsNullOrWhiteSpace(openidTxt.Text.Trim()))
            {
                MessageBox.Show("请输入openid！");
                return;
            }
            cookieTxt.Text = string.Format("CooperateUserId={0}&openid={0}&MemberId={1}&MemberSysId=33", openidTxt.Text.Trim(), HttpUtility.UrlEncode(DES.Encode(UnEncrypttxt.Text.Trim(), DES.SECRET), Encoding.UTF8));
        }

    }
}
