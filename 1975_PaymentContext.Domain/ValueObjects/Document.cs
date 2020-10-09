using _1975_PaymentContext.Domain.Enums;
using _1975_PaymentContext.Shared.ValueObjects;

namespace _1975_PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; set; }
    }
}