using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class ManageEmployees
    {
        EmployeeRepository employeeRepository;
        public ManageEmployees()
        {
            employeeRepository = new EmployeeRepository();
        }

        public void Run()
        {

            Demo();
        }
        public void Demo()
        {
            foreach(Employee emp in employeeRepository.GetEmployees())
            {
                Console.WriteLine(emp.ToString());
            }
            //Query Syntax
            var result = from employee in employeeRepository.GetEmployees()
                         select employee;
            var result1_2 = from employee in employeeRepository.GetEmployees()
                         select employee.FullName;
            //method syntax
            var result2 = employeeRepository.GetEmployees().Select(emp => emp).ToList();
            var result3 = employeeRepository.GetEmployees().Select(emp => emp.FullName).ToList();

            //query syntax
            var result4 = from employee in employeeRepository.GetEmployees()
                          select new
                          {
                              Id = employee.Id,
                              FullName = employee.FullName,
                              Department = employee.Department
                          };
            var result5 = (from employee in employeeRepository.GetEmployees()
                          select employee.Department).Distinct();
            var result6 = employeeRepository.GetEmployees().Select(emp => new { emp.Id, emp.FullName }).First(fod => fod.FullName == "Amy");

            var result7 = from employee in employeeRepository.GetEmployees()
                          orderby employee.Salary descending, employee.FullName descending
                          select new
                          {
                              Id = employee.Id,
                              FullName = employee.FullName,
                              Salary = employee.Salary
                          };
            var result8 = employeeRepository.GetEmployees().OrderByDescending(money => money.Salary)
                .ThenByDescending(x => x.FullName).Select(emp => new { Id = emp.Id, FullName = emp.FullName, Salary = emp.Salary});

            var result9 = from employee in employeeRepository.GetEmployees()
                          where employee.Salary > 7000 && employee.Department == "Sales"
                          select new
                          {
                              Id = employee.Id,
                              FullName = employee.FullName,
                              Salary = employee.Salary

                          };
            var result10 = employeeRepository.GetEmployees().Where(x => x.Salary > 7000 & x.Department == "Sales")
                .Select(x => new {Id = x.Id, FullName = x.FullName, Salary = x.Salary });
            var result11 = 
        }   

    }
}
