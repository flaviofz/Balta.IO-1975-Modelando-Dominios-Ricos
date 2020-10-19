using System;
using _1975_PaymentContext.Domain.Commands;
using _1975_PaymentContext.Domain.Entities;
using _1975_PaymentContext.Domain.Enums;
using _1975_PaymentContext.Domain.Handlers;
using _1975_PaymentContext.Domain.ValueObjects;
using _1975_PaymentContext.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1975_PaymentContext.Tests
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        // Metodologia Red, Green e Refactor
        // Falha, passar e refatorar
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());

            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Flavio";
            command.LastName = "Zavarise";
            command.Document = "99999999999";
            command.Type = EDocumentType.CPF;
            command.Email = "flaviofz@gmail.com";
            command.BarCode = "123123";
            command.BoletoNumber = "123312";
            command.PaymentNumber = "321123";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "Flavio's";
            command.PayerDocument = "321321";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "flaviofz@gmail.com";
            command.Street = "street";
            command.Number = "number";
            command.Neighborhood = "Neighborhood";
            command.City = "city";
            command.State = "state";
            command.Country = "country";
            command.ZipCode = "zipcode";

            handler.Handler(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}