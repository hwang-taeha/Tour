namespace TravelPlan
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pboxMain = new System.Windows.Forms.PictureBox();
            this.btnPlan = new System.Windows.Forms.Button();
            this.btnFestival = new System.Windows.Forms.Button();
            this.btnTraffic = new System.Windows.Forms.Button();
            this.traffic1 = new TravelPlan.Traffic();
            this.festival1 = new TravelPlan.Festival();
            this.btnHotel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(213)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.btnHotel);
            this.panel1.Controls.Add(this.btnPlan);
            this.panel1.Controls.Add(this.btnFestival);
            this.panel1.Controls.Add(this.Sidepanel);
            this.panel1.Controls.Add(this.btnTraffic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(884, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 423);
            this.panel1.TabIndex = 1;
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.White;
            this.Sidepanel.Location = new System.Drawing.Point(176, 0);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(10, 80);
            this.Sidepanel.TabIndex = 6;
            this.Sidepanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pboxMain);
            this.panel2.Controls.Add(this.traffic1);
            this.panel2.Controls.Add(this.festival1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 423);
            this.panel2.TabIndex = 2;
            // 
            // pboxMain
            // 
            this.pboxMain.Image = global::TravelPlan.Properties.Resources.main22;
            this.pboxMain.Location = new System.Drawing.Point(0, 0);
            this.pboxMain.Name = "pboxMain";
            this.pboxMain.Size = new System.Drawing.Size(887, 423);
            this.pboxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMain.TabIndex = 0;
            this.pboxMain.TabStop = false;
            // 
            // btnPlan
            // 
            this.btnPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlan.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlan.ForeColor = System.Drawing.Color.White;
            this.btnPlan.Image = global::TravelPlan.Properties.Resources.planner64;
            this.btnPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlan.Location = new System.Drawing.Point(2, 237);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(183, 80);
            this.btnPlan.TabIndex = 8;
            this.btnPlan.Text = "스케줄";
            this.btnPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlan.UseVisualStyleBackColor = true;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // btnFestival
            // 
            this.btnFestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFestival.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnFestival.ForeColor = System.Drawing.Color.White;
            this.btnFestival.Image = ((System.Drawing.Image)(resources.GetObject("btnFestival.Image")));
            this.btnFestival.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFestival.Location = new System.Drawing.Point(3, 77);
            this.btnFestival.Name = "btnFestival";
            this.btnFestival.Size = new System.Drawing.Size(183, 80);
            this.btnFestival.TabIndex = 7;
            this.btnFestival.Text = "축제 정보";
            this.btnFestival.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFestival.UseVisualStyleBackColor = true;
            this.btnFestival.Click += new System.EventHandler(this.btnFestival_Click);
            // 
            // btnTraffic
            // 
            this.btnTraffic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraffic.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnTraffic.ForeColor = System.Drawing.Color.White;
            this.btnTraffic.Image = global::TravelPlan.Properties.Resources.car48;
            this.btnTraffic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraffic.Location = new System.Drawing.Point(3, 0);
            this.btnTraffic.Name = "btnTraffic";
            this.btnTraffic.Size = new System.Drawing.Size(183, 80);
            this.btnTraffic.TabIndex = 5;
            this.btnTraffic.Text = "실시간 교통정보";
            this.btnTraffic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraffic.UseVisualStyleBackColor = true;
            this.btnTraffic.Click += new System.EventHandler(this.btnTraffic_Click_1);
            // 
            // traffic1
            // 
            this.traffic1.BackColor = System.Drawing.Color.White;
            this.traffic1.Location = new System.Drawing.Point(3, 0);
            this.traffic1.Name = "traffic1";
            this.traffic1.Size = new System.Drawing.Size(884, 423);
            this.traffic1.TabIndex = 1;
            // 
            // festival1
            // 
            this.festival1.BackColor = System.Drawing.Color.White;
            this.festival1.Location = new System.Drawing.Point(3, 0);
            this.festival1.Name = "festival1";
            this.festival1.Size = new System.Drawing.Size(884, 423);
            this.festival1.TabIndex = 2;
            // 
            // btnHotel
            // 
            this.btnHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnHotel.ForeColor = System.Drawing.Color.White;
            this.btnHotel.Image = global::TravelPlan.Properties.Resources.home64;
            this.btnHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotel.Location = new System.Drawing.Point(3, 157);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(183, 80);
            this.btnHotel.TabIndex = 9;
            this.btnHotel.Text = "숙소 정보";
            this.btnHotel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHotel.UseVisualStyleBackColor = true;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(1073, 423);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTraffic;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.PictureBox pboxMain;
        internal Traffic traffic1;
        private System.Windows.Forms.Button btnFestival;
        private Festival festival1;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.Button btnHotel;
    }
}
