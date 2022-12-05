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
        Bitmap bitmap;
        public Form2()
        {
            InitializeComponent();
            bitmap  = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            

            Graphics.drawCircle(e.X, e.Y, 50, 100, bitmap, pictureBox1, Color.Red);
        }
    }
}
