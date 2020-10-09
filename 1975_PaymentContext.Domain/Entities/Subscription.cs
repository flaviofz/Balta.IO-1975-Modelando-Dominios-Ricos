using System;
using System.Collections.Generic;

namespace _1975_PaymentContext.Domain.Entities
{
    public class Subscription
    {
        public DateTime Createdate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        private bool Active { get; set; }
        public List<Payment> Payments { get; set; }
    }
}