using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Looper
{
    class Program
    {
        static void Main(string[] args)
        {      
            var connection = new HubConnection("http://localhost:6565/", new Dictionary<string, string>
            {
                { "id", "Consola2" }
            });

            var hub = connection.CreateHubProxy("GamHub");

            connection.Start().ContinueWith(task =>
            {
                if (task.IsCompleted)
                    Console.WriteLine("DeviceHub");

            }).Wait();

         
        }
    }
}
