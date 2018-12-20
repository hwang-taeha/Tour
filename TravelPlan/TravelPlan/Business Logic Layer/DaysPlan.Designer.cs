namespace TravelPlan.Business_Logic_Layer
{
    partial class DaysPlan
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
            this.lvPlans = new System.Windows.Forms.ListView();
            this.lblDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvPlans
            // 
            this.lvPlans.Location = new System.Drawing.Point(21, 63);
            this.lvPlans.Name = "lvPlans";
            this.lvPlans.Size = new System.Drawing.Size(275, 97);
            this.lvPlans.TabIndex = 0;
            this.lvPlans.UseCompatibleStateImageBehavior = false;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(29, 35);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(38, 12);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "label1";
            // 
            // DaysPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lvPlans);
            this.Name = "DaysPlan";
            this.Size = new System.Drawing.Size(320, 175);
            this.Load += new System.EventHandler(this.DaysPlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvPlans;
        public System.Windows.Forms.Label lblDay;
    }
}
