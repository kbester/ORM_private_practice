using System;
using System.Collections.Generic;

namespace Private_Practice.Models
{
    public class Visit
    {
        public Guid VisitId { get; set; }
        public Guid DoctorId { get; set; }
        public  Guid ClientId { get; set; }

    }
}