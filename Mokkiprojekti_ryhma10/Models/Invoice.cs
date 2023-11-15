using System;
using System.Collections.Generic;

namespace Mokkiprojekti_ryhma10
{
    public partial class Invoice
    {
        public long InvoiceId { get; set; }
        public long ReservationId { get; set; }
        public double Sum { get; set; }
        public double Vat { get; set; }

        public virtual Reservation Reservation { get; set; } = null!;
        public string Display => ToString();

        public override string ToString()
        {
            return $"{Sum}";
        }
    }
}
