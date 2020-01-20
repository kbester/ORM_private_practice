using System;
using System.Collections.Generic;

namespace Private_Practice.Models
{
    public class Doctor : Person
    {
        public Guid PersonId { get; set; }
        public Guid DoctorId { get; set; }
        public string Specialist { get; set; }
        //Set from dictionary
        public string CountryCode { get; set; }
    }
}