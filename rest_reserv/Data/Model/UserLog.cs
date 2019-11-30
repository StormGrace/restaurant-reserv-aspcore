using System;
using System.Collections.Generic;

namespace rest_reserv.Data.Model
{
    public partial class UserLog
    {
        public int UserLogId { get; set; }
        public int UserId { get; set; }
        public int Version { get; set; }
        public byte[] ProfileImg { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }

        public virtual User User { get; set; }
    }
}
