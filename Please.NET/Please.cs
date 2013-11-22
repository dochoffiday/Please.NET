using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Linq;

namespace Please.NET
{
    public class Please
    {
        public List<Thread> AllPleaseEvents { get; set; }

        public Please()
        {
            AllPleaseEvents = new List<Thread>();
        }

        public void Do(Action action, bool shouldthisbedone = true)
        {
            if (!shouldthisbedone) return;
            var t = new Thread(() => action());
            this.ThreadTheNeedle(t);
            t.Start();
        }

        public void Dont(Action action)
        {
            Do(action, false);
        }

        public void PrettyPlease(Action action, bool withCherryOnTop = false)
        {
            Do(action, withCherryOnTop);
        }

        public void Repeat(int count, Action<int> action)
        {
            for (var r = 0; r < count; r++)
            {
                var r1 = r;
                Do(() => action(r1));
            }
        }

        public void WeatherPermitting(Action action)
        {
            var r = new Random();
            Do(action, r.Next() % 2 == 0);
        }

        public bool TellMeIfAllTasksAreCompleted()
        {
            return AllPleaseEvents.All(x => !x.IsAlive);
        }

        private void ThreadTheNeedle(Thread t)
        {
            AllPleaseEvents.Add(t);
        }
    }
}