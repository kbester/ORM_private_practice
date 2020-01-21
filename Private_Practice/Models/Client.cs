using System;
using System.Collections.Generic;

namespace Private_Practice.Models
{
    public class Client : Person
    {
        public Guid ClientId { get; set; }
        public Guid PersonId { get; set; }
        public Guid IllnessId { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}