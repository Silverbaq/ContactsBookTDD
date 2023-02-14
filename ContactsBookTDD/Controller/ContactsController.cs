using System.Collections.Generic;
using ContactsBookTDD.Model;

namespace ContactsBookTDD.Controller
{
    public class ContactsController : IContactController
    {
        private IRepository<Person> _personRepository;

        internal ContactsController()
        {
            this._personRepository = new FakePersonRepository();
        }
        
        public void createPerson(string name, string address = "", string email = "", string phoneNumber = "")
        {
            throw new System.NotImplementedException();
        }

        public List<Person> findPerson(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> getAllPersons()
        {
            throw new System.NotImplementedException();
        }

        public void updatePerson(string name, string address = "", string email = "", string phoneNumber = "")
        {
            throw new System.NotImplementedException();
        }

        public void removePerson(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}