using System;
using System.Linq.Expressions;
using _1975_PaymentContext.Domain.Entities;

namespace _1975_PaymentContext.Domain.Queries
{
    public static class StudentQueries
    {
        public static Expression<Func<Student, bool>> GetStudent(string document)
        {
            return x => x.Document.Number == document;
        }
    }
}