using Interceptor_Wether.Classes;
using Interceptor_Wether.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor_Wether
{
    class Program
    {
        static void Main(string[] args)
        {

            Framework framework = new Framework();
            framework.eventTrigger(22.0, 72.0, 1213.0);
            framework.eventTrigger(23.0, 75.0, 1313.0);
            framework.eventTrigger(24.0, 76.0, 1113.0);
            framework.eventTrigger(25.0, 70.0, 1243.0);
            Console.ReadLine();
        }
    }
}
