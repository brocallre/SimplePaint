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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grpShape.SuspendLayout();
            this.grpColor.SuspendLayout();
            this.grpLineWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineWidth)).BeginInit();
            this.pnlCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            //
            // lblAppName
            //
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAppName.Location = new System.Drawing.Point(39, 20);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(477, 99);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Simple Paint";
            //
            // grpShape
            //
            this.grpShape.Controls.Add(this.btnLine);
            this.grpShape.Controls.Add(this.btnRectangle);
            this.grpShape.Controls.Add(this.btnCircle);
            this.grpShape.Location = new System.Drawing.Point(39, 120);
            this.grpShape.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.grpShape.Name = "grpShape";
            this.grpShape.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.grpShape.Size = new System.Drawing.Size(669, 180);
            this.grpShape.TabIndex = 1;
            this.grpShape.TabStop = false;
            this.grpShape.Text = "도형 선택";
            //
            // btnLine
            //
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(26, 40);
            this.btnLine.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(180, 120);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "직선";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            //
            // btnRectangle
            //
            this.btnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangle.Image")));
            this.btnRectangle.Location = new System.Drawing.Point(231, 40);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(180, 120);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "사각형";
            this.btnRectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            //
            // btnCircle
            //
            this.btnCircle.Image = ((System.Drawing.Image)(resources.GetObject("btnCircle.Image")));
            this.btnCircle.Location = new System.Drawing.Point(437, 40);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(180, 120);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "원";
            this.btnCircle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            //
            // grpColor
            //
            this.grpColor.Controls.Add(this.cmbColor);
            this.grpColor.Location = new System.Drawing.Point(733, 120);
            this.grpColor.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.grpColor.Name = "grpColor";
            this.grpColor.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.grpColor.Size = new System.Drawing.Size(309, 180);
            this.grpColor.TabIndex = 2;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "색 선택";
            //
            // cmbColor
            //
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Black 검정",
            "Red 빨강",
            "Blue 파랑",
            "Green 녹색"});
            this.cmbColor.Location = new System.Drawing.Point(26, 70);
            this.cmbColor.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(251, 38);
            this.cmbColor.TabIndex = 0;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            //
            // grpLineWidth
            //
            this.grpLineWidth.Controls.Add(this.trbLineWidth);
            this.grpLineWidth.Location = new System.Drawing.Point(1067, 120);
            this.grpLineWidth.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.grpLineWidth.Name = "grpLineWidth";
            this.grpLineWidth.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.grpLineWidth.Size = new System.Drawing.Size(566, 180);
            this.grpLineWidth.TabIndex = 3;
            this.grpLineWidth.TabStop = false;
            this.grpLineWidth.Text = "선 두께";
            //
            // trbLineWidth
            //
            this.trbLineWidth.Location = new System.Drawing.Point(26, 50);
            this.trbLineWidth.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.trbLineWidth.Minimum = 1;
            this.trbLineWidth.Name = "trbLineWidth";
            this.trbLineWidth.Size = new System.Drawing.Size(514, 114);
            this.trbLineWidth.TabIndex = 0;
            this.trbLineWidth.Value = 2;
            this.trbLineWidth.ValueChanged += new System.EventHandler(this.trbLineWidth_ValueChanged);
            //
            // btnOpenFile
            //
            this.btnOpenFile.BackColor = System.Drawing.Color.LightYellow;
            this.btnOpenFile.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnOpenFile.Location = new System.Drawing.Point(1697, 150);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(206, 120);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "열기";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            //
            // btnSaveFile
            //
            this.btnSaveFile.BackColor = System.Drawing.Color.LightCyan;
            this.btnSaveFile.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSaveFile.Location = new System.Drawing.Point(1929, 150);
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(206, 120);
            this.btnSaveFile.TabIndex = 5;
            this.btnSaveFile.Text = "저장";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            //
            // pnlCanvas : 캔버스를 감싸는 스크롤 패널 (이미지가 클 때 스크롤바 자동 표시)
            //
            this.pnlCanvas.AutoScroll = true;
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Controls.Add(this.picCanvas);
            this.pnlCanvas.Location = new System.Drawing.Point(39, 320);
            this.pnlCanvas.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(2093, 918);
            this.pnlCanvas.TabIndex = 6;
            //
            // picCanvas
            //
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Location = new System.Drawing.Point(0, 0);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(2089, 914);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2173, 1270);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.grpLineWidth);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.grpShape);
            this.Controls.Add(this.lblAppName);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "Form1";
            this.Text = "Simple Paint v1.0";
            this.grpShape.ResumeLayout(false);
            this.grpColor.ResumeLayout(false);
            this.grpLineWidth.ResumeLayout(false);
            this.grpLineWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineWidth)).EndInit();
            this.pnlCanvas.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}
