using System;
using System.Collections.Generic;

namespace Private_Practice.Models
{
    class Doctor : IPerson
    {
        public Guid PersonId { get; set; }
        Guid DoctorId { get; set; }
        string Specialist { get; set; }
        //Set from dictionary
        string CountryCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender? Gender { get; set; }
        public int IdNumber { get; set; }
        public string Email { get; set; }
        public int ContactNo { get; set; }
        public bool Active { get; set; }
    }
}