using System;
using System.Collections.Generic;

namespace rest_reserv.Data.Model
{
    public partial class User
    {
        public User()
        {
            Activity = new HashSet<Activity>();
            Review = new HashSet<Review>();
            SavedListing = new HashSet<SavedListing>();
            UserLog = new HashSet<UserLog>();
        }

        public int UserId { get; set; }
        public int InboxId { get; set; }

        public virtual Inbox Inbox { get; set; }
        public virtual ICollection<Activity> Activity { get; set; }
        public virtual ICollection<Review> Review { get; set; }
        public virtual ICollection<SavedListing> SavedListing { get; set; }
        public virtual ICollection<UserLog> UserLog { get; set; }
    }
}
