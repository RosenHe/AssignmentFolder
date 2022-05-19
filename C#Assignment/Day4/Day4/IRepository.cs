using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal interface IRepository<T> where T : class
    {
        public void Add(T item);
        public void Remove(T item);
        public void Save();
        public void Update(int id, String name);
        public IEnumerable<T> GetAll();
        public T GetById(int id);

    }
}
