using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Abstraction
{
    internal class Instructor : Person
    {
        public override int doSomething()
        {
            return 2;
        }
    }
}
