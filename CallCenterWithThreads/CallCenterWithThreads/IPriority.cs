using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterWithThreads
{
    public interface IPriority
    {
        int Priority { get; set; }
        //void SetPriority();
    }
}
