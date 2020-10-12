using System;
using _1975_PaymentContext.Domain.Entities;
using _1975_PaymentContext.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1975_PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        private readonly Name _name;
        private readonly Document _document;
        private readonly Email _email;
        private readonly Address _address;
        private readonly Student _student;
        private readonly Subscription _subscription;
        public StudentTests()
        {
            _name = new Name("Flavio", "Zavarise");
            _document = new Document("13120600000", Domain.Enums.EDocumentType.CPF);
            _email = new Email("teste@teste.com.br");
            _address = new Address("Rua tal", "406", "Bairro Tal", "Cidade Tal", "Estado tal", "País Tal", "Zipcode 123");
            _student = new Student(_name, _document, _email);
            _subscription = new Subscription(null);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var payment = new PayPalPayment("123456789", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Flavio Corp", _document, _address, _email);
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenAddSubscription()
        {
            var payment = new PayPalPayment("123456789", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Flavio Corp", _document, _address, _email);
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Valid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenHadSubscriptionNoPayment()
        {
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Invalid);
        }
    }
}