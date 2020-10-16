using _1975_PaymentContext.Shared.ValueObjects;
using Flunt.Validations;

namespace _1975_PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            // if (string.IsNullOrEmpty(FirstName))
            //     AddNotification("FirstName", "Nome Inválido");

            // if (string.IsNullOrEmpty(LastName))
            //     AddNotification("LastName", "Sobrenome Inválido");

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 3, "Name.FirstName", "Nome deve conter até 40 caracteres")
                .HasMinLen(LastName, 3, "Name.LastName", "Nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(LastName, 3, "Name.LastName", "Nome deve conter até 40 caracteres")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}