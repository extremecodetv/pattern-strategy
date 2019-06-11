using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            worker.DoWork(new HandJob());
            worker.DoWork(new FootJob());
            Console.ReadKey();

            var secondWorker = new SecondWorker(new HandJob());
            secondWorker.DoJob();
            Console.ReadKey();
        }
    }
}
