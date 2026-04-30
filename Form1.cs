using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        // 사용할 도형 종류 정의
        private enum ToolType { Line, Rectangle, Circle }

        // 실제 그림이 저장되는 비트맵 (캔버스)
        private Bitmap canvasBitmap;

        // 비트맵 위에 그리기 위한 그래픽스 객체
        private Graphics canvasGraphics;

        // 현재 마우스 드래그 중인지 여부
        private bool isDrawing = false;

        // 드래그 시작점
        private Point startPoint;

        // 드래그 끝점 (현재 마우스 위치)
        private Point endPoint;

        // 현재 선택된 도형 (기본값: 직선)
        private ToolType currentTool = ToolType.Line;

        // 현재 선택된 색상 (기본값: 검정)
        private Color currentColor = Color.Black;

        // 현재 설정된 선 두께 (기본값: 2)
        private int currentLineWidth = 2;

        public Form1()
        {
            InitializeComponent();

            // 도형 선택 버튼에 아이콘 이미지 로드
            LoadShapeButtonImages();

            // 캔버스(비트맵) 초기화: PictureBox 크기와 동일하게 생성
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            // 캔버스 배경을 흰색으로 채움
            canvasGraphics.Clear(Color.White);
            // 그린 결과를 PictureBox에 표시
            picCanvas.Image = canvasBitmap;

            // 마우스 이벤트 연결
            picCanvas.MouseDown += PicCanvas_MouseDown;
            picCanvas.MouseMove += PicCanvas_MouseMove;
            picCanvas.MouseUp += PicCanvas_MouseUp;

            // PictureBox가 다시 그려질 때 미리보기 도형을 그릴 수 있도록 Paint 이벤트 연결
            picCanvas.Paint += PicCanvas_Paint;

            // 콤보 박스 기본 선택 항목을 검정으로 설정
            cmbColor.SelectedIndex = 0;
        }

        // 도형 선택 버튼에 표시할 아이콘 이미지를 img 폴더에서 읽어들이는 함수
        private void LoadShapeButtonImages()
        {
            // 실행 파일 위치 기준으로 img 폴더 경로 계산
            string imgDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img");
            string linePath = Path.Combine(imgDir, "line.png");
            string squarePath = Path.Combine(imgDir, "square.png");
            string circlePath = Path.Combine(imgDir, "circle.png");

            // 파일이 존재하면 버튼에 이미지를 설정
            if (File.Exists(linePath))
                btnLine.Image = Image.FromFile(linePath);
            if (File.Exists(squarePath))
                btnRectangle.Image = Image.FromFile(squarePath);
            if (File.Exists(circlePath))
                btnCircle.Image = Image.FromFile(circlePath);
        }

        // 마우스 버튼이 눌릴 때: 드래그 시작점을 기록하고 그리기 모드로 진입
        private void PicCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
            endPoint = e.Location;
        }

        // 마우스를 누른 채 이동할 때: 끝점을 갱신하고 미리보기를 위해 화면을 다시 그리도록 요청
        private void PicCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            endPoint = e.Location;
            // Paint 이벤트를 발생시켜 점선 미리보기를 화면에 표시
            picCanvas.Invalidate();
        }

        // 마우스 버튼에서 손을 뗄 때: 비트맵에 도형을 확정해서 그리고 화면을 갱신
        private void PicCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            isDrawing = false;
            endPoint = e.Location;

            // 현재 색상과 선 두께로 펜을 만들어 비트맵에 도형을 그림
            using (Pen pen = new Pen(currentColor, currentLineWidth))
            {
                DrawShape(canvasGraphics, pen, startPoint, endPoint);
            }

            // 변경된 비트맵을 화면에 반영
            picCanvas.Invalidate();
        }

        // PictureBox가 다시 그려질 때 호출되는 핸들러: 드래그 중에는 점선으로 미리보기를 그림
        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!isDrawing) return;

            // 미리보기용 점선 펜 생성
            using (Pen previewPen = new Pen(currentColor, currentLineWidth))
            {
                previewPen.DashStyle = DashStyle.Dash;
                DrawShape(e.Graphics, previewPen, startPoint, endPoint);
            }
        }

        // 현재 선택된 도형 종류에 따라 직선, 사각형, 원 중 하나를 그리는 함수
        private void DrawShape(Graphics g, Pen pen, Point p1, Point p2)
        {
            Rectangle rect = GetRectangle(p1, p2);
            switch (currentTool)
            {
                case ToolType.Line:
                    g.DrawLine(pen, p1, p2);
                    break;
                case ToolType.Rectangle:
                    g.DrawRectangle(pen, rect);
                    break;
                case ToolType.Circle:
                    g.DrawEllipse(pen, rect);
                    break;
            }
        }

        // 두 점의 좌표로부터 사각형(좌상단 좌표, 폭, 높이)을 생성하는 함수
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y)
            );
        }

        // 직선 그리기 버튼 클릭 시 호출되는 이벤트 핸들러
        private void btnLine_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Line;
        }

        // 사각형 그리기 버튼 클릭 시 호출되는 이벤트 핸들러
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Rectangle;
        }

        // 원 그리기 버튼 클릭 시 호출되는 이벤트 핸들러
        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Circle;
        }

        // 색상 콤보 박스의 선택이 바뀌면 호출되는 이벤트 핸들러
        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColor.SelectedIndex)
            {
                case 0: // Black 검정
                    currentColor = Color.Black;
                    break;
                case 1: // Red 빨강
                    currentColor = Color.Red;
                    break;
                case 2: // Blue 파랑
                    currentColor = Color.Blue;
                    break;
                case 3: // Green 녹색
                    currentColor = Color.Green;
                    break;
                default:
                    currentColor = Color.Black;
                    break;
            }
        }

        // 트랙바 값이 바뀌면 선 두께를 갱신하는 이벤트 핸들러
        private void trbLineWidth_ValueChanged(object sender, EventArgs e)
        {
            currentLineWidth = trbLineWidth.Value;
        }
    }
}
