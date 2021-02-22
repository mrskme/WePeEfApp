using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WePeEfApp
{
    class Platform : BaseRectangle
    {
        public Platform(int width, int height, string name, int startX, int startY, Brush color) : base(width, height, name, startX, startY, color)
        {
        }
    }
}
