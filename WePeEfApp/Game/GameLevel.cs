using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WePeEfApp
{
    class GameLevel : Canvas
    {
        public Platforms Platforms { get; }
        public Enemies Enemies { get; }
        public Player Player => PlayerChoserPanel.ChosenPlayer;


        public GameLevel(List<Platform> platforms, List<Enemy> enemies, Brush color)
        {
            Height = 801;
            Width = 1537;
            Background = color;
            Platforms = new Platforms(platforms);
            Enemies = new Enemies(enemies);
            AddPlatformsToCanvas(platforms);
            AddEnemiesToCanvas(enemies);
            AddPlayerToCanvas();

            //Show();
            //ADD game level to GameView
        }
        public void MoveEverything()
        {
            Player?.MovePlayer();
            Enemies?.MoveEnemies();
        }
        public void AddEnemiesToCanvas(List<Enemy> enemies)
        {
            foreach (var enemy in enemies)
            {
                Children.Add(enemy.Box);
            }
        }
        public void AddPlatformsToCanvas(List<Platform> platforms)
        {
            foreach (var platform in platforms)
            {
                Children.Add(platform.Box);
            }
        }
        public void AddPlayerToCanvas()
        {
            Children.Add(Player.Box);
        }
        //var plist = new List<Platform>();
        //List<BaseBox> blist;
        ////b = p;
        //blist = plist.Select(p => (BaseBox) p).ToList();
    }
}
