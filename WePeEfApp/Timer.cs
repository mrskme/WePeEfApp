using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WePeEfApp
{
    class Timer : DispatcherTimer
    {
        public Timer(EventHandler onTick, TimeSpan interval)
        {
            Interval = interval;
            Tick += onTick;
        }
    }
}
