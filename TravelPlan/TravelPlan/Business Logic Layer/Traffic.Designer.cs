namespace TravelPlan
{
    partial class Traffic
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.webBrowTraffic = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(809, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "보기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(27, 6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 12);
            this.lblStatus.TabIndex = 2;
            // 
            // webBrowTraffic
            // 
            this.webBrowTraffic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowTraffic.Location = new System.Drawing.Point(0, 29);
            this.webBrowTraffic.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowTraffic.Name = "webBrowTraffic";
            this.webBrowTraffic.Size = new System.Drawing.Size(884, 394);
            this.webBrowTraffic.TabIndex = 3;
            // 
            // Traffic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.webBrowTraffic);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button1);
            this.Name = "Traffic";
            this.Size = new System.Drawing.Size(884, 423);
            this.Load += new System.EventHandler(this.Traffic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.WebBrowser webBrowTraffic;
    }
}
