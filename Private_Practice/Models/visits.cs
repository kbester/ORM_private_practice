using System;
using System.Collections.Generic;

namespace Private_Practice.Models
{
    public class Visits
    {
        Guid VisitId { get; set; }
        Guid DoctorId { get; set; }
        Guid ClientId { get; set; }

    }
}