using _1975_PaymentContext.Domain.Services;

namespace _1975_PaymentContext.Tests.Mocks
{
    public class FakeEmailService : IEmailService
    {
        public void Send(string to, string email, string subject, string body)
        {

        }
    }
}