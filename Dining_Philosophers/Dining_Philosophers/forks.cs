using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dining_Philosophers
{
    public class Forks
    {
        private readonly bool[] fork = new bool[5];

        public void Get(int left, int right)
        {
            lock (this)
            {
                while (fork[left] || fork[right])
                {
                    Monitor.Wait(this);
                }

                fork[left] = true;
                fork[right] = true;
            }
        }

        public void Put(int left, int right)
        {
            lock (this)
            {
                fork[right] = false;
                fork[left] = false;
                Monitor.PulseAll(this);
            }
        }
    }
}
