using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dining_Philosophers
{
    class Program
    {
        static void Main(string[] args)
        {
            Forks forks = new Forks();
            Random r = new Random();
            new Philosophers(0, r.Next(50, 1000), r.Next(50, 1000), forks);
            new Philosophers(1, r.Next(50, 1000), r.Next(50, 1000), forks);
            new Philosophers(2, r.Next(50, 1000), r.Next(50, 1000), forks);
            new Philosophers(3, r.Next(50, 1000), r.Next(50, 1000), forks);
            new Philosophers(4, r.Next(50, 1000), r.Next(50, 1000), forks);
        }
    }
}
