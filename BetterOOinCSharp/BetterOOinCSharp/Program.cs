using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterOOinCSharp
{
    public delegate Employee ManageWorker(int id);
    class Program
    {
        // Task 2.2.1
        public delegate Employee ManageWorker(int id);
        static void Main(string[] args)
        { 
            Boss b = new Boss();

            Action doSomething = b.display;
            ManageWorker manage = b.Use;

            doSomething();
            Console.WriteLine("Dealing with {0}", manage(5));
            doSomething();
        }
    }
}
