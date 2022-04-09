using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterOOinCSharp
{
    /*
     * Task 2.1.3
     */
    public class Boss
    {
        private List<Employee> staff;

        public Boss()
        {
            staff = Agency.loadAll();
        }

        public void display()
        {
            foreach(Employee e in staff)
            {
                Console.WriteLine(e);
            }
        }

        public Employee Use(int id)
        {
            foreach(Employee e in staff)
            {
                if(e.ID == id)
                {
                    return e;
                }
            }

            return null;
        }

        public Employee Fire(int id)
        {
            Employee target = Use(id);

            if(target != null)
            {
                staff.Remove(target);
            }

            return target;
        }
    }
}
