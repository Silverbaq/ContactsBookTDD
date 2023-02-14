using System.Collections.Generic;
using ContactsBookTDD.Model;

namespace ContactsBookTDD.Controller
{
    public interface IRepository<T>
    {
        void Add(T value);
        
        List<T> GetAll();

        T GetById(string id);

        void Update(T value);

        void Remove(T value);
    }
}