using System;
using System.Collections.Generic;

namespace rest_reserv.Data.Model
{
    public partial class ReviewActivity
    {
        public int ActivityLogId { get; set; }
        public int ActivityId { get; set; }
        public int ReviewId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Review Review { get; set; }
    }
}
