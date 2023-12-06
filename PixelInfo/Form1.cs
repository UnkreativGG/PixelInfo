using System.Windows.Forms;

namespace PixelInfo
{
    public partial class Form1 : Form
    {
        private Point OldPoint = Point.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Cursor.Position != OldPoint)
            {
                /*
                Point point = Cursor.Position;
                point.X += 30;
                Location = point;
                //*/

                label1.Text = "X:" + Cursor.Position.X + " Y:" + Cursor.Position.Y;

                Bitmap bmp = new(1, 1); ;
                Graphics g = Graphics.FromImage(bmp);
                g.CopyFromScreen(Cursor.Position, new(0, 0), bmp.Size);
                Color c = bmp.GetPixel(0, 0);
                label2.Text = c.R + " " + c.G + " " + c.B;
            }
        }
    }
}