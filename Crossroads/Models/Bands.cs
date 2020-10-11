using System;
using System.Collections.Generic;

namespace Crossroads.Models
{
    public partial class Bands
    {
        public int BandId { get; set; }
        public string BandName { get; set; }
        public string Genre { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? PostalCode { get; set; }
    }
}
