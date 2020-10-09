using System.Collections.Generic;
using System.Linq;
using _1975_PaymentContext.Domain.ValueObjects;
using _1975_PaymentContext.Shared.Entities;

namespace _1975_PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Adress { get; private set; }
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