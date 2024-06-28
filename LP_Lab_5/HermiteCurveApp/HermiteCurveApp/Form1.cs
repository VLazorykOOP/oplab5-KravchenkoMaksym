using System;
using System.Drawing;
using System.Windows.Forms;

namespace HermiteCurveApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Зчитування координат та векторів з текстових полів
            float x1 = float.Parse(txtX1.Text);
            float y1 = float.Parse(txtY1.Text);
            float x2 = float.Parse(txtX2.Text);
            float y2 = float.Parse(txtY2.Text);
            float vx1 = float.Parse(txtVx1.Text);
            float vy1 = float.Parse(txtVy1.Text);
            float vx2 = float.Parse(txtVx2.Text);
            float vy2 = float.Parse(txtVy2.Text);

            PointF p1 = new PointF(x1, y1);
            PointF p2 = new PointF(x2, y2);
            PointF v1 = new PointF(vx1, vy1);
            PointF v2 = new PointF(vx2, vy2);

            // Виклик методу для малювання лінії Ерміта
            DrawHermiteCurve(p1, p2, v1, v2);
        }

        private void DrawHermiteCurve(PointF p1, PointF p2, PointF v1, PointF v2)
        {
            Bitmap bitmap = new Bitmap(pnlDraw.Width, pnlDraw.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            // Задання кольору та товщини лінії
            Pen pen = new Pen(Color.Blue, 2);

            // Обчислення та малювання лінії Ерміта
            PointF[] curvePoints = new PointF[100];
            for (int i = 0; i < 100; i++)
            {
                float t = i / 99f;
                curvePoints[i] = Hermite(t, p1, p2, v1, v2);
            }
            g.DrawCurve(pen, curvePoints);

            // Відображення результату на панелі
            pnlDraw.BackgroundImage = bitmap;
        }

        private PointF Hermite(float t, PointF p1, PointF p2, PointF v1, PointF v2)
        {
            float h1 = 2 * t * t * t - 3 * t * t + 1;
            float h2 = -2 * t * t * t + 3 * t * t;
            float h3 = t * t * t - 2 * t * t + t;
            float h4 = t * t * t - t * t;

            float x = h1 * p1.X + h2 * p2.X + h3 * v1.X + h4 * v2.X;
            float y = h1 * p1.Y + h2 * p2.Y + h3 * v1.Y + h4 * v2.Y;

            return new PointF(x, y);
        }
    }
}
