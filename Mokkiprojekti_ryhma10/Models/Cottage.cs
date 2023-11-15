using System;
using System.Collections.Generic;

namespace Mokkiprojekti_ryhma10
{
    public partial class Cottage
    {
        public Cottage()
        {
            Reservations = new HashSet<Reservation>();
        }

        public long CottageId { get; set; }


        public string? CottageName { get; set; }
        public string? Address { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public long? AmountOfPeople { get; set; }
        public string? Amenities { get; set; }

        public long AreaId { get; set; }
        public virtual Area Area { get; set; } = null!;

        public string PostId { get; set; } = null!;
        public virtual Post Post { get; set; } = null!;
        public virtual ICollection<Reservation> Reservations { get; set; }
        public string Display => ToString();

        public override string ToString()
        {
            return $"{CottageId} {CottageName}";
        }
    }
}
