namespace SimplePaint
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            this.lblAppName = new System.Windows.Forms.Label();
            this.grpShape = new System.Windows.Forms.GroupBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.grpLineWidth = new System.Windows.Forms.GroupBox();
            this.trbLineWidth = new System.Windows.Forms.TrackBar();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grpShape.SuspendLayout();
            this.grpColor.SuspendLayout();
            this.grpLineWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            //
            // lblAppName : 앱 이름을 표시하는 라벨
            //
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAppName.Location = new System.Drawing.Point(15, 10);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(206, 41);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Simple Paint";
            //
            // grpShape : 도형 선택용 그룹 박스
            //
            this.grpShape.Controls.Add(this.btnLine);
            this.grpShape.Controls.Add(this.btnRectangle);
            this.grpShape.Controls.Add(this.btnCircle);
            this.grpShape.Location = new System.Drawing.Point(15, 60);
            this.grpShape.Name = "grpShape";
            this.grpShape.Size = new System.Drawing.Size(260, 90);
            this.grpShape.TabIndex = 1;
            this.grpShape.TabStop = false;
            this.grpShape.Text = "도형 선택";
            //
            // btnLine : 직선 그리기 버튼
            //
            this.btnLine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLine.Location = new System.Drawing.Point(10, 20);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(70, 60);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "직선";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            //
            // btnRectangle : 사각형 그리기 버튼
            //
            this.btnRectangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRectangle.Location = new System.Drawing.Point(90, 20);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(70, 60);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "사각형";
            this.btnRectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            //
            // btnCircle : 원 그리기 버튼
            //
            this.btnCircle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCircle.Location = new System.Drawing.Point(170, 20);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(70, 60);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "원";
            this.btnCircle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            //
            // grpColor : 색 선택용 그룹 박스
            //
            this.grpColor.Controls.Add(this.cmbColor);
            this.grpColor.Location = new System.Drawing.Point(285, 60);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(120, 90);
            this.grpColor.TabIndex = 2;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "색 선택";
            //
            // cmbColor : 색상 선택 콤보 박스
            //
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Black 검정",
            "Red 빨강",
            "Blue 파랑",
            "Green 녹색"});
            this.cmbColor.Location = new System.Drawing.Point(10, 35);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(100, 23);
            this.cmbColor.TabIndex = 0;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            //
            // grpLineWidth : 선 두께 조정용 그룹 박스
            //
            this.grpLineWidth.Controls.Add(this.trbLineWidth);
            this.grpLineWidth.Location = new System.Drawing.Point(415, 60);
            this.grpLineWidth.Name = "grpLineWidth";
            this.grpLineWidth.Size = new System.Drawing.Size(220, 90);
            this.grpLineWidth.TabIndex = 3;
            this.grpLineWidth.TabStop = false;
            this.grpLineWidth.Text = "선 두께";
            //
            // trbLineWidth : 선 두께 조정 트랙바
            //
            this.trbLineWidth.Location = new System.Drawing.Point(10, 25);
            this.trbLineWidth.Maximum = 10;
            this.trbLineWidth.Minimum = 1;
            this.trbLineWidth.Name = "trbLineWidth";
            this.trbLineWidth.Size = new System.Drawing.Size(200, 45);
            this.trbLineWidth.TabIndex = 0;
            this.trbLineWidth.Value = 2;
            this.trbLineWidth.ValueChanged += new System.EventHandler(this.trbLineWidth_ValueChanged);
            //
            // btnOpenFile : 이미지 파일 열기 버튼
            //
            this.btnOpenFile.BackColor = System.Drawing.Color.LightYellow;
            this.btnOpenFile.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnOpenFile.Location = new System.Drawing.Point(660, 75);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(80, 60);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "열기";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            //
            // btnSaveFile : 이미지 파일 저장 버튼
            //
            this.btnSaveFile.BackColor = System.Drawing.Color.LightCyan;
            this.btnSaveFile.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSaveFile.Location = new System.Drawing.Point(750, 75);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(80, 60);
            this.btnSaveFile.TabIndex = 5;
            this.btnSaveFile.Text = "저장";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            //
            // picCanvas : 그림이 그려지는 캔버스 영역
            //
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Location = new System.Drawing.Point(15, 160);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(815, 460);
            this.picCanvas.TabIndex = 6;
            this.picCanvas.TabStop = false;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 635);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.grpLineWidth);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.grpShape);
            this.Controls.Add(this.lblAppName);
            this.Name = "Form1";
            this.Text = "Simple Paint v1.0";
            this.grpShape.ResumeLayout(false);
            this.grpColor.ResumeLayout(false);
            this.grpLineWidth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trbLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.GroupBox grpShape;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.GroupBox grpLineWidth;
        private System.Windows.Forms.TrackBar trbLineWidth;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}
