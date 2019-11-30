using System;
using System.Collections.Generic;

namespace rest_reserv.Data.Model
{
    public partial class SavedListing
    {
        public int SavedListingId { get; set; }
        public int UserId { get; set; }
        public int ListingId { get; set; }
        public bool Active { get; set; }

        public virtual Listing Listing { get; set; }
        public virtual User User { get; set; }
    }
}
