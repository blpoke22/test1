using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterOOinCSharp
{
    class Program
    {
        // Task 2.2.1
        public delegate Employee ManageWorker(int id);
        static void Main(string[] args)
        {
            // Task 2.1.4 & 2.1.5
            Boss boss1 = new Boss();

            boss1.Display();
            Console.WriteLine("Working with {0}", boss1.Use(1));
            Console.WriteLine("After working with that employee");
            boss1.Display();

            //Task 2.2.2
            Action doSomething;
            ManageWorker manage;
            Boss boss2 = new Boss();

            doSomething = boss2.Display;
            manage = boss2.Use;
            // manage = boss2.Fire;   Task 2.2.3

            doSomething();
            Console.WriteLine("Dealing with {0}", manage(1));
            Console.WriteLine("After dealing with that employee");
            Console.WriteLine("This is an addition via GITHub");
            doSomething();

        }
    }
}
