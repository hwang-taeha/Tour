namespace TravelPlan
{
    partial class FoundRoute
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
            this.tboxStart = new System.Windows.Forms.TextBox();
            this.tboxEnd = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.routeInfo1 = new TravelPlan.RouteInfo();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxStart
            // 
            this.tboxStart.Location = new System.Drawing.Point(40, 19);
            this.tboxStart.Name = "tboxStart";
            this.tboxStart.Size = new System.Drawing.Size(188, 21);
            this.tboxStart.TabIndex = 0;
            this.tboxStart.Text = "출발지를 입력하세요";
            this.tboxStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxEnd
            // 
            this.tboxEnd.Location = new System.Drawing.Point(40, 57);
            this.tboxEnd.Name = "tboxEnd";
            this.tboxEnd.Size = new System.Drawing.Size(188, 21);
            this.tboxEnd.TabIndex = 1;
            this.tboxEnd.Text = "도착지를 입력하세요";
            this.tboxEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(234, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 59);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "길찾기";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 125);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 138);
            this.textBox3.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.routeInfo1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(318, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(755, 423);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // routeInfo1
            // 
            this.routeInfo1.Enabled = false;
            this.routeInfo1.Location = new System.Drawing.Point(42, 3);
            this.routeInfo1.Name = "routeInfo1";
            this.routeInfo1.Size = new System.Drawing.Size(710, 117);
            this.routeInfo1.TabIndex = 0;
            this.routeInfo1.Visible = false;
            // 
            // FoundRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tboxEnd);
            this.Controls.Add(this.tboxStart);
            this.Name = "FoundRoute";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1073, 423);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxStart;
        private System.Windows.Forms.TextBox tboxEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RouteInfo routeInfo1;
    }
}
