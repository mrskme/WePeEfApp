using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WePeEfApp
{
    class PlayerChoserPanel : Canvas
    {
        private Player player1;
        private Player player2;
        private Player player3;

        public static Player ChosenPlayer;

        public event EventHandler<Player> UpdatePanelsEvent;

        public PlayerChoserPanel()
        {
            Height = 801;
            Width = 1537;
            Background = Brushes.Aqua;
            player1 = new Player(20, 100, 100, "Kåre", 500, 500, Brushes.DarkGoldenrod);
            player2 = new Player(10, 200, 200, "Bobby", 500, 500, Brushes.LightCoral);
            player3 = new Player(30, 50, 50, "Bobbern", 500, 500, Brushes.Brown);
            CreateButtons();
        }

        public void CreateButtons()
        {
            Button[] buttons =
            {
                new Button(Brushes.DarkGoldenrod, "Kåre", 400, 200, 150,100, Player1ButtonOnClick),
                new Button(Brushes.LightCoral,"Bobby", 700, 200,150, 100, Player2ButtonOnClick),
                new Button(Brushes.Brown,"Bobbern",1000, 200, 150, 100, Player3ButtonOnClick),
            };
            AddButtonsToPanel(buttons);
        }

        public void AddButtonsToPanel(Button[] buttons)
        {
            foreach (var button in buttons)
            {
                Children.Add(button);
            }
        }
        private void Player1ButtonOnClick(object sender, EventArgs e)
        {
            ChosenPlayer = player1;
            UpdatePanelsEvent?.Invoke(this, ChosenPlayer);
        }
        private void Player2ButtonOnClick(object sender, EventArgs e)
        {
            ChosenPlayer = player2;
            UpdatePanelsEvent?.Invoke(this, ChosenPlayer);
        }
        private void Player3ButtonOnClick(object sender, EventArgs e)
        {
            ChosenPlayer = player3;
            UpdatePanelsEvent?.Invoke(this, ChosenPlayer);
        }
    }
}
