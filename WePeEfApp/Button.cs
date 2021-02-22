using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Media;

namespace WePeEfApp
{
    class Button : System.Windows.Controls.Button
    {
        public Button(Brush color, string text, int x, int y, int width, int height, RoutedEventHandler onClick)
        {
            Click += onClick;
            Background = color;
            Name = text;
            Width = width;
            Height = height;
            Canvas.SetLeft(this, x);
            Canvas.SetTop(this, y);
        }
    }
}
