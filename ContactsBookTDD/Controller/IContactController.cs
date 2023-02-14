using System.Collections.Generic;
using ContactsBookTDD.Model;

namespace ContactsBookTDD.Controller
{
    public interface IContactController
    {
        void createPerson(string name, string address = "", string email = "", string phoneNumber = "");
        List<Person> findPerson(string name);
        List<Person> getAllPersons();
        void updatePerson(string name, string address = "", string email = "", string phoneNumber = "");
        void removePerson(string id);
    }
}