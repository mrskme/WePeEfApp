using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePeEfApp
{
    class Enemies
    {
        private List<Enemy> _enemies;
        private readonly List<Enemy> _baseSetup;
        public Enemies(List<Enemy> enemies)
        {
            _baseSetup = enemies;
            Reset();
        }
        private void Reset()
        {
            _enemies = _baseSetup;
        }

        public void MoveEnemies()
        {
            foreach (var enemy in _enemies)
            {
                enemy.MoveEnemy();
            }
        }
    }
}
