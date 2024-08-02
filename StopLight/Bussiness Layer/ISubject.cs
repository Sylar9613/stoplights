using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopLight.Bussiness_Layer
{
    public interface ISubject
    {
        void Attach(IObserver observers);
        void Dettach(IObserver observers);
        void Notify();
    }
}
