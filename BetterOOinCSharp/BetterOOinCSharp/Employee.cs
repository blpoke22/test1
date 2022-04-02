using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterOOinCSharp
{
    public enum Gender { M, F, X };
    
    /*
     * Task 2.1.1
     */
    public class Employee
    {
        //These properties have auto-generated getters (accessors <- fancy name) and
        //setters (mutators <- again fancier name); hence, are entirely public
        public string Name { get; set; }
        public int ID { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return Name + '\t' + ID + '\t' + Gender;
        }

    }
}
