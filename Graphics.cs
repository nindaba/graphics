namespace graphics_animation
{
    internal static class Graphics
    {
        public static void drawCircle(int x, int y, int minRadius, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int with = bitmap.Width;
            int height = bitmap.Height;
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
            int with = bitmap.Width;
            int height = bitmap.Height;
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
    }
}