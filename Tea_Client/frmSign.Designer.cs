namespace Tea_Client
{
    partial class frmSign
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
            this.components = new System.ComponentModel.Container();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblNameMsg = new System.Windows.Forms.Label();
            this.tmrStu = new System.Windows.Forms.Timer(this.components);
            this.picStu = new System.Windows.Forms.PictureBox();
            this.lblSignMsg = new System.Windows.Forms.Label();
            this.lblTELMsg = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(480, 309);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(98, 36);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "继续签到";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblNameMsg
            // 
            this.lblNameMsg.AutoSize = true;
            this.lblNameMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblNameMsg.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNameMsg.ForeColor = System.Drawing.Color.Lime;
            this.lblNameMsg.Location = new System.Drawing.Point(299, 135);
            this.lblNameMsg.Name = "lblNameMsg";
            this.lblNameMsg.Size = new System.Drawing.Size(258, 35);
            this.lblNameMsg.TabIndex = 1;
            this.lblNameMsg.Text = "计算机网线协议编程";
            // 
            // tmrStu
            // 
            this.tmrStu.Tick += new System.EventHandler(this.tmrStu_Tick);
            // 
            // picStu
            // 
            this.picStu.Location = new System.Drawing.Point(34, 47);
            this.picStu.Name = "picStu";
            this.picStu.Size = new System.Drawing.Size(240, 320);
            this.picStu.TabIndex = 2;
            this.picStu.TabStop = false;
            // 
            // lblSignMsg
            // 
            this.lblSignMsg.AutoSize = true;
            this.lblSignMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblSignMsg.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSignMsg.ForeColor = System.Drawing.Color.Lime;
            this.lblSignMsg.Location = new System.Drawing.Point(299, 190);
            this.lblSignMsg.Name = "lblSignMsg";
            this.lblSignMsg.Size = new System.Drawing.Size(257, 35);
            this.lblSignMsg.TabIndex = 3;
            this.lblSignMsg.Text = "1教204教室 [3-4节]";
            // 
            // lblTELMsg
            // 
            this.lblTELMsg.AutoSize = true;
            this.lblTELMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblTELMsg.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTELMsg.ForeColor = System.Drawing.Color.Lime;
            this.lblTELMsg.Location = new System.Drawing.Point(299, 238);
            this.lblTELMsg.Name = "lblTELMsg";
            this.lblTELMsg.Size = new System.Drawing.Size(198, 35);
            this.lblTELMsg.TabIndex = 4;
            this.lblTELMsg.Text = "签到即将开始...";
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.BackColor = System.Drawing.Color.Yellow;
            this.lblAlarm.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAlarm.ForeColor = System.Drawing.Color.Red;
            this.lblAlarm.Location = new System.Drawing.Point(341, 89);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(158, 31);
            this.lblAlarm.TabIndex = 5;
            this.lblAlarm.Text = "该生本次未到";
            this.lblAlarm.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(659, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 26);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.BackColor = System.Drawing.Color.Transparent;
            this.btnSendMsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMsg.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendMsg.ForeColor = System.Drawing.Color.White;
            this.btnSendMsg.Location = new System.Drawing.Point(376, 309);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(98, 36);
            this.btnSendMsg.TabIndex = 7;
            this.btnSendMsg.Text = "发送短信";
            this.btnSendMsg.UseVisualStyleBackColor = false;
            this.btnSendMsg.Visible = false;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // frmSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tea_Client.Properties.Resources.pic_background;
            this.ClientSize = new System.Drawing.Size(682, 451);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.lblTELMsg);
            this.Controls.Add(this.lblSignMsg);
            this.Controls.Add(this.picStu);
            this.Controls.Add(this.lblNameMsg);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSign";
            this.Load += new System.EventHandler(this.frmSign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblNameMsg;
        private System.Windows.Forms.PictureBox picStu;
        private System.Windows.Forms.Timer tmrStu;
        private System.Windows.Forms.Label lblSignMsg;
        private System.Windows.Forms.Label lblTELMsg;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSendMsg;
    }
}