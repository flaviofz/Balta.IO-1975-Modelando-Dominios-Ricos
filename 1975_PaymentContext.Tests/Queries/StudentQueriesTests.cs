
using _1975_PaymentContext.Domain.Enums;
using _1975_PaymentContext.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1975_PaymentContext.Tests
{
    [TestClass]
    public class StudentQueriesTests
    {
        // Metodologia Red, Green e Refactor
        // Falha, passar e refatorar
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }
    }
}