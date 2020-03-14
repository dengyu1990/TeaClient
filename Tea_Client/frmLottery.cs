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
    public partial class frmLottery : Form
    {
        public frmLottery()
        {
            InitializeComponent();
        }
        int i;
        int sum = 0;
        Random r = new Random();
        private void picLottery_Click(object sender, EventArgs e)
        {
            sum = 0;
            lblLuckDog.ForeColor = Color.FromArgb(192, 192, 255);
            lblLuckDog.BackColor = Color.Transparent;
            tmrLottery.Start();
        }

        private void frmLottery_Load(object sender, EventArgs e)
        {
            tmrLottery.Stop();
            picLottery.Image = Resources.pic_start;
            lblLuckDog.Text = "摇奖吧";
        }
        public void NextStu(int i)
        {
            switch (i)
            {
                case 1:
                    picLottery.Image = Resources.pic_caoli;
                    lblLuckDog.Text = "曹礼";
                    break;
                case 2:
                    picLottery.Image = Resources.pic_cat;
                    lblLuckDog.Text = "刘新利";
                    break;
                case 3:
                    picLottery.Image = Resources.pic_fish;
                    lblLuckDog.Text = "邓宇";
                    break;
                case 4:
                    picLottery.Image = Resources.pic_rat;
                    lblLuckDog.Text = "李浩";
                    break;
                case 5:
                    picLottery.Image = Resources.pic_Liaoliqiang;
                    lblLuckDog.Text = "廖利强";
                    break;
                case 6:
                    picLottery.Image = Resources.pic_Wangli;
                    lblLuckDog.Text = "王莉";
                    break;
                default:
                    break;
            }
        }

        private void tmrLottery_Tick(object sender, EventArgs e)
        {
            if (sum > 100)
            {
                tmrLottery.Stop();
                lblLuckDog.ForeColor = Color.Red;
                lblLuckDog.BackColor = Color.Yellow;
            }
            i = r.Next() % 7;
            NextStu(i);
            sum += i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
