namespace graphics_animation
{
    internal static class Graphics
    {
        public static void drawCircle(int x,int y, int minRadius,int maxRadius,Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int with = bitmap.Width;
            int height = bitmap.Height;
            int x1, y1;
            int intersection;
            float coeficient;
            int radius = minRadius;
            bool radiusIncreasingMode = true;

            if (minRadius <= 50)
            {
                intersection = 360;
                coeficient = 1;
            }
            else if(minRadius <= 100)
            {
                intersection = 720;
                coeficient = 0.5f;
            }
            else
            {
                intersection = 1440;
                coeficient = 0.25f;
            }

            for(int i = 0; i < intersection; i++)
            {
                x1 = (int)(x + radius * Math.Cos(i * coeficient * Math.PI / 180));
                y1 = (int)(y + radius * Math.Sin(i * coeficient * Math.PI / 180));
                bitmap.SetPixel(x1, y1, color);

               if (radius == maxRadius || radius == minRadius)
                {
                    radiusIncreasingMode = !radiusIncreasingMode;
                }
                radius += radiusIncreasingMode ? 1 : -1;

            }
            pictureBox.Image = bitmap;
        }
    }
}