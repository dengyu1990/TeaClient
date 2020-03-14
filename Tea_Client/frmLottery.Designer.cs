namespace Tea_Client
{
    partial class frmLottery
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
            this.lblLuckDog = new System.Windows.Forms.Label();
            this.picLottery = new System.Windows.Forms.PictureBox();
            this.tmrLottery = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLottery)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLuckDog
            // 
            this.lblLuckDog.AutoSize = true;
            this.lblLuckDog.BackColor = System.Drawing.Color.Transparent;
            this.lblLuckDog.Enabled = false;
            this.lblLuckDog.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLuckDog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblLuckDog.Location = new System.Drawing.Point(89, 360);
            this.lblLuckDog.Name = "lblLuckDog";
            this.lblLuckDog.Size = new System.Drawing.Size(75, 38);
            this.lblLuckDog.TabIndex = 1;
            this.lblLuckDog.Text = "邓宇";
            // 
            // picLottery
            // 
            this.picLottery.Location = new System.Drawing.Point(21, 37);
            this.picLottery.Name = "picLottery";
            this.picLottery.Size = new System.Drawing.Size(214, 320);
            this.picLottery.TabIndex = 0;
            this.picLottery.TabStop = false;
            this.picLottery.Click += new System.EventHandler(this.picLottery_Click);
            // 
            // tmrLottery
            // 
            this.tmrLottery.Tick += new System.EventHandler(this.tmrLottery_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(236, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "摇奖机";
            // 
            // frmLottery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(258, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLuckDog);
            this.Controls.Add(this.picLottery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLottery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLottery";
            this.Load += new System.EventHandler(this.frmLottery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLottery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLottery;
        private System.Windows.Forms.Label lblLuckDog;
        private System.Windows.Forms.Timer tmrLottery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}