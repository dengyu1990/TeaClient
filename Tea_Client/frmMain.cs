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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        /*    湖南城市学院作息时间
         * 
         * 第一节   8:00——8:45
         * 第二节   8:55——9:40
         * 第三节  10:00——10:45
         * 第四节  10:55——11:40
         * 
         * 第五节  14:00——14:45
         * 第六节  14:55——15:40
         * 第七节  15:50——16:35
         * 第八节  16:45——17:30
         */
        int h, m;
        int count = -1;
        public void TimeLeft(int h, int m)
        {
            switch (h)
            {
                case 8:
                case 10:
                case 14:
                    if (m < 45)
                        count = 45 - m;
                    else if (m > 54)
                        count = 100 - m;
                    else
                        count = 0;
                    break;
                case 9:
                case 11:
                    if (m < 40)
                        count = 40 - m;
                    else
                        count = 0;
                    break;
                case 15:
                    if (m < 40)
                        count = 40 - m;
                    else if (m > 54)
                        count = 95 - m;
                    else
                        count = 0;
                    break;
                case 16:
                    if (m < 35)
                        count = 35 - m;
                    else if (m > 44)
                        count = 90 - m;
                    else
                        count = 0;
                    break;
                case 17:
                    if(m<30)
                        count=30-m;
                    break;
                default:
                    break;
            }
        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            frmSign frmQian = new frmSign();
            frmQian.ShowDialog();
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            frmLottery frmChoujiang = new frmLottery();
            frmChoujiang.ShowDialog();
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            ShowTime();
        }
        public void ShowTime()
        {
            lblTime.Visible = true;
            btnSign.Visible = false;
            btnLottery.Visible = false;
            btnMain.Visible = false;
            this.Opacity = 0.5;
        }
        public void ShowControl()
        {
            lblTime.Visible = false;
            btnSign.Visible = true;
            btnLottery.Visible = true;
            btnMain.Visible = true;
            this.Opacity = 0.8;
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            ShowControl();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMeun frmMenu = new frmMeun();
            frmMenu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定现在就退出教师端系统吗？", "退出系统", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            return;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - 210;
            this.Top = 30;
            this.Opacity = 0.5;
        }

        private void tmrCount_Tick(object sender, EventArgs e)
        {
            h = DateTime.Now.Hour;
            m = DateTime.Now.Minute;
            TimeLeft(h, m);
            if (count == 0)
                lblTime.Text = "课间休息时间";
            else if (count == -1)
                lblTime.Text = "非上课时间";
            else
                lblTime.Text = "还有" + count + "分钟";
        }
    }
}
