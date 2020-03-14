using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tea_Client.Properties;

namespace Tea_Client
{
    public partial class frmSign : Form
    {
        public frmSign()
        {
            InitializeComponent();
        }
        int i = 1;
        string stu_name = null;
        private void frmSign_Load(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - 800;
            this.Top = 120;
            picStu.Image = Resources.pic_begin;
            tmrStu.Enabled = true;
            tmrStu.Start();
        }
        private void tmrStu_Tick(object sender, EventArgs e)
        {
            NextStu(i++);
        }
        public void NextStu(int i)
        {
            switch (i)
            {
                case 1:
                    picStu.Image = Resources.pic_caoli;
                    lblNameMsg.Text = "曹礼  0902201-14";
                    lblSignMsg.Text = "无旷课记录  迟到：2";
                    lblTELMsg.Text = "一般正常学生";
                    break;
                case 2:
                    picStu.Image = Resources.pic_cat;
                    lblNameMsg.Text = "刘新力  0906402-05";
                    lblSignMsg.Text = "旷课：1  迟到：2次";
                    lblTELMsg.Text = "一般正常学生";
                    showBtn("刘新力");
                    break;
                case 3:
                    picStu.Image = Resources.pic_Wanglu;
                    lblNameMsg.Text = "王璐  0906101-33";
                    lblSignMsg.Text = "无旷课和迟到记录";
                    lblTELMsg.Text = "标准好学生";
                    break;
                case 4:
                    picStu.Image = Resources.pic_rat;
                    lblNameMsg.Text = "李浩  0906401-30";
                    lblSignMsg.Text = "旷课：3  无迟到记录";
                    lblTELMsg.Text = "要么去要么不去";
                    showBtn("李浩");
                    break;
                case 5:
                    picStu.Image = Resources.pic_liuwu;
                    lblNameMsg.Text = "刘武  0906401-22";
                    lblSignMsg.Text = "旷课：0  迟到：0次";
                    lblTELMsg.Text = "这是一种怎样的境界";
                    break;
                case 6:
                    lblAlarm.Visible = false;
                    picStu.Image = Resources.pic_Liaoliqiang;
                    lblNameMsg.Text = "料理强  0906401-15";
                    lblSignMsg.Text = "旷课：5  迟到：1次";
                    lblTELMsg.Text = "这是一种怎样的境界";
                    break;
                case 7:
                    picStu.Image = Resources.pic_Wangli;
                    lblNameMsg.Text = "王莉  0906101-35";
                    lblSignMsg.Text = "旷课：0  迟到：0次";
                    lblTELMsg.Text = "这是一种怎样的境界";
                    break;
                case 8:
                    picStu.Image = Resources.pic_fish;
                    lblNameMsg.Text = "邓宇  0906401-23";
                    lblSignMsg.Text = "无旷课和迟到记录";
                    lblTELMsg.Text = "一般好学生";
                    break;
                default:
                    picStu.Image = Resources.pic_begin;
                    lblNameMsg.Text = "已完成签到";
                    lblSignMsg.Text = "应到:7人  实到:5人";
                    lblTELMsg.Text = "请老师指示";
                    tmrStu.Stop();
                    break;

            }
        }
        public void showBtn(string name)
        {
            lblAlarm.Visible = true;
            btnSendMsg.Visible = true;
            btnNext.Visible = true;
            stu_name = name;
            tmrStu.Stop();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            btnSendMsg.Visible = false;
            lblAlarm.Visible = false;
            tmrStu.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            tmrStu.Stop();
            DialogResult result = MessageBox.Show("确实要提前停止签到吗？", "停止签到", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tmrStu.Enabled = false;
                this.Close();
            }
            tmrStu.Start();
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("短信已经成功发送给" + stu_name + "！", "发送成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}