using System;
using System.Collections.Generic;

namespace rest_reserv.Data.Model
{
    public partial class Message
    {
        public Message()
        {
            Inbox = new HashSet<Inbox>();
        }

        public int MessageId { get; set; }
        public int MessageTypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }

        public virtual MessageType MessageType { get; set; }
        public virtual ICollection<Inbox> Inbox { get; set; }
    }
}
