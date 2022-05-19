using Day3.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Abstraction
{
    internal class Student : Person
    {
        public List<Class> Course { get; set; }

        public Boolean GPA;


        public override int doSomething()
        {
            return 1;
        }
    }
}
