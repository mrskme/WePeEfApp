using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WePeEfApp
{
    class Player : BaseRectangle
    {
        private int _walkingSpeed;
        private int _hitboxBot = 600;
        //private int _hitboxRight = 600;

        public Player(int walkingSpeed, int width, int height, string name, int startX, int startY, Brush color) : base(width, height, name, startX, startY, color)
        {
            _walkingSpeed = walkingSpeed;
        }
        public void MovePlayer()
        {
            //var oldTop = Top;
            //var oldLeft = Left;

            if (Keyboard.IsKeyDown(Key.A))
            {
                Canvas.SetLeft(Box, Canvas.GetLeft(Box) - _walkingSpeed);
            }

            if (Keyboard.IsKeyDown(Key.D))
            {
                Canvas.SetLeft(Box, Canvas.GetLeft(Box) + _walkingSpeed);
            }
            //Height = 801;
            //Width = 1537;
            if (Keyboard.IsKeyDown(Key.S))
            {
                Canvas.SetTop(Box, Canvas.GetTop(Box) + _walkingSpeed);
            }

            if (Keyboard.IsKeyDown(Key.W) && Canvas.GetTop(Box) > 0)
            {
                Canvas.SetTop(Box, Canvas.GetTop(Box) - _walkingSpeed);
            }

            //if (IsObjectColliding(this))
            //{
            //    NewRectangle.Top = oldTop;
            //    NewRectangle.Left = oldLeft;
            //}
        }
    }
}
