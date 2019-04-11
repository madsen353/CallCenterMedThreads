using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterWithThreads
{
    class Gold : IPriority
    {
        public int Priority { get; set; }

        public Gold()
        {
            this.Priority = 1;
        }
    }
}
