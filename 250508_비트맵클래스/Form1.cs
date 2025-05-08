using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// raw format -> bitmap(용량이 큼), wave(음원)

namespace _250508_비트맵클래스
{
    public partial class Form1 : Form
    {
        private Image oriImage;
        private Bitmap bmp;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            oriImage = pictureBox1.Image.Clone() as Image;
        }

        private Bitmap ImageApply()
        {
            pictureBox1.Image.Dispose();
            pictureBox1.Image = oriImage.Clone() as Image;
            bmp = pictureBox1.Image as Bitmap;

            return bmp;
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            bmp = ImageApply();
            
            // 이미지 가로, 세로 구해서 픽셀마다 하나하나 반복문 통해서 값을 설정해준다
            int width = bmp.Width;
            int height = bmp.Height;

            Color colorData;
            
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    // 해당 위치의 픽셀 색 정보를 colorData에 저장
                    colorData = bmp.GetPixel(i, j);

                    // rgb값 더해서 3으로 나누면 회색 되어버림
                    int res = (colorData.R +  colorData.G + colorData.B) / 3;
                    
                    // 다시 colorData에 저장
                    colorData = Color.FromArgb(res, res, res);
                    bmp.SetPixel(i, j, colorData);
                }
            }
        }
    }
}
