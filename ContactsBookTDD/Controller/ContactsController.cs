using System.Collections.Generic;
using ContactsBookTDD.Model;

namespace ContactsBookTDD.Controller
{
    public class ContactsController : IContactController
    {
        private IRepository<Person> _personRepository;

        public ContactsController()
        {
            this._personRepository = new FakePersonRepository();
        }
        
        public void CreatePerson(string name, string address = "", string email = "", string phoneNumber = "")
        {
            throw new System.NotImplementedException();
        }

        public List<Person> FindPerson(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> GetAllPersons()
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePerson(string id, string name, string address = "", string email = "", string phoneNumber = "")
        {
            throw new System.NotImplementedException();
        }

        public void RemovePerson(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}