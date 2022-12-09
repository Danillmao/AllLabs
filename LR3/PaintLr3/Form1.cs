using System.Windows.Forms;

namespace PaintLr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
        }

        Color DefaultColor
        {
            get { return Color.White; }
        }

        void CreateBlank(int width, int height)
        {
            var oldImage = pictureBox1.Image;

            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;

            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }
        // œÂÂÏÂÌÌ˚Â 
        int _x;
        int _y;
       private bool _mouseclicked = false;
            
            Color SelectedColor
            {
                get{ return Color.Red; }
            }

            int SelectedSize
            {
                get{ return brushSizeBar.Value; }             
            }

        Brush _selectedBrush;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null)
            {
                return;
            }

            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();
            _mouseclicked= true;
        }
        
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseclicked= false;  
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if(_mouseclicked )
            {
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void brushSizeBar_Scroll(object sender, EventArgs e)
        {

        }

        private void ‚˚ıÓ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ÒÓÁ‰‡Ú¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}