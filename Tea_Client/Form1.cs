using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tea_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("还未登录您确定现在就退出吗？", "iCloud 2012 教师端", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            return;
        }

        private void txtTeacherNo_Enter(object sender, EventArgs e)
        {
            txtTeacherNo.Text = "";
            txtTeacherNo.ForeColor = Color.Olive;
        }

        private void txtTeacherNo_Leave(object sender, EventArgs e)
        {
            if (txtTeacherNo.Text.Trim() == "")
            {
                txtTeacherNo.ForeColor = Color.DarkGray;
                txtTeacherNo.Text = "教师工号";
            }
            return;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Olive;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                txtPassword.ForeColor = Color.DarkGray;
                txtPassword.Text = "密码";
            }
            return;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 0)
            {
                if (true)//判断教师工号正则表达式正确
                {
                    btnLogin.Enabled = true; //防止按回车键进入界面
                    btnLogin.Visible = true;
                }
                //else
                //{
                //    txtTeacherNo.Text = "工号格式不正确";
                //    txtTeacherNo.ForeColor = Color.Red;
                //    txtTeacherNo.BackColor = Color.Yellow;
                //}
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTeacherNo.Text.Trim() == "110110")//txtTeacherNo.Text.Trim() == "0906401"
            {
                if (txtPassword.Text.Trim() == "901116")
                {
                    frmMain frmContent = new frmMain();
                    frmContent.Show();
                    this.Hide();
                }
                else
                {
                    txtPassword.Text = "密码错误";
                    txtPassword.ForeColor = Color.Red;
                    txtPassword.BackColor = Color.Yellow;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - 800;
            this.Top = 200;
        }
    }
}
