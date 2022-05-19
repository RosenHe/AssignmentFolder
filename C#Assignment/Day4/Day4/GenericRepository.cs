using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class GenericRepository : IRepository<Generic>
    {
        List<Generic> _list;
        public GenericRepository()
        {
            _list = new List<Generic>();
        }
        public void Add(Generic item)
        {
            _list.Add(item);
        }

        public IEnumerable<Generic> GetAll()
        {
            return _list;
        }

        public Generic GetById(int id)
        {
            for(int i = 0; i < _list.Count; i++)
            {
                if(id == _list[i].Id) return _list[i];
            }
            return null;
        }

        public void Remove(Generic item)
        {
            for(int j = 0; j < _list.Count; j++)
            {
                if(item == _list[j]) _list.RemoveAt(j);
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string name)
        {
            for(var i = 0; i < _list.Count; i++)
            {
                if(id == _list[i].Id) _list[i].Name = name;
            }
        }
    }
}
