using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WePeEfApp
{
    class GameView : Canvas
    {
        private GameLevels _gameLevels;
        private PlayerChoserPanel _playerChoserPanel;
        public static GameView Window;
        private Timer _timer;
        public GameView()
        {
            InitializeStuff();
        }

        public void InitializeStuff()
        {
            _playerChoserPanel = new PlayerChoserPanel();
            _timer = new Timer(GameTimerTick, TimeSpan.FromMilliseconds(15));
            Window = this;
            ClipToBounds = true;
            Children.Add(_playerChoserPanel);
            UpdatePanels();
        }
        public void UpdatePanels()
        {
            _playerChoserPanel.UpdatePanelsEvent += UpdatePanelsEvent;
        }

        private void UpdatePanelsEvent(object sender, Player e)
        {
            _playerChoserPanel.UpdatePanelsEvent -= UpdatePanelsEvent;
            _gameLevels = new GameLevels();
            Children.Remove(_playerChoserPanel);
            Children.Add(_gameLevels.Current);
            _timer.Start();
        }
        private void GameTimerTick(object sender, EventArgs e)
        {
            _gameLevels.Current.MoveEverything();
        }
    }
}
