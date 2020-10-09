using System.Collections.Generic;
using System.Linq;

namespace _1975_PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscriptions;
        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Adress { get; set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            // Se possuir assinatura ativa cancela

            // Cancela todas as outras assinaturas
            foreach (var sub in Subscriptions)
            {
                //sub.Active = false;
                sub.Inactivate();
            }

            _subscriptions.Add(subscription);
        }
    }
}