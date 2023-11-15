using System;
using System.Collections.Generic;

namespace Mokkiprojekti_ryhma10
{
    public partial class ReservationService
    {
        public long ReservationId { get; set; }
        public long ServiceId { get; set; }
        public long Amount { get; set; }

        public virtual Reservation Reservation { get; set; } = null!;
        public virtual Service Service { get; set; } = null!;
        public string Display => ToString();

        public override string ToString()
        {
            return $"{ReservationId} {Service.Name} x{Amount}";
        }
    }
}
