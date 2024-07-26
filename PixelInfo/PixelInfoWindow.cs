using System.Windows.Forms;

namespace PixelInfo;

public partial class PixelInfoWindow : Form
{
    private readonly string PositionMask;
    private readonly string ColorMask;

    public PixelInfoWindow()
    {
        InitializeComponent();
        PositionMask = Position_Lablel.Text;
        ColorMask = Color_Label.Text;
    }

    private void Update_Timer_Tick(object sender, EventArgs e)
    {
#if false
        Point point = Cursor.Position;
        point.X += 30;
        Location = point;
#endif
        Position_Lablel.Text = string.Format(PositionMask, Cursor.Position.X, Cursor.Position.Y);

        using Bitmap bmp = new(1, 1);
        using Graphics g = Graphics.FromImage(bmp);
        g.CopyFromScreen(Cursor.Position, new(0, 0), bmp.Size);
        Color c = bmp.GetPixel(0, 0);
        Color_Label.Text = string.Format(ColorMask, c.R, c.G, c.B);
    }
}