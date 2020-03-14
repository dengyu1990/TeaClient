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
    public partial class frmMeun : Form
    {
        public frmMeun()
        {
            InitializeComponent();
        }

        private void frmMeun_Load(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - 900;
            this.Top = 130;
            // TODO: 这行代码将数据加载到表“dst_TeaClient.T_Rest”中。您可以根据需要移动或移除它。
            this.t_RestTableAdapter.Fill(this.dst_TeaClient.T_Rest);
            // TODO: 这行代码将数据加载到表“dst_TeaClient.T_Schedule”中。您可以根据需要移动或移除它。
            this.t_ScheduleTableAdapter.Fill(this.dst_TeaClient.T_Schedule);
            // TODO: 这行代码将数据加载到表“dst_TeaClient.T_Students”中。您可以根据需要移动或移除它。
            this.t_StudentsTableAdapter.Fill(this.dst_TeaClient.T_Students);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
