using _1975_PaymentContext.Domain.Entities;
using _1975_PaymentContext.Domain.Enums;
using _1975_PaymentContext.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1975_PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        // Metodologia Red, Green e Refactor
        // Falha, passar e refatorar
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var doc = new Document("19615253000106", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            var doc = new Document("123", EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        // Serve para fazer vários testes de uma única vez
        [DataTestMethod]
        [DataRow("16329416001")]
        [DataRow("69514067070")]
        [DataRow("49511084020")]
        public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
        }
    }
}