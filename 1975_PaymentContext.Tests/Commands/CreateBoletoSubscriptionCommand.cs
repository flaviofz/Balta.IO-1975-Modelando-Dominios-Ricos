using _1975_PaymentContext.Domain.Commands;
using _1975_PaymentContext.Domain.Enums;
using _1975_PaymentContext.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1975_PaymentContext.Tests
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        // Metodologia Red, Green e Refactor
        // Falha, passar e refatorar
        [TestMethod]
        public void ShouldReturnErrorWhenNameIsInvalid()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "";

            command.Validate();
            Assert.AreEqual(false, command.Invalid);
        }
    }
}