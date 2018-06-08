using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SignalRClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new HubConnection("http://localhost:6565/", new Dictionary<string, string>
            {
                { "id", WindowsIdentity.GetCurrent().Name },
                {"vhi", "223" }
            });

            var hub = connection.CreateHubProxy("DeviceHub");

            connection.Start().ContinueWith(task =>
            {
                if (task.IsCompleted)
                    Console.WriteLine("Conectado");

            }).Wait();       
            
            }         
        }
    }

