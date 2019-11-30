using System;
using System.Collections.Generic;

namespace rest_reserv.Data.Model
{
    public partial class Activity
    {
        public Activity()
        {
            ReviewActivity = new HashSet<ReviewActivity>();
        }

        public int ActivityId { get; set; }
        public int UserId { get; set; }
        public int ActionTypeId { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual ActivityType ActionType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ReviewActivity> ReviewActivity { get; set; }
    }
}
