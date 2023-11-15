using System;
using System.Collections.Generic;

namespace Mokkiprojekti_ryhma10
{
    public partial class Customer
    {
        public Customer()
        {
            Reservations = new HashSet<Reservation>();
        }

        public long CustomerId { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phonenumber { get; set; }

        public string PostId { get; set; } = null!;
        public virtual Post Post { get; set; } = null!;
        public virtual ICollection<Reservation> Reservations { get; set; }

        public string Display => ToString();

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
