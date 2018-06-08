using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamDroidSingalR
{
    public class GamHub : Hub
    {
        public override Task OnConnected()
        {

            Console.WriteLine("Connected");

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {

            Console.WriteLine("Disconnected");
            return base.OnDisconnected(stopCalled);
        }

    }
}
