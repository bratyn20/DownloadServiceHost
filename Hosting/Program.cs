using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Service.ServiceUpdate)))
            {
                host.Open();

                Console.WriteLine("Server Started...");
                Console.ReadLine();

            }
        }
    }
}
