using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        // 사용할 도형 종류 정의
        private enum ToolType { Line, Rectangle, Circle }

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
