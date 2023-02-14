using System.Collections.Generic;
using ContactsBookTDD.Model;

namespace ContactsBookTDD.Controller
{
    public class FakePersonRepository : IRepository<Person>
    {
        private List<Person> _persons = new List<Person>();
        
        public void Add(Person value)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Person GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Person value)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Person value)
        {
            throw new System.NotImplementedException();
        }
    }
}