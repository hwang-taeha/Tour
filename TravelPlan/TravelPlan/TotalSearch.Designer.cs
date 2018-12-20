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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cmbCat1
            // 
            this.cmbCat1.FormattingEnabled = true;
            this.cmbCat1.Location = new System.Drawing.Point(120, 60);
            this.cmbCat1.Name = "cmbCat1";
            this.cmbCat1.Size = new System.Drawing.Size(121, 20);
            this.cmbCat1.TabIndex = 0;
            this.cmbCat1.Text = "대분류";
            this.cmbCat1.Visible = false;
            this.cmbCat1.SelectionChangeCommitted += new System.EventHandler(this.cmbCat1_SelectedValueChanged);
            // 
            // cmbCat2
            // 
            this.cmbCat2.FormattingEnabled = true;
            this.cmbCat2.Location = new System.Drawing.Point(247, 60);
            this.cmbCat2.Name = "cmbCat2";
            this.cmbCat2.Size = new System.Drawing.Size(121, 20);
            this.cmbCat2.TabIndex = 1;
            this.cmbCat2.Text = "중분류";
            this.cmbCat2.Visible = false;
            this.cmbCat2.SelectionChangeCommitted += new System.EventHandler(this.cmbCat2_SelectedIndexChanged);
            // 
            // cmbCat3
            // 
            this.cmbCat3.FormattingEnabled = true;
            this.cmbCat3.Location = new System.Drawing.Point(374, 60);
            this.cmbCat3.Name = "cmbCat3";
            this.cmbCat3.Size = new System.Drawing.Size(121, 20);
            this.cmbCat3.TabIndex = 2;
            this.cmbCat3.Text = "소분류";
            this.cmbCat3.Visible = false;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(49, 63);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(65, 12);
            this.lblCat.TabIndex = 3;
            this.lblCat.Text = "서비스분류";
            this.lblCat.Visible = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(85, 63);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 12);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "지역";
            this.lblArea.Visible = false;
            // 
            // cmbSigungu
            // 
            this.cmbSigungu.FormattingEnabled = true;
            this.cmbSigungu.Location = new System.Drawing.Point(247, 60);
            this.cmbSigungu.Name = "cmbSigungu";
            this.cmbSigungu.Size = new System.Drawing.Size(121, 20);
            this.cmbSigungu.TabIndex = 6;
            this.cmbSigungu.Text = "시군구 선택";
            this.cmbSigungu.Visible = false;
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(120, 60);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(121, 20);
            this.cmbArea.TabIndex = 5;
            this.cmbArea.Text = "지역 선택";
            this.cmbArea.Visible = false;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedValueChanged);
            // 
            // lblContentType
            // 
            this.lblContentType.AutoSize = true;
            this.lblContentType.Location = new System.Drawing.Point(61, 63);
            this.lblContentType.Name = "lblContentType";
            this.lblContentType.Size = new System.Drawing.Size(53, 12);
            this.lblContentType.TabIndex = 7;
            this.lblContentType.Text = "관광타입";
            this.lblContentType.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(120, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(248, 21);
            this.txtSearch.TabIndex = 9;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(85, 63);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(29, 12);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "검색";
            // 
            // rdoService
            // 
            this.rdoService.AutoSize = true;
            this.rdoService.Location = new System.Drawing.Point(173, 36);
            this.rdoService.Name = "rdoService";
            this.rdoService.Size = new System.Drawing.Size(83, 16);
            this.rdoService.TabIndex = 11;
            this.rdoService.Text = "서비스분류";
            this.rdoService.UseVisualStyleBackColor = true;
            this.rdoService.CheckedChanged += new System.EventHandler(this.rdoService_CheckedChanged);
            // 
            // rdoArea
            // 
            this.rdoArea.AutoSize = true;
            this.rdoArea.Location = new System.Drawing.Point(262, 36);
            this.rdoArea.Name = "rdoArea";
            this.rdoArea.Size = new System.Drawing.Size(47, 16);
            this.rdoArea.TabIndex = 12;
            this.rdoArea.Text = "지역";
            this.rdoArea.UseVisualStyleBackColor = true;
            this.rdoArea.CheckedChanged += new System.EventHandler(this.rdoArea_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(374, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "분류방법";
            // 
            // rdoTotal
            // 
            this.rdoTotal.AutoSize = true;
            this.rdoTotal.Checked = true;
            this.rdoTotal.Location = new System.Drawing.Point(120, 36);
            this.rdoTotal.Name = "rdoTotal";
            this.rdoTotal.Size = new System.Drawing.Size(47, 16);
            this.rdoTotal.TabIndex = 15;
            this.rdoTotal.TabStop = true;
            this.rdoTotal.Text = "통합";
            this.rdoTotal.UseVisualStyleBackColor = true;
            this.rdoTotal.CheckedChanged += new System.EventHandler(this.rdoTotal_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 21);
            this.textBox1.TabIndex = 16;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(120, 160);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(375, 240);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // TotalSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoArea);
            this.Controls.Add(this.rdoService);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblContentType);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbCat2);
            this.Controls.Add(this.cmbSigungu);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.cmbCat1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbCat3);
            this.Name = "TotalSearch";
            this.Size = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
    }
}
