using System;
using System.Collections.Generic;

namespace Mokkiprojekti_ryhma10
{
    public partial class Area
    {
        public Area()
        {
            Cottages = new HashSet<Cottage>();
            Services = new HashSet<Service>();
        }

        public long AreaId { get; set; }
        public string? Name { get; set; }

        public string Display { get { return ToString(); } }
        public override string ToString() { return $"{AreaId} {Name}"; }
        public virtual ICollection<Cottage> Cottages { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
