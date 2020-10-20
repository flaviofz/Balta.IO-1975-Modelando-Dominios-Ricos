
using System.Collections.Generic;
using System.Linq;
using _1975_PaymentContext.Domain.Entities;
using _1975_PaymentContext.Domain.Enums;
using _1975_PaymentContext.Domain.Queries;
using _1975_PaymentContext.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1975_PaymentContext.Tests
{
    [TestClass]
    public class StudentQueriesTests
    {
        // Metodologia Red, Green e Refactor
        // Falha, passar e refatorar
        private IList<Student> _students;

        public StudentQueriesTests()
        {
            for (var i = 0; i <= 10; i++)
            {
                _students.Add(
                    new Student(
                        new Name("Aluno", i.ToString()),
                        new Document("1111111111" + i.ToString(), EDocumentType.CPF),
                        new Email(i.ToString() + "@email.com")
                    )
                );
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenDocumentsNotExists()
        {
            var exp = StudentQueries.GetStudent("123123123123");
            var studn = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, studn);
        }

        [TestMethod]
        public void ShouldReturnStudentWhenDocumentsExists()
        {
            var exp = StudentQueries.GetStudent("11111111111");
            var studn = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, studn);
        }
    }
}