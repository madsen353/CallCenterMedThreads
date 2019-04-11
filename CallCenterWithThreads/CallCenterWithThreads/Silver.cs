using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterWithThreads
{
    public class Silver : IPriority
    {
        public int Priority { get; set; }

        public Silver()
        {
            this.Priority = 2;
            
        }
    }
}
