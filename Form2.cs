using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_animation
{
    public partial class Form2 : Form
    {
        Bitmap bitmap,draft;

        enum DrawMode
        {
            CIRCLE,
            ELIPSE,
            LINE
        }
        bool drawing = false;
        DrawMode mode = DrawMode.LINE;
        int startX, startY;
        public Form2()
        {
            InitializeComponent();
            bitmap  = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            mode = DrawMode.CIRCLE;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mode = DrawMode.CIRCLE;
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
            drawing = true;
            draft = bitmap;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            mode = DrawMode.ELIPSE;
        }

        private void finalizeDrawing(object sender, MouseEventArgs e)
        {
            drawing = false;
            bitmap = (Bitmap)draft.Clone();
        }

        private void drawAsMouseMove(object sender, MouseEventArgs e)
        {
            draft = (Bitmap)bitmap.Clone();
            if (drawing)
            {
                if(mode == DrawMode.ELIPSE)
                {
                    drawElipse(e.X,e.Y);
                }
                if (mode == DrawMode.CIRCLE)
                {
                    drawCirlce(e.X, e.Y);
                }
                if(mode == DrawMode.LINE)
                {
                    drawLine(e.X, e.Y);
                }
            }
        }

        private void drawLine(int x, int y)
        {
            Graphics.myLine(startX, startY,x, y,
                   draft,
                   pictureBox1,
                   Color.Red);
        }

        private void drawLine(object sender, EventArgs e)
        {
            mode = DrawMode.LINE;
        }

        private void drawElipse(int endX, int endY)
        {
            var dx = endX - startX;
            var dy = endY - startY;

            var radius = Math.Sqrt(dx * dx + dy * dy) / 2;

            var midDx =  dx / 2;
            var midDy = dy / 2;

            Graphics.drawElipse(
                   Math.Abs(startX + midDx),
                   Math.Abs(startY + midDy),
                   Math.Abs(dy), Math.Abs(dx),
                   draft,
                   pictureBox1,
                   Color.Red);
        }
        private void drawCirlce(int endX, int endY)
        {
            var dx = endX - startX;
            var dy = endY - startY;

            var radius = Math.Sqrt(dx * dx + dy * dy) / 2;

            var midDx = dx / 2;
            var midDy = dy / 2;

            Graphics.drawCircle(
                   Math.Abs(startX + midDx),
                   Math.Abs(startY + midDy),
                   (int)radius,
                   draft,
                   pictureBox1,
                   Color.Red);
        }
    }
}
