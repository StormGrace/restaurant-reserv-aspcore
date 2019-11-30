using System;
using System.Collections.Generic;

namespace rest_reserv.Data.Model
{
    public partial class ActivityType
    {
        public ActivityType()
        {
            Activity = new HashSet<Activity>();
        }

        public int ActivityTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Activity> Activity { get; set; }
    }
}
