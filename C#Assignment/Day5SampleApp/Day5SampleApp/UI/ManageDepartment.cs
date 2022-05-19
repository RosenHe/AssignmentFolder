using Day5SampleApp.Entity;
using Day5SampleApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5SampleApp.UI
{
    public class ManageDepartment
    {
        IRepository<Departments> _repository;
        public ManageDepartment()
        {
            _repository = new DepartmentRepository();
        }
        void PrintAllDepartments()
        {
            IEnumerable<Departments> depoList = _repository.GetAll();
            foreach (Departments department in depoList)
                Console.WriteLine($"{department.Id}");

        }
        void DeleteDepartments()
        {

        }
    }
}
