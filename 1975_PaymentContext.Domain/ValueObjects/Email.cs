using _1975_PaymentContext.Shared.ValueObjects;

namespace _1975_PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; private set; }
    }
}