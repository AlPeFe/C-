using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamDroidSingalR
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:5498"; //url del servidor signalR

            using (WebApp.Start(url))
            {
                Console.WriteLine("server running on {0}", url);
                Console.ReadLine();
            }




        }
    }
}
