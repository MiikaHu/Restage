using System;
using System.Collections.Generic;

namespace Mokkiprojekti_ryhma10
{
    public partial class Reservation
    {
        public Reservation()
        {
            Invoices = new HashSet<Invoice>();
            ReservationServices = new HashSet<ReservationService>();
        }

        public long ReservationId { get; set; }
        public long CustomerId { get; set; }
        public long CottageId { get; set; }
        public DateTime ReservedDate { get; set; }
        public DateTime ConfirmationDate { get; set; }
        public DateTime ReservedStartDate { get; set; }
        public DateTime ReservedEndDate { get; set; }

        public virtual Cottage Cottage { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<ReservationService> ReservationServices { get; set; }
    }
}
