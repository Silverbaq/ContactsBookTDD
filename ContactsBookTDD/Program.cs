using ContactsBookTDD.Controller;
using ContactsBookTDD.View;

namespace ContactsBookTDD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContactBook contactBook = new ContactBook();
            contactBook.run();
        }
    }
}