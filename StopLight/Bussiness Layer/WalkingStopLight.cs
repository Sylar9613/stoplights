using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopLight.Bussiness_Layer
{
    public class WalkingStopLight:Semaphore
    {
        public WalkingStopLight()
        {
            _currentState = new WalkingLightRed();
        }
        public override void Next()
        {
            _currentState = _currentState.Next();
        }
    }
}
