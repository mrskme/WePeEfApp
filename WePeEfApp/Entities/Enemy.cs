using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WePeEfApp
{
    class Enemy : BaseRectangle
    {
        private int _speed;
        public Enemy(int speed, int width, int height, string name, int startX, int startY, Brush color) : base(width, height, name, startX, startY, color)
        {
            _speed = speed;
        }

        public void MoveEnemy()
        {
            Canvas.SetLeft(Box, Canvas.GetLeft(Box) - _speed);
        }
    }
}
