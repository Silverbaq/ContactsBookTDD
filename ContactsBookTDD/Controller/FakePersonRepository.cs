using System.Collections.Generic;
using ContactsBookTDD.Model;

namespace ContactsBookTDD.Controller
{
    public class FakePersonRepository : IRepository<Person>
    {
        private List<Person> _persons = new List<Person>();
        
        public void add(Person value)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> getAll()
        {
            throw new System.NotImplementedException();
        }

        public Person getById(string id)
        {
            throw new System.NotImplementedException();
        }

        public void update(Person value)
        {
            throw new System.NotImplementedException();
        }

        public void remove(Person value)
        {
            throw new System.NotImplementedException();
        }
    }
}