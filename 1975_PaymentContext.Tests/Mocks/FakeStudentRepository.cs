using _1975_PaymentContext.Domain.Entities;
using _1975_PaymentContext.Domain.Repositories;

namespace _1975_PaymentContext.Tests.Mocks
{
    public class FakeStudentRepository : IStudentRepository
    {
        public void CreateSubscription(Student student)
        {

        }

        public bool DocumentExists(string document)
        {
            if (document == "99999999999")
                return true;

            return false;
        }

        public bool EmailExists(string email)
        {
            if (email == "flaviofz@gmail.com")
                return true;

            return false;
        }
    }
}