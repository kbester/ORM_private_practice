using System;
using System.Collections.Generic;

namespace Private_Practice.Models
{
    public class Client : Person
    {
        public Guid ClientId { get; set; }
        public Guid PersonId { get; set; }
        public string IllnessId { get; set; }
    }
}