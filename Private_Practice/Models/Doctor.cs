using System;
using System.Collections.Generic;

namespace Private_Practice.Models
{
    public class Doctor : Person
    {
        public Guid PersonId { get; set; }
        Guid DoctorId { get; set; }
        string Specialist { get; set; }
        //Set from dictionary
        string CountryCode { get; set; }
    }
}