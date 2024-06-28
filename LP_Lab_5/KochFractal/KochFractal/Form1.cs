using System;
using System.Drawing;
using System.Windows.Forms;

namespace KochFractal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Отримання координат та порядку фракталу з текстових полів
            int x1 = int.Parse(txtX1.Text);
            int y1 = int.Parse(txtY1.Text);
            int x2 = int.Parse(txtX2.Text);
            int y2 = int.Parse(txtY2.Text);
            int x3 = int.Parse(txtX3.Text);
            int y3 = int.Parse(txtY3.Text);
            int order = int.Parse(txtOrder.Text);

            // Створення Bitmap для малювання
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            // Малювання фракталу Коха
            DrawKochFractal(g, order, new PointF(x1, y1), new PointF(x2, y2));
            DrawKochFractal(g, order, new PointF(x2, y2), new PointF(x3, y3));
            DrawKochFractal(g, order, new PointF(x3, y3), new PointF(x1, y1));

            // Відображення результату в PictureBox
            pictureBox.Image = bitmap;
        }

        private void DrawKochFractal(Graphics g, int order, PointF p1, PointF p2)
        {
            if (order == 0)
            {
                g.DrawLine(Pens.Black, p1, p2);
            }
            else
            {
                // Розрахунок нових точок
                float dx = (p2.X - p1.X) / 3;
                float dy = (p2.Y - p1.Y) / 3;

                PointF p3 = new PointF(p1.X + dx, p1.Y + dy);
                PointF p4 = new PointF(p1.X + 2 * dx, p1.Y + 2 * dy);

                float px = (float)(0.5 * (p1.X + p2.X) + Math.Sqrt(3) * (p1.Y - p2.Y) / 6);
                float py = (float)(0.5 * (p1.Y + p2.Y) + Math.Sqrt(3) * (p2.X - p1.X) / 6);

                PointF p5 = new PointF(px, py);

                // Рекурсивне малювання
                DrawKochFractal(g, order - 1, p1, p3);
                DrawKochFractal(g, order - 1, p3, p5);
                DrawKochFractal(g, order - 1, p5, p4);
                DrawKochFractal(g, order - 1, p4, p2);
            }
        }

        private void txtX1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
