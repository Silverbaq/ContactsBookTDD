using System.Collections.Generic;
using ContactsBookTDD.Model;

namespace ContactsBookTDD.Controller
{
    public interface IContactController
    {
        void CreatePerson(string name, string address = "", string email = "", string phoneNumber = "");
        List<Person> FindPerson(string name);
        List<Person> GetAllPersons();
        void UpdatePerson(string id, string name, string address = "", string email = "", string phoneNumber = "");
        void RemovePerson(string id);
    }
}