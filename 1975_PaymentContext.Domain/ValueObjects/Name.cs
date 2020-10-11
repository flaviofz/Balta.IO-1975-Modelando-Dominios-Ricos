using _1975_PaymentContext.Shared.ValueObjects;

namespace _1975_PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if (string.IsNullOrEmpty(FirstName))
                AddNotification("FirstName", "Nome Inválido");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}