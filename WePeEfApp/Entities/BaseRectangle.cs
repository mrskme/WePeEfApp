using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WePeEfApp
{
    class BaseRectangle
    {
        public Rectangle Box;
        private int _width;
        private int _height;
        private string _name;
        private readonly int _startX;
        private readonly int _startY;
        private readonly Brush _color;
        public BaseRectangle(int width, int height, string name, int startX, int startY, Brush color)
        {
            _startX = startX;
            _startY = startY;
            _width = width;
            _height = height;
            _color = color;

            Box = new Rectangle
            {
                Stroke = Brushes.Black,
                Fill = _color,
                StrokeThickness = 2,
                Width = _width,
                Height = _height,
            };
            Canvas.SetLeft(Box, _startX);
            Canvas.SetTop(Box, _startY);
        }
    }
}
