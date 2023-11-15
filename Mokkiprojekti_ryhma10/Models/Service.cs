using System;
using System.Collections.Generic;

namespace Mokkiprojekti_ryhma10
{
    public partial class Service
    {
        public Service()
        {
            ReservationServices = new HashSet<ReservationService>();
        }

        public long ServiceId { get; set; }
        public long AreaId { get; set; }
        public string? Name { get; set; }
        public long? Type { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public double Vat { get; set; }

        public virtual Area Area { get; set; } = null!;
        public virtual ICollection<ReservationService> ReservationServices { get; set; }
    }
}
