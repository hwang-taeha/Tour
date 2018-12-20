namespace TravelPlan.Business_Logic_Layer
{
    partial class Planning
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
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.completePlan = new TravelPlan.Business_Logic_Layer.CompletePlan();
            this.planDateControl1 = new TravelPlan.PlanDateControl();
            this.planCheck = new TravelPlan.PlanCheck();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(747, 369);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(907, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 423);
            this.panel1.TabIndex = 3;
            // 
            // completePlan
            // 
            this.completePlan.Location = new System.Drawing.Point(115, 31);
            this.completePlan.Name = "completePlan";
            this.completePlan.Size = new System.Drawing.Size(652, 338);
            this.completePlan.TabIndex = 4;
            // 
            // planDateControl1
            // 
            this.planDateControl1.Location = new System.Drawing.Point(126, 31);
            this.planDateControl1.Name = "planDateControl1";
            this.planDateControl1.Size = new System.Drawing.Size(652, 338);
            this.planDateControl1.TabIndex = 1;
            // 
            // planCheck
            // 
            this.planCheck.Location = new System.Drawing.Point(115, 31);
            this.planCheck.Name = "planCheck";
            this.planCheck.Size = new System.Drawing.Size(652, 338);
            this.planCheck.TabIndex = 0;
            this.planCheck.Load += new System.EventHandler(this.planCheck_Load);
            // 
            // Planning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.completePlan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.planDateControl1);
            this.Controls.Add(this.planCheck);
            this.Name = "Planning";
            this.Size = new System.Drawing.Size(1073, 423);
            this.ResumeLayout(false);

        }

        #endregion

        private PlanCheck planCheck;
        private PlanDateControl planDateControl1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private CompletePlan completePlan;
    }
}
