using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopLight
{
    public abstract class Semaphore
    {
        protected StopLight _currentState;
        public StopLight CurrentState
        {
            get
            {
                return _currentState;
            }
        }

        public abstract void Next();
    }
}
