using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopLight
{
    public class VialStopLight:Semaphore
    {
        public VialStopLight()
        {
            _currentState = new VialLightGreen();
        }
        public override void Next()
        {
            _currentState = _currentState.Next();
        }
    }
}
