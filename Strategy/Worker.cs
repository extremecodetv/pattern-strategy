using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Worker
    {

        public void DoWork(IJob job)
        {
            if (job != null)
            {
                job.DoJob();
            }

        }
    }
}
