using System;

namespace ContactsBookTDD.Model
{
    public class Person
    {
        Person(string id, string name, string address = "", string email = "", string phoneNumber = "")
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        private string id { get; }
        private string name { get; } 
        private string address { get; }
        private string email { get; }
        private string phoneNumber { get; }
    }
}