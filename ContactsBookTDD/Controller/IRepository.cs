using System.Collections.Generic;
using ContactsBookTDD.Model;

namespace ContactsBookTDD.Controller
{
    public interface IRepository<T>
    {
        void add(T value);
        
        List<T> getAll();

        T getById(string id);

        void update(T value);

        void remove(T value);
    }
}