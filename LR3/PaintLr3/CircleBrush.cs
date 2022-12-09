using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintLr3
{
    internal class CircleBrush : Brush
    {
        public CircleBrush(Color brushColor, int size) 
            : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {

        }
    }
}
