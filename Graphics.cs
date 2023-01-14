using System.Diagnostics;

namespace graphics_animation
{
    internal static class Graphics
    {
        public static void drawCircle(int x, int y, int minRadius, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int x1, y1;
            int intersection;
            float coeficient;

            if (minRadius <= 50)
            {
                intersection = 360;
                coeficient = 1;
            }
            else if (minRadius <= 100)
            {
                intersection = 720;
                coeficient = 0.5f;
            }
            else
            {
                intersection = 1440;
                coeficient = 0.25f;
            }

            for (int i = 0; i < intersection; i++)
            {
                x1 = (int)(x + minRadius * Math.Cos(i * coeficient * Math.PI / 180));
                y1 = (int)(y + minRadius * Math.Sin(i * coeficient * Math.PI / 180));
                setPixel(x1, y1,bitmap, color);
            }
            pictureBox.Image = bitmap;
        }

        public static void drawElipse(int x, int y, int minRadius, int maxRadius, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int x1, y1;
            int intersection;
            float coeficient;

            if (minRadius <= 50)
            {
                intersection = 360;
                coeficient = 1;
            }
            else if (minRadius <= 100)
            {
                intersection = 720;
                coeficient = 0.5f;
            }
            else
            {
                intersection = 1440;
                coeficient = 0.25f;
            }

            for (int i = 0; i < intersection; i++)
            {
                x1 = (int)(x + maxRadius * Math.Cos(i * coeficient * Math.PI / 180));
                y1 = (int)(y + minRadius * Math.Sin(i * coeficient * Math.PI / 180));
                setPixel(x1, y1, bitmap, color);
            }
            pictureBox.Image = bitmap;
        }
        private static void setPixel(int x, int y,Bitmap bitmap,Color color)
        {
            if(bitmap.Width > x && bitmap.Height > y && y >= 0 && x >= 0)
            {
                bitmap.SetPixel(x,y, color);
            }
                
        }
        public static void myLine(int x0, int y0, int x1, int y1, Bitmap bitmap, PictureBox pictureBox, Color color)

        {

            //DDA algorithm

            int dl;

            int width = bitmap.Width - 1;

            int height = bitmap.Height - 1;

            // horizontal line

            if (y0 == y1)

            {

                dl = Math.Abs(x1 - x0);

                int dxii;

                int xii = x0;

                if (x0 < x1) dxii = 1; else dxii = -1;

                for (int i = 0; i < dl; i++)

                {

                    if ((xii > 1) && (xii < width) && (y0 > 1) && (y0 < height))

                        bitmap.SetPixel(xii, y0, color);

                    xii += dxii;

                }

                pictureBox.Image = bitmap;

                return;

            } // end of horizontal line

            // vertical line

            if (x0 == x1)

            {

                dl = Math.Abs(y1 - y0);

                int dyii;

                int yii = y0;

                if (y0 < y1) dyii = 1; else dyii = -1;

                for (int i = 0; i < dl; i++)

                {

                    if ((x0 > 1) && (x0 < width) && (yii > 1) && (yii < height))

                        bitmap.SetPixel(x0, yii, color);

                    yii += dyii;

                }

                pictureBox.Image = bitmap;

                return;

            } // end of vertical line

            // diagonal line

            float m = 0, dx = 0, dy = 0;

            float xi = x0, yi = y0;

            if (x0 != x1) m = (float)(y1 - y0) / (x1 - x0);



            if (Math.Abs(x1 - x0) >= Math.Abs(y1 - y0))

            {

                if (x0 < x1) dx = 1; else dx = -1;

                dl = Math.Abs(x1 - x0);

                dy = m * dx;

            }

            else

            {

                if (y0 < y1) dy = 1; else dy = -1;

                dl = Math.Abs(y1 - y0);

                dx = dy / m;

            } // enf of if

            for (int i = 0; i <= dl; i++)

            {

                if ((xi > 1) && (xi < width) && (yi > 1) && (yi < height))

                    bitmap.SetPixel((int)xi, (int)yi, color);

                xi += dx; yi += dy;

            }

            pictureBox.Image = bitmap;

        }

    }
}