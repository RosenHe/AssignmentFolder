using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Interfaces
{
    internal  abstract class PersonService
    {
        public abstract int getAgeofPerson();
        public abstract double GetSalaryofPerson();

        public abstract String[] getAddress();
    }
}
