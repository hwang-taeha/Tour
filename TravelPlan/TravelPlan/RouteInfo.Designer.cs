namespace TravelPlan
{
    partial class RouteInfo
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
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblStartStation = new System.Windows.Forms.Label();
            this.lblBusStationCount = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblSubStationCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEndStation = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
=======
>>>>>>> wonuk
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
<<<<<<< HEAD
            this.lblCount.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCount.Location = new System.Drawing.Point(23, 12);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(50, 25);
=======
            this.lblCount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCount.Location = new System.Drawing.Point(23, 12);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(42, 21);
>>>>>>> wonuk
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "경로";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
<<<<<<< HEAD
            this.lblTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(114, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(31, 15);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "시간";
=======
            this.lblTime.Location = new System.Drawing.Point(83, 23);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(71, 12);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "총+도보시간";
>>>>>>> wonuk
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
<<<<<<< HEAD
            this.lblPayment.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPayment.ForeColor = System.Drawing.Color.Red;
            this.lblPayment.Location = new System.Drawing.Point(182, 19);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(31, 15);
=======
            this.lblPayment.Location = new System.Drawing.Point(199, 23);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(29, 12);
>>>>>>> wonuk
            this.lblPayment.TabIndex = 2;
            this.lblPayment.Text = "요금";
            // 
            // lblStartStation
            // 
            this.lblStartStation.AutoSize = true;
<<<<<<< HEAD
            this.lblStartStation.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStartStation.ForeColor = System.Drawing.Color.Blue;
            this.lblStartStation.Location = new System.Drawing.Point(25, 39);
            this.lblStartStation.Name = "lblStartStation";
            this.lblStartStation.Size = new System.Drawing.Size(67, 15);
=======
            this.lblStartStation.Location = new System.Drawing.Point(23, 51);
            this.lblStartStation.Name = "lblStartStation";
            this.lblStartStation.Size = new System.Drawing.Size(65, 12);
>>>>>>> wonuk
            this.lblStartStation.TabIndex = 3;
            this.lblStartStation.Text = "처음승차역";
            // 
            // lblBusStationCount
            // 
            this.lblBusStationCount.AutoSize = true;
<<<<<<< HEAD
            this.lblBusStationCount.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBusStationCount.Location = new System.Drawing.Point(25, 80);
            this.lblBusStationCount.Name = "lblBusStationCount";
            this.lblBusStationCount.Size = new System.Drawing.Size(59, 15);
=======
            this.lblBusStationCount.Location = new System.Drawing.Point(25, 80);
            this.lblBusStationCount.Name = "lblBusStationCount";
            this.lblBusStationCount.Size = new System.Drawing.Size(57, 12);
>>>>>>> wonuk
            this.lblBusStationCount.TabIndex = 4;
            this.lblBusStationCount.Text = "버정 개수";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
<<<<<<< HEAD
            this.lblDistance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDistance.Location = new System.Drawing.Point(280, 80);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(47, 15);
=======
            this.lblDistance.Location = new System.Drawing.Point(280, 80);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(45, 12);
>>>>>>> wonuk
            this.lblDistance.TabIndex = 5;
            this.lblDistance.Text = "총 길이";
            // 
            // lblSubStationCount
            // 
            this.lblSubStationCount.AutoSize = true;
<<<<<<< HEAD
            this.lblSubStationCount.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSubStationCount.Location = new System.Drawing.Point(147, 80);
            this.lblSubStationCount.Name = "lblSubStationCount";
            this.lblSubStationCount.Size = new System.Drawing.Size(83, 15);
=======
            this.lblSubStationCount.Location = new System.Drawing.Point(147, 80);
            this.lblSubStationCount.Name = "lblSubStationCount";
            this.lblSubStationCount.Size = new System.Drawing.Size(81, 12);
>>>>>>> wonuk
            this.lblSubStationCount.TabIndex = 6;
            this.lblSubStationCount.Text = "지하철역 개수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(671, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "------------------------------";
            // 
            // lblEndStation
            // 
            this.lblEndStation.AutoSize = true;
<<<<<<< HEAD
            this.lblEndStation.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEndStation.ForeColor = System.Drawing.Color.Blue;
            this.lblEndStation.Location = new System.Drawing.Point(25, 61);
            this.lblEndStation.Name = "lblEndStation";
            this.lblEndStation.Size = new System.Drawing.Size(79, 15);
            this.lblEndStation.TabIndex = 9;
            this.lblEndStation.Text = "마지막하차역";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(98, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "약";
            // 
=======
            this.lblEndStation.Location = new System.Drawing.Point(147, 51);
            this.lblEndStation.Name = "lblEndStation";
            this.lblEndStation.Size = new System.Drawing.Size(77, 12);
            this.lblEndStation.TabIndex = 9;
            this.lblEndStation.Text = "마지막하차역";
            // 
>>>>>>> wonuk
            // RouteInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.Controls.Add(this.label1);
=======
>>>>>>> wonuk
            this.Controls.Add(this.lblEndStation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubStationCount);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblBusStationCount);
            this.Controls.Add(this.lblStartStation);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCount);
            this.Name = "RouteInfo";
<<<<<<< HEAD
            this.Size = new System.Drawing.Size(710, 101);
=======
            this.Size = new System.Drawing.Size(710, 117);
>>>>>>> wonuk
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label lblCount;
        internal System.Windows.Forms.Label lblTime;
        internal System.Windows.Forms.Label lblPayment;
        internal System.Windows.Forms.Label lblStartStation;
        internal System.Windows.Forms.Label lblBusStationCount;
        internal System.Windows.Forms.Label lblDistance;
        internal System.Windows.Forms.Label lblSubStationCount;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblEndStation;
<<<<<<< HEAD
        internal System.Windows.Forms.Label label1;
=======
>>>>>>> wonuk
    }
}
