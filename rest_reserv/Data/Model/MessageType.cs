using System;
using System.Collections.Generic;

namespace rest_reserv.Data.Model
{
    public partial class MessageType
    {
        public MessageType()
        {
            Message = new HashSet<Message>();
        }

        public int MessageTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Message> Message { get; set; }
    }
}
