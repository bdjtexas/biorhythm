using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace biorhythm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //I just draw a Sin graphics between 0-2p for example
            float x0 = 50f;
            float y0 = 270f;

            //Assume the graphics width is 200pixels
            //so there's 200 points
            PointF[] points1 = new PointF[500];
            PointF[] points2 = new PointF[425];
            PointF[] points3 = new PointF[349];

            for (int j = 0; j < 500; j++)
            {
                points1[j] = new PointF();
                points1[j].X = x0 + j;
                points1[j].Y = y0 - (float)(250 * Math.Sin((2 * Math.PI * j) / 500));
            }

            for (int i = 0; i < 425; i++)
            {
                points2[i] = new PointF();
                points2[i].X = x0 + i;
                points2[i].Y = y0 - (float)(250 * Math.Sin((2 * Math.PI * i) / 424.25));
            }

            for (int k = 0; k < 349; k++)
            {
                points3[k] = new PointF();
                points3[k].X = x0 + k;
                points3[k].Y = y0 - (float)(250 * Math.Sin((2 * Math.PI * k) / 348.5));
            }

            using (Pen p = new Pen(Color.Black))
            {
                p.EndCap = LineCap.ArrowAnchor;

                //Draw X-coordinate
                e.Graphics.DrawLine(p, x0, y0, x0 + 500, y0);

                //Draw Y-coordinate
                e.Graphics.DrawLine(p, x0, y0 + 250, x0, y0 - 250);
            }

            e.Graphics.DrawString("0", SystemFonts.DefaultFont, Brushes.Blue, x0, y0);
            e.Graphics.DrawString("16.5 days", SystemFonts.DefaultFont, Brushes.Blue, x0 + 250, y0);
            e.Graphics.DrawString("33 Days", SystemFonts.DefaultFont, Brushes.Blue, x0 + 500, y0);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawLines(Pens.Blue, points1);
            e.Graphics.DrawLines(Pens.Green, points2);
            e.Graphics.DrawLines(Pens.Red, points3);
            base.OnPaint(e);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void CloseGraphScreenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
