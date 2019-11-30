using System;
using System.Collections.Generic;

namespace rest_reserv.Data.Model
{
    public partial class Review
    {
        public Review()
        {
            ReviewActivity = new HashSet<ReviewActivity>();
        }

        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int ListingId { get; set; }
        public sbyte Rating { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Likes { get; set; }
        public DateTime DateVisited { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }

        public virtual Listing Listing { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ReviewActivity> ReviewActivity { get; set; }
    }
}
