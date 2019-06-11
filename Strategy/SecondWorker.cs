using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class SecondWorker
    {
        private IJob _job;

        public SecondWorker(IJob job)
        {
            _job = job;
        }

        public void DoJob()
        {
            if (_job != null)
            {
                _job.DoJob();
            }
        }
    }
}
