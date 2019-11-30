using System;
using System.Collections.Generic;

namespace rest_reserv.Data.Model
{
    public partial class Inbox
    {
        public Inbox()
        {
            User = new HashSet<User>();
        }

        public int InboxId { get; set; }
        public int MessageId { get; set; }
        public int MessageCount { get; set; }

        public virtual Message Message { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
