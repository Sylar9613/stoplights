using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopLight
{
    public abstract class SemaphoreFactory
    {
        public abstract Semaphore Create();
    }
}
