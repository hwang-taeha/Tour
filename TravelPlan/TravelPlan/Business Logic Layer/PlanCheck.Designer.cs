namespace TravelPlan
{
    partial class PlanCheck
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
            this.cbTotalDays = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCurrentJJim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTotalDays
            // 
            this.cbTotalDays.FormattingEnabled = true;
            this.cbTotalDays.Location = new System.Drawing.Point(19, 25);
            this.cbTotalDays.Name = "cbTotalDays";
            this.cbTotalDays.Size = new System.Drawing.Size(52, 20);
            this.cbTotalDays.TabIndex = 0;
            this.cbTotalDays.SelectedIndexChanged += new System.EventHandler(this.cbTotalDays_SelectedIndexChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(77, 28);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(29, 12);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "일차";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(19, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(288, 237);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(19, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(313, 51);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(336, 237);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(318, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(399, 294);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "더 찾기";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCurrentJJim
            // 
            this.btnCurrentJJim.Location = new System.Drawing.Point(271, 23);
            this.btnCurrentJJim.Name = "btnCurrentJJim";
            this.btnCurrentJJim.Size = new System.Drawing.Size(75, 23);
            this.btnCurrentJJim.TabIndex = 7;
            this.btnCurrentJJim.Text = "목록최신화";
            this.btnCurrentJJim.UseVisualStyleBackColor = true;
            this.btnCurrentJJim.Click += new System.EventHandler(this.btnCurrentJJim_Click);
            // 
            // PlanCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCurrentJJim);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.cbTotalDays);
            this.Name = "PlanCheck";
            this.Size = new System.Drawing.Size(652, 338);
            this.Load += new System.EventHandler(this.PlanCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.ComboBox cbTotalDays;
        private System.Windows.Forms.Button btnCurrentJJim;
    }
}
