using Day5SampleApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5SampleApp.Repository
{
    public class DepartmentRepository : IRepository<Departments>
    {
        List<Departments> _list;
        public DepartmentRepository()
        {
            _list = new List<Departments>();
        }

        void IRepository<Departments>.Delete(Departments entity)
        {
            Departments d = GetById(entity.Id);
            if (d != null) _list.Remove(d);
        }


        IEnumerable<Departments> IRepository<Departments>.GetAll()
        {
            return _list;
        }

        Departments GetById(int id)
        {
            foreach (Departments d in _list)
            {
                if (d.Id == id)
                    return d;
            }
            return null;
        }

        Departments IRepository<Departments>.GetById(int id)
        {
            foreach (Departments d in _list)
            {
                if (d.Id == id)
                    return d;
            }
            return null;
        }



        void IRepository<Departments>.Insert(Departments entity)
        {
            _list.Add(entity);
        }

        void IRepository<Departments>.Update(Departments entity)
        {
            Departments d = GetById(entity.Id);
            if(d != null)
            {
                d.Location = entity.Location;
                d.Name = entity.Name;
            }
        }
    }
}
