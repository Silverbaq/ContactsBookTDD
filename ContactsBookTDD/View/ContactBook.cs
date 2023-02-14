using System;
using System.Collections.Generic;
using ContactsBookTDD.Controller;
using ContactsBookTDD.Model;

namespace ContactsBookTDD.View
{
    public class ContactBook
    {
        private IContactController _contactController = new ContactsController();

        internal void run()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*** The Awesome contact book! ***");
            Console.WriteLine("*********************************");


            int menuChoice = 0;            
            while (true)
            {
                switch (menuChoice)
                {
                    case 0:
                        menuChoice = MainMenu();
                        break;
                    case 1:
                        menuChoice = CreateContact();
                        break;
                    case 3:
                        menuChoice = ShowAllContacts();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
            }
        }
    
    
    
        int MainMenu()
        {
            string menu = "\n" +
                          "*** Main menu ***" +
                          "\n" +
                          "[1]: Create Contact\n" +
                          "[2]: Show all contacts\n" +
                          "[3]: Find contact\n" +
                          "[4]: Update contact\n" +
                          "[5]: Remove contact\n";
            
            Console.WriteLine(menu);
            string choice = Console.ReadLine();

            try
            {
                return int.Parse(choice);
            }
            catch
            {
                Console.WriteLine("[-] Something is wrong, please try again\n");
                return 0;
            }
        }
        
        int CreateContact()
        {
            string banner = "\n" +
                          "*** Create contact ***" +
                          "\n";
            
            Console.WriteLine(banner);
            Console.WriteLine("Person name:");
            string name = Console.ReadLine();

            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            
            Console.WriteLine("Address");
            string address = Console.ReadLine();
            
            Console.WriteLine("Phone number");
            string phoneNumber = Console.ReadLine();
            
            try
            {
                _contactController.CreatePerson(name:name, address: address, email: email, phoneNumber: phoneNumber);
                return 0;
            }
            catch
            {
                Console.WriteLine("[-] Something is wrong, please try again\n");
                return 0;
            }
        }
        
        int ShowAllContacts()
        {
            string banner = "\n" +
                            "*** Show all contacts ***" +
                            "\n";
            
            Console.WriteLine(banner);

            try
            {
                List<Person> persons = _contactController.GetAllPersons();
                foreach (var person in persons)
                {
                    Console.WriteLine(person.ToString());
                }

                return 0;
            }
            catch
            {
                Console.WriteLine("[-] Something is wrong, please try again\n");
                return 0;
            }
        }
    }
}