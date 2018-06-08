using SignalRClientTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Looper
{
    public class LooperThread
    {
        Thread _thread;

        public void InitializeLooper()
        {
            _thread = new Thread(InfiniteLooper);

            _thread.Start();
        }


        public void InfiniteLooper()
        {

            while (true)
            {

                using(var ent = new comunicaEntities.)





                Thread.Sleep(10000);
            }


        }

    }
}
