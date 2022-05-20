using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee(){Id = 1, }
            }
        }
    }
}
