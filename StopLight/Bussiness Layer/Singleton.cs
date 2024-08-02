using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopLight.Bussiness_Layer;

namespace StopLight
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();
        private Semaphore _semaphoreVial;
        private Semaphore _semaphoreWalking;
        private Singleton()
        {
            _semaphoreVial = new VialSemaphoreFactory().Create();
            _semaphoreWalking = new WalkingSemaphoreFactory().Create();
        }

        public static Singleton GetInstance
        {
            get
            {
                return _instance;
            }
        }
        public Semaphore GetSemaphoreVial
        {
            get
            {
                return _semaphoreVial;
            }
        }
        public Semaphore GetSemaphoreWalking
        {
            get
            {
                return _semaphoreWalking;
            }
        }
    }
}
