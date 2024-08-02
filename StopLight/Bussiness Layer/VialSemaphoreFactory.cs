using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopLight
{
    public class VialSemaphoreFactory:SemaphoreFactory
    {
        public override Semaphore Create()
        {
            return new VialStopLight();
        }
    }
}
