namespace TravelPlan
{
    partial class TotalSearch
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbCat1 = new System.Windows.Forms.ComboBox();
            this.cmbCat2 = new System.Windows.Forms.ComboBox();
            this.cmbCat3 = new System.Windows.Forms.ComboBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbSigungu = new System.Windows.Forms.ComboBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblContentType = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.rdoService = new System.Windows.Forms.RadioButton();
            this.rdoArea = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoTotal = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSlush = new System.Windows.Forms.Label();
            this.lblLastPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.txturl = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblNowPage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbCat1
            // 
            this.cmbCat1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbCat1.FormattingEnabled = true;
            this.cmbCat1.Location = new System.Drawing.Point(120, 46);
            this.cmbCat1.Name = "cmbCat1";
            this.cmbCat1.Size = new System.Drawing.Size(121, 23);
            this.cmbCat1.TabIndex = 0;
            this.cmbCat1.Text = "대분류";
            this.cmbCat1.Visible = false;
            this.cmbCat1.SelectionChangeCommitted += new System.EventHandler(this.cmbCat1_SelectedValueChanged);
            // 
            // cmbCat2
            // 
            this.cmbCat2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbCat2.FormattingEnabled = true;
            this.cmbCat2.Location = new System.Drawing.Point(247, 46);
            this.cmbCat2.Name = "cmbCat2";
            this.cmbCat2.Size = new System.Drawing.Size(121, 23);
            this.cmbCat2.TabIndex = 1;
            this.cmbCat2.Text = "중분류";
            this.cmbCat2.Visible = false;
            this.cmbCat2.SelectionChangeCommitted += new System.EventHandler(this.cmbCat2_SelectedIndexChanged);
            // 
            // cmbCat3
            // 
            this.cmbCat3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbCat3.FormattingEnabled = true;
            this.cmbCat3.Location = new System.Drawing.Point(374, 46);
            this.cmbCat3.Name = "cmbCat3";
            this.cmbCat3.Size = new System.Drawing.Size(121, 23);
            this.cmbCat3.TabIndex = 2;
            this.cmbCat3.Text = "소분류";
            this.cmbCat3.Visible = false;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCat.Location = new System.Drawing.Point(49, 49);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(67, 15);
            this.lblCat.TabIndex = 3;
            this.lblCat.Text = "서비스분류";
            this.lblCat.Visible = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblArea.Location = new System.Drawing.Point(85, 49);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(31, 15);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "지역";
            this.lblArea.Visible = false;
            // 
            // cmbSigungu
            // 
            this.cmbSigungu.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbSigungu.FormattingEnabled = true;
            this.cmbSigungu.Location = new System.Drawing.Point(247, 46);
            this.cmbSigungu.Name = "cmbSigungu";
            this.cmbSigungu.Size = new System.Drawing.Size(121, 23);
            this.cmbSigungu.TabIndex = 6;
            this.cmbSigungu.Text = "시군구 선택";
            this.cmbSigungu.Visible = false;
            // 
            // cmbArea
            // 
            this.cmbArea.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(120, 46);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(121, 23);
            this.cmbArea.TabIndex = 5;
            this.cmbArea.Text = "지역 선택";
            this.cmbArea.Visible = false;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedValueChanged);
            // 
            // lblContentType
            // 
            this.lblContentType.AutoSize = true;
            this.lblContentType.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblContentType.Location = new System.Drawing.Point(61, 49);
            this.lblContentType.Name = "lblContentType";
            this.lblContentType.Size = new System.Drawing.Size(55, 15);
            this.lblContentType.TabIndex = 7;
            this.lblContentType.Text = "관광타입";
            this.lblContentType.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearch.Location = new System.Drawing.Point(120, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(248, 23);
            this.txtSearch.TabIndex = 9;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSearch.Location = new System.Drawing.Point(85, 49);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(31, 15);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "검색";
            // 
            // rdoService
            // 
            this.rdoService.AutoSize = true;
            this.rdoService.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoService.Location = new System.Drawing.Point(173, 22);
            this.rdoService.Name = "rdoService";
            this.rdoService.Size = new System.Drawing.Size(85, 19);
            this.rdoService.TabIndex = 11;
            this.rdoService.Text = "서비스분류";
            this.rdoService.UseVisualStyleBackColor = true;
            this.rdoService.CheckedChanged += new System.EventHandler(this.rdoService_CheckedChanged);
            // 
            // rdoArea
            // 
            this.rdoArea.AutoSize = true;
            this.rdoArea.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoArea.Location = new System.Drawing.Point(262, 22);
            this.rdoArea.Name = "rdoArea";
            this.rdoArea.Size = new System.Drawing.Size(49, 19);
            this.rdoArea.TabIndex = 12;
            this.rdoArea.Text = "지역";
            this.rdoArea.UseVisualStyleBackColor = true;
            this.rdoArea.CheckedChanged += new System.EventHandler(this.rdoArea_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(374, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 25);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "분류방법";
            // 
            // rdoTotal
            // 
            this.rdoTotal.AutoSize = true;
            this.rdoTotal.Checked = true;
            this.rdoTotal.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoTotal.Location = new System.Drawing.Point(120, 22);
            this.rdoTotal.Name = "rdoTotal";
            this.rdoTotal.Size = new System.Drawing.Size(49, 19);
            this.rdoTotal.TabIndex = 15;
            this.rdoTotal.TabStop = true;
            this.rdoTotal.Text = "통합";
            this.rdoTotal.UseVisualStyleBackColor = true;
            this.rdoTotal.CheckedChanged += new System.EventHandler(this.rdoTotal_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.Location = new System.Drawing.Point(24, 104);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(991, 287);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(912, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "담기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSlush
            // 
            this.lblSlush.AutoSize = true;
            this.lblSlush.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSlush.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.lblSlush.Location = new System.Drawing.Point(707, 61);
            this.lblSlush.Name = "lblSlush";
            this.lblSlush.Size = new System.Drawing.Size(17, 21);
            this.lblSlush.TabIndex = 20;
            this.lblSlush.Text = "/";
            this.lblSlush.Visible = false;
            // 
            // lblLastPage
            // 
            this.lblLastPage.AutoSize = true;
            this.lblLastPage.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLastPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.lblLastPage.Location = new System.Drawing.Point(730, 62);
            this.lblLastPage.Name = "lblLastPage";
            this.lblLastPage.Size = new System.Drawing.Size(55, 21);
            this.lblLastPage.TabIndex = 21;
            this.lblLastPage.Text = "label4";
            this.lblLastPage.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(791, 55);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 36);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(565, 55);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 36);
            this.btnPrev.TabIndex = 24;
            this.btnPrev.Text = "이전";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Visible = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(555, 18);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(460, 21);
            this.txturl.TabIndex = 25;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 0;
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.toolTip.ForeColor = System.Drawing.Color.White;
            this.toolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_Popup);
            // 
            // lblNowPage
            // 
            this.lblNowPage.BackColor = System.Drawing.SystemColors.Window;
            this.lblNowPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNowPage.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNowPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.lblNowPage.Location = new System.Drawing.Point(646, 62);
            this.lblNowPage.Name = "lblNowPage";
            this.lblNowPage.Size = new System.Drawing.Size(78, 22);
            this.lblNowPage.TabIndex = 26;
            this.lblNowPage.Text = "label2";
            this.lblNowPage.Visible = false;
            this.lblNowPage.Enter += new System.EventHandler(this.lblNowPage_Enter);
            // 
            // TotalSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblLastPage);
            this.Controls.Add(this.lblSlush);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rdoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoArea);
            this.Controls.Add(this.rdoService);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblContentType);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.cmbCat1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbCat3);
            this.Controls.Add(this.cmbCat2);
            this.Controls.Add(this.cmbSigungu);
            this.Controls.Add(this.lblNowPage);
            this.Name = "TotalSearch";
            this.Size = new System.Drawing.Size(1061, 450);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCat1;
        private System.Windows.Forms.ComboBox cmbCat2;
        private System.Windows.Forms.ComboBox cmbCat3;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbSigungu;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblContentType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.RadioButton rdoService;
        private System.Windows.Forms.RadioButton rdoArea;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoTotal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSlush;
        private System.Windows.Forms.Label lblLastPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox lblNowPage;
    }
}
