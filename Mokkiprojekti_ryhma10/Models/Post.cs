using System;
using System.Collections.Generic;

namespace Mokkiprojekti_ryhma10
{
    public partial class Post
    {
        public Post()
        {
            Cottages = new HashSet<Cottage>();
            Customers = new HashSet<Customer>();
        }

        public string PostalCode { get; set; } = null!;
        public string? PostOffice { get; set; }

        public virtual ICollection<Cottage> Cottages { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }


        public string Display { get { return ToString(); } }
        public override string ToString() { return $"{PostalCode} {PostOffice}"; }
    }
}
