namespace TravelPlan { 
    partial class PlanDateControl
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
            this.calFirstDay = new System.Windows.Forms.MonthCalendar();
            this.calLastDay = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFirstDay = new System.Windows.Forms.Label();
            this.lblLastDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calFirstDay
            // 
            this.calFirstDay.Location = new System.Drawing.Point(60, 99);
            this.calFirstDay.Name = "calFirstDay";
            this.calFirstDay.TabIndex = 1;
            this.calFirstDay.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calFirstDay_DateChanged);
            // 
            // calLastDay
            // 
            this.calLastDay.Location = new System.Drawing.Point(392, 99);
            this.calLastDay.Name = "calLastDay";
            this.calLastDay.TabIndex = 2;
            this.calLastDay.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calLastDay_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "날짜 정하기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "시작";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "종료";
            // 
            // lblFirstDay
            // 
            this.lblFirstDay.AutoSize = true;
            this.lblFirstDay.Location = new System.Drawing.Point(197, 270);
            this.lblFirstDay.Name = "lblFirstDay";
            this.lblFirstDay.Size = new System.Drawing.Size(0, 12);
            this.lblFirstDay.TabIndex = 7;
            // 
            // lblLastDay
            // 
            this.lblLastDay.AutoSize = true;
            this.lblLastDay.Location = new System.Drawing.Point(390, 270);
            this.lblLastDay.Name = "lblLastDay";
            this.lblLastDay.Size = new System.Drawing.Size(0, 12);
            this.lblLastDay.TabIndex = 8;
            // 
            // PlanDateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLastDay);
            this.Controls.Add(this.lblFirstDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calLastDay);
            this.Controls.Add(this.calFirstDay);
            this.Name = "PlanDateControl";
            this.Size = new System.Drawing.Size(652, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calFirstDay;
        private System.Windows.Forms.MonthCalendar calLastDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lblFirstDay;
        internal System.Windows.Forms.Label lblLastDay;
    }
}
