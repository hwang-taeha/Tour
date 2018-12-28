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
            this.btnFoundRoute = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lvSearchResult = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnStartSet = new System.Windows.Forms.Button();
            this.btnEndSet = new System.Windows.Forms.Button();
            this.btnEndSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvDibList = new System.Windows.Forms.ListView();
            this.btnEndDib = new System.Windows.Forms.Button();
            this.btnStartDib = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultText = new System.Windows.Forms.Label();
            this.routeInfo1 = new TravelPlan.RouteInfo();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxStart
            // 
            this.tboxStart.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxStart.Location = new System.Drawing.Point(4, 43);
            this.tboxStart.Name = "tboxStart";
            this.tboxStart.Size = new System.Drawing.Size(188, 23);
            this.tboxStart.TabIndex = 0;
            this.tboxStart.Text = "출발지를 입력하세요";
            this.tboxStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxStart.Click += new System.EventHandler(this.tboxStart_Click);
            // 
            // tboxEnd
            // 
            this.tboxEnd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxEnd.Location = new System.Drawing.Point(4, 95);
            this.tboxEnd.Name = "tboxEnd";
            this.tboxEnd.Size = new System.Drawing.Size(188, 23);
            this.tboxEnd.TabIndex = 1;
            this.tboxEnd.Text = "도착지를 입력하세요";
            this.tboxEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxEnd.Click += new System.EventHandler(this.tboxEnd_Click);
            // 
            // btnFoundRoute
            // 
            this.btnFoundRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.btnFoundRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoundRoute.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFoundRoute.ForeColor = System.Drawing.Color.White;
            this.btnFoundRoute.Location = new System.Drawing.Point(258, 27);
            this.btnFoundRoute.Name = "btnFoundRoute";
            this.btnFoundRoute.Size = new System.Drawing.Size(54, 102);
            this.btnFoundRoute.TabIndex = 2;
            this.btnFoundRoute.Text = "길찾기";
            this.btnFoundRoute.UseVisualStyleBackColor = false;
            this.btnFoundRoute.Click += new System.EventHandler(this.btnFoundRoute_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.routeInfo1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(318, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(755, 396);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // lvSearchResult
            // 
            this.lvSearchResult.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvSearchResult.Location = new System.Drawing.Point(4, 147);
            this.lvSearchResult.Name = "lvSearchResult";
            this.lvSearchResult.Size = new System.Drawing.Size(248, 121);
            this.lvSearchResult.TabIndex = 5;
            this.lvSearchResult.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(198, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 48);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "출발지검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnStartSet
            // 
            this.btnStartSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.btnStartSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSet.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStartSet.ForeColor = System.Drawing.Color.White;
            this.btnStartSet.Location = new System.Drawing.Point(258, 147);
            this.btnStartSet.Name = "btnStartSet";
            this.btnStartSet.Size = new System.Drawing.Size(54, 42);
            this.btnStartSet.TabIndex = 6;
            this.btnStartSet.Text = "출발지 설정";
            this.btnStartSet.UseVisualStyleBackColor = false;
            this.btnStartSet.Click += new System.EventHandler(this.btnStartSet_Click);
            // 
            // btnEndSet
            // 
            this.btnEndSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.btnEndSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndSet.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEndSet.ForeColor = System.Drawing.Color.White;
            this.btnEndSet.Location = new System.Drawing.Point(258, 195);
            this.btnEndSet.Name = "btnEndSet";
            this.btnEndSet.Size = new System.Drawing.Size(54, 42);
            this.btnEndSet.TabIndex = 7;
            this.btnEndSet.Text = "도착지 설정";
            this.btnEndSet.UseVisualStyleBackColor = false;
            this.btnEndSet.Click += new System.EventHandler(this.btnEndSet_Click);
            // 
            // btnEndSearch
            // 
            this.btnEndSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.btnEndSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEndSearch.ForeColor = System.Drawing.Color.White;
            this.btnEndSearch.Location = new System.Drawing.Point(198, 81);
            this.btnEndSearch.Name = "btnEndSearch";
            this.btnEndSearch.Size = new System.Drawing.Size(54, 48);
            this.btnEndSearch.TabIndex = 8;
            this.btnEndSearch.Text = "도착지검색";
            this.btnEndSearch.UseVisualStyleBackColor = false;
            this.btnEndSearch.Click += new System.EventHandler(this.btnEndSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(4, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "검색결과";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(4, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "찜목록";
            // 
            // lvDibList
            // 
            this.lvDibList.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvDibList.Location = new System.Drawing.Point(4, 297);
            this.lvDibList.Name = "lvDibList";
            this.lvDibList.Size = new System.Drawing.Size(248, 121);
            this.lvDibList.TabIndex = 10;
            this.lvDibList.UseCompatibleStateImageBehavior = false;
            // 
            // btnEndDib
            // 
            this.btnEndDib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.btnEndDib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndDib.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEndDib.ForeColor = System.Drawing.Color.White;
            this.btnEndDib.Location = new System.Drawing.Point(258, 376);
            this.btnEndDib.Name = "btnEndDib";
            this.btnEndDib.Size = new System.Drawing.Size(54, 42);
            this.btnEndDib.TabIndex = 13;
            this.btnEndDib.Text = "도착지 설정";
            this.btnEndDib.UseVisualStyleBackColor = false;
            this.btnEndDib.Click += new System.EventHandler(this.btnEndDib_Click);
            // 
            // btnStartDib
            // 
            this.btnStartDib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.btnStartDib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartDib.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStartDib.ForeColor = System.Drawing.Color.White;
            this.btnStartDib.Location = new System.Drawing.Point(258, 328);
            this.btnStartDib.Name = "btnStartDib";
            this.btnStartDib.Size = new System.Drawing.Size(54, 42);
            this.btnStartDib.TabIndex = 12;
            this.btnStartDib.Text = "출발지 설정";
            this.btnStartDib.UseVisualStyleBackColor = false;
            this.btnStartDib.Click += new System.EventHandler(this.btnStartDib_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(258, 281);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(54, 42);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "찜목록 초기화";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "대중교통 길찾기";
            // 
            // lblResultText
            // 
            this.lblResultText.AutoSize = true;
            this.lblResultText.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResultText.Location = new System.Drawing.Point(384, 3);
            this.lblResultText.Name = "lblResultText";
            this.lblResultText.Size = new System.Drawing.Size(0, 21);
            this.lblResultText.TabIndex = 15;
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
            this.Controls.Add(this.lblResultText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEndDib);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnStartDib);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvDibList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEndSearch);
            this.Controls.Add(this.btnEndSet);
            this.Controls.Add(this.btnStartSet);
            this.Controls.Add(this.lvSearchResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnFoundRoute);
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
        private System.Windows.Forms.Button btnFoundRoute;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RouteInfo routeInfo1;
        private System.Windows.Forms.ListView lvSearchResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnStartSet;
        private System.Windows.Forms.Button btnEndSet;
        private System.Windows.Forms.Button btnEndSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvDibList;
        private System.Windows.Forms.Button btnEndDib;
        private System.Windows.Forms.Button btnStartDib;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultText;
    }
}
