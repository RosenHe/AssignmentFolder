using Day3.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Abstraction
{
    internal class Instructor : Person
    {
        public bool IsHeadofDepartment;

        public double Bonus { get; set; } 
        public int yearOfExperience { get; set; }

        
        public Department department;

        public void checkIsHeadofDepartment(string department)
        {
            String name = department.headofDepartment(); // Dependency Injection needed.  
            if (name == this.Name) IsHeadofDepartment = true;
            else IsHeadofDepartment= false;
        }
        public override int doSomething()
        {
            return 2;
        }
    }
}
