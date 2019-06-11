using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class HandJob : IJob
    {
        public void DoJob()
        {
            Console.WriteLine("Hand Job");
        }
    }
}
