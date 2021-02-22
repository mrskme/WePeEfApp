using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WePeEfApp
{
    class Platforms
    {
        private List<Platform> _platforms;
        private readonly List<Platform> _baseSetup;

        public Platforms(List<Platform> platforms)
        {
            _baseSetup = platforms;
            Reset();
        }

        private void Reset()
        {
            _platforms = _baseSetup;
        }

        private void Move()
        {
            foreach (var platform in _platforms)
            {
                
            }
        }
    }
}
