using System;
using System.Collections.Generic;

namespace rest_reserv.Data.Model
{
    public partial class ListingLog
    {
        public int ListingLogId { get; set; }
        public int ListingId { get; set; }
        public int Version { get; set; }
        public string ListingImgPath { get; set; }
        public string ListingTitle { get; set; }
        public decimal ListingRating { get; set; }
        public string ListingDescription { get; set; }
        public string ListingPhone { get; set; }
        public string ListingSite { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }

        public virtual Listing Listing { get; set; }
    }
}
