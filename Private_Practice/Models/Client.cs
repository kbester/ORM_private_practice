using System;
using System.Collections.Generic;

namespace Private_Practice.Models
{
    class Client : IPerson
    {
        public Guid ClientId { get; set; }
        public Guid PersonId { get; set; }
        public string IllnessId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender? Gender { get; set; }
        public int IdNumber { get; set; }
        public string Email { get; set; }
        public int ContactNo { get; set; }
        public bool Active { get; set; }

    }
}