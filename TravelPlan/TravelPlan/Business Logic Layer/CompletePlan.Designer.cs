namespace TravelPlan.Business_Logic_Layer
{
    partial class CompletePlan
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
            this.lvPlan = new System.Windows.Forms.ListView();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvPlan
            // 
            this.lvPlan.Location = new System.Drawing.Point(69, 67);
            this.lvPlan.Name = "lvPlan";
            this.lvPlan.Size = new System.Drawing.Size(443, 249);
            this.lvPlan.TabIndex = 0;
            this.lvPlan.UseCompatibleStateImageBehavior = false;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(69, 32);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(121, 20);
            this.cbDay.TabIndex = 1;
            // 
            // CompletePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.lvPlan);
            this.Location = new System.Drawing.Point(115, 54);
            this.Name = "CompletePlan";
            this.Size = new System.Drawing.Size(652, 338);
            this.Load += new System.EventHandler(this.CompletePlan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPlan;
        private System.Windows.Forms.ComboBox cbDay;
    }
}
