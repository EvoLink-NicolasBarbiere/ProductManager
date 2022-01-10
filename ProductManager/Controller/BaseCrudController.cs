using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Controller
{
    class BaseCrudController<T> where T : Imodel
    {
        private List<T> _objs = new List<T>();

        protected void Create(T obj)
        {
            if (ItemAlreadyInList(obj))
                return;

            //for (int i = 0; i < 2; i++)
            //{
                obj.Id = GetNewId();
                _objs.Add(obj);
            //}
        }

        protected List<T> GetAll() => _objs;

        protected void Update(T obj)
        {
            if (_objs.Any(T => obj.Id == obj.Id))
                _objs[GetIndexById(obj.Id)] = obj;
        }

        protected void Delete(int id)
        {
            if (_objs.Any(T => T.Id == id))
                _objs.RemoveAt(GetIndexById(id));
        }

        private bool ItemAlreadyInList(T obj) => _objs.Any(T => obj.Equals(obj));
        private int GetNewId() => _objs.Any() ? _objs.OrderByDescending(T => T.Id).First().Id + 1 : 1;
        private int GetIndexById(int id) => _objs.IndexOf(_objs.First( T => T.Id == id));
    }
}
