namespace Tea_Client
{
    partial class frmMain
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
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrCount = new System.Windows.Forms.Timer(this.components);
            this.btnSign = new System.Windows.Forms.Button();
            this.btnLottery = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.Lime;
            this.lblTime.Location = new System.Drawing.Point(6, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(150, 36);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "汪老师您好";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // tmrCount
            // 
            this.tmrCount.Enabled = true;
            this.tmrCount.Interval = 1000;
            this.tmrCount.Tick += new System.EventHandler(this.tmrCount_Tick);
            // 
            // btnSign
            // 
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.ForeColor = System.Drawing.Color.White;
            this.btnSign.Image = global::Tea_Client.Properties.Resources.pic_Sign;
            this.btnSign.Location = new System.Drawing.Point(12, 9);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(40, 40);
            this.btnSign.TabIndex = 1;
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Visible = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnLottery
            // 
            this.btnLottery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLottery.ForeColor = System.Drawing.Color.White;
            this.btnLottery.Image = global::Tea_Client.Properties.Resources.pic_Lottery;
            this.btnLottery.Location = new System.Drawing.Point(58, 9);
            this.btnLottery.Name = "btnLottery";
            this.btnLottery.Size = new System.Drawing.Size(40, 40);
            this.btnLottery.TabIndex = 2;
            this.btnLottery.UseVisualStyleBackColor = true;
            this.btnLottery.Visible = false;
            this.btnLottery.Click += new System.EventHandler(this.btnLottery_Click);
            // 
            // btnMain
            // 
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.Image = global::Tea_Client.Properties.Resources.pic_Main;
            this.btnMain.Location = new System.Drawing.Point(104, 9);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(40, 40);
            this.btnMain.TabIndex = 3;
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Visible = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(159, -5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(180, 60);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLottery);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrCount;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnLottery;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button button1;
    }
}