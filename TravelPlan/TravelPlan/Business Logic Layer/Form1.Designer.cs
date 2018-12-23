namespace TravelPlan
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnPlan = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.planning = new TravelPlan.Business_Logic_Layer.Planning();
            this.main1 = new TravelPlan.Main();
            this.totalSearch1 = new TravelPlan.TotalSearch();
            this.foundRoute1 = new TravelPlan.FoundRoute();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.btnMap);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.bottomPanel);
            this.panel1.Controls.Add(this.btnPlan);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 111);
            this.panel1.TabIndex = 0;
            // 
            // btnMap
            // 
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(214)))), ((int)(((byte)(181)))));
            this.btnMap.Image = global::TravelPlan.Properties.Resources.map64;
            this.btnMap.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMap.Location = new System.Drawing.Point(990, 24);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(80, 80);
            this.btnMap.TabIndex = 4;
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.Location = new System.Drawing.Point(989, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 21);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnMini
            // 
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMini.Location = new System.Drawing.Point(1018, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(23, 21);
            this.btnMini.TabIndex = 6;
            this.btnMini.Text = "_";
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.Location = new System.Drawing.Point(1047, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 21);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(214)))), ((int)(((byte)(181)))));
            this.btnSearch.Image = global::TravelPlan.Properties.Resources.search64;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.Location = new System.Drawing.Point(818, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 80);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.White;
            this.bottomPanel.Location = new System.Drawing.Point(740, 102);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(63, 10);
            this.bottomPanel.TabIndex = 1;
            // 
            // btnPlan
            // 
            this.btnPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(214)))), ((int)(((byte)(181)))));
            this.btnPlan.Image = global::TravelPlan.Properties.Resources.planner64;
            this.btnPlan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlan.Location = new System.Drawing.Point(904, 24);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(80, 80);
            this.btnPlan.TabIndex = 3;
            this.btnPlan.UseVisualStyleBackColor = true;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(214)))), ((int)(((byte)(181)))));
            this.btnHome.Image = global::TravelPlan.Properties.Resources.home64;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.Location = new System.Drawing.Point(732, 24);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 80);
            this.btnHome.TabIndex = 2;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelPlan.Properties.Resources._3668834_128;
            this.pictureBox1.Location = new System.Drawing.Point(37, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.foundRoute1);
            this.panel3.Controls.Add(this.planning);
            this.panel3.Controls.Add(this.main1);
            this.panel3.Controls.Add(this.totalSearch1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1073, 423);
            this.panel3.TabIndex = 1;
            // 
            // planning
            // 
            this.planning.Location = new System.Drawing.Point(0, 0);
            this.planning.Name = "planning";
            this.planning.Size = new System.Drawing.Size(1073, 423);
            this.planning.TabIndex = 2;
            this.planning.Load += new System.EventHandler(this.planning_Load);
            // 
            // main1
            // 
            this.main1.BackColor = System.Drawing.Color.White;
            this.main1.Location = new System.Drawing.Point(0, 0);
            this.main1.Name = "main1";
            this.main1.Size = new System.Drawing.Size(1073, 423);
            this.main1.TabIndex = 1;
            // 
            // totalSearch1
            // 
            this.totalSearch1.BackColor = System.Drawing.Color.White;
            this.totalSearch1.Location = new System.Drawing.Point(0, 0);
            this.totalSearch1.Name = "totalSearch1";
            this.totalSearch1.Size = new System.Drawing.Size(1073, 423);
            this.totalSearch1.TabIndex = 0;
            // 
            // foundRoute1
            // 
            this.foundRoute1.BackColor = System.Drawing.Color.White;
            this.foundRoute1.Location = new System.Drawing.Point(-1, 1);
            this.foundRoute1.Name = "foundRoute1";
            this.foundRoute1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.foundRoute1.Size = new System.Drawing.Size(1073, 423);
            this.foundRoute1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 533);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private TotalSearch totalSearch1;
        private Main main1;
        private System.Windows.Forms.Button btnMap;
        private Business_Logic_Layer.Planning planning;
        private FoundRoute foundRoute1;
    }
}

