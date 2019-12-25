using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dining_Philosophers
{
    public class Philosophers
    {
        private int _philonr;
        private int _forkleft;
        private int _forkright;

        private int _thinkDelay;
        private int _eatDelay;
        private Forks _forks;

        public Philosophers(int philonr, int thinkDelay, int eatDelay, Forks forks)
        {
            this._philonr = philonr;
            this._thinkDelay = thinkDelay;
            this._eatDelay = eatDelay;
            this._forks = forks;

            this._forkleft = _philonr == 0 ? 4 : _philonr - 1;
            this._forkright = (_philonr + 1) % 5;
            new Thread(this.Run).Start();
        }

        private void Run()
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(this._thinkDelay);
                    _forks.Get(_forkleft,_forkright);
                    Console.WriteLine($"Philosopher {_philonr} is eating.");
                    Thread.Sleep(_eatDelay);
                    _forks.Put(_forkleft,_forkright);

                }
                catch
                {
                    return;
                }
            }
        }
    }
}
