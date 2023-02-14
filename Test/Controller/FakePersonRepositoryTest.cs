using ContactsBookTDD.Controller;
using NUnit.Framework;

namespace Test.Controller
{
    public class FakePersonRepositoryTest
    {
        private FakePersonRepository _repository = new FakePersonRepository();

        [Test]
        public void Add_OnSuccess_PersonIsAppliedToRepository()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void Add_OnFailure_PersonIsNotAppliedToRepository()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void GetAll_RepositoryHasEntities_AllEntitiesAreReturned()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void GetAll_RepositoryHasNoEntities_AnEmptyListIsReturned()
        {
            // TODO: Implement test
        }

        [Test]
        public void GetById_ContactWithIdExists_ContactIsReturned()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void GetById_NoContactWithIdExists_NullIsReturned()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void Update_ContactWithIdExists_ContactWithIdIsUpdated()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void Update_NoContactWithIdExists_NothingHappens()
        {
            // TODO: Implement test
        }

        [Test]
        public void Remove_ContactExists_ContactNoLongerExists()
        {
            // TODO: Implement test
        }
        
        [Test]
        public void Remove_ContactDoesNotExists_NothingChanged()
        {
            // TODO: Implement test
        }
    }
}