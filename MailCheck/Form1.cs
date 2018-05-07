using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailCheck
{
    public partial class MailChecker : Form
    {
        public MailChecker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 郵件判定規格
        /// </summary>
        /// <param name="mail">郵件</param>
        /// <returns>合法回傳TURE/不合法回傳FALSE</returns>
        public bool CheckMail(string mail)
        {
            int atPosition = mail.IndexOf("@");
            int dotPosition = mail.IndexOf(".");
            //Mail檢核邏輯
            return (atPosition > 0) &&
                (atPosition < dotPosition) &&
                (dotPosition < mail.Length - 2);
        }

        /// <summary>
        /// 結果顯示機制
        /// </summary>
        /// <param name="result">判定結果(bool)</param>
        public void ShowResult(bool result)
        {
            if (result)
            {
                lblResult.ForeColor = Color.Lime;
                lblResult.Text = "郵件格式合法！";
            }
            else
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "郵件格式不合法！";
            }
        }

        private void btnSummit_Click(object sender, EventArgs e)
        {
            ShowResult(CheckMail(txtMail.Text.Trim()));
            txtMail.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowResult(CheckMail(txtMail.Text.Trim()));
                txtMail.Focus();
            }
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
        }
    }
}