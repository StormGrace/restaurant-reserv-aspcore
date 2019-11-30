using System;
using System.Collections.Generic;

namespace rest_reserv.Data.Model
{
    public partial class Listing
    {
        public Listing()
        {
            ListingLog = new HashSet<ListingLog>();
            Review = new HashSet<Review>();
            SavedListing = new HashSet<SavedListing>();
        }

        public int ListingId { get; set; }
        public int ReviewCount { get; set; }

        public virtual ICollection<ListingLog> ListingLog { get; set; }
        public virtual ICollection<Review> Review { get; set; }
        public virtual ICollection<SavedListing> SavedListing { get; set; }
    }
}
