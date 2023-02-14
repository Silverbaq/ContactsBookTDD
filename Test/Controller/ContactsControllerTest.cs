using ContactsBookTDD.Controller;
using NUnit.Framework;

namespace Test.Controller
{
    public class ContactsControllerTest
    {
        private ContactsController _contactsController = new ContactsController();
        
        [Test]
        public void CreatePerson_OnSuccess_PersonHasBeenApplied()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void CreatePerson_OnSuccess_PersonHasBeenGivenAnId()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void CreatePerson_OnFail_PersonIsNotApplied()
        {
            // TODO: Implement test
        }

        [Test]
        public void FindPerson_PersonWithNameExists_PersonIsReturned()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void FindPerson_NoPersonWithNameExists_NullIsReturned()
        {
            // TODO: Implement test
        }

        [Test]
        public void GetAllPersons_PersonsExists_AllExistingPersonsAreReturned()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void GetAllPersons_NoPersonsExists_AnEmptyListIsReturned()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void UpdatePerson_PersonWithIdExists_PersonIsUpdated()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void UpdatePerson_NoPersonWithIdExists_NothingHappens()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void RemovePerson_PersonWithIdExists_PersonIsRemoved()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void RemovePerson_NoPersonWithIdExists_NothingHasBeenRemoved()
        {
            // TODO: Implement test
        }
    }
}