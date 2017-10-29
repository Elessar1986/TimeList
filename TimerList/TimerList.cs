using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerList
{
    public class TimerList<T> : List<T>, IDisposable
    {
        int objLifeTime;
        Timer timer;
        SortedSet<string> disposeTimer;


        public new void Add(T o)
        {
            base.Add(o);
            var t = DateTime.Now.AddSeconds(objLifeTime).ToLongTimeString();
            disposeTimer.Add(t);
        }

        public TimerList(int lifeTimeSeconds = 1)
        {
            if (lifeTimeSeconds < 1) throw new Exception("LifeTime must be biger then 1 second");
            Console.WriteLine($"TimerList created. Objects lifetime = {lifeTimeSeconds}.");
            Console.Beep();
            objLifeTime = lifeTimeSeconds;
            timer = new Timer(new TimerCallback(DeleteInTime), null, 0, 1000);
            disposeTimer = new SortedSet<string>();
        }

        private void DeleteInTime(object obj)
        {
            var t = DateTime.Now.ToLongTimeString();
            if (disposeTimer.Remove(t))
            {
                Console.WriteLine($"Delete {this[0]}");
                base.RemoveAt(0);
            }
        }

        public void Dispose()
        {
            timer.Dispose();
            Console.WriteLine("Dispose TimerList");
        }
    }
}
