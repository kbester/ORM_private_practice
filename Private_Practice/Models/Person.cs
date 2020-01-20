using System;
using System.Collections.Generic;

namespace Private_Practice.Models
{
    public enum Gender { Male, Female, Other }
    interface IPerson
    {
        Guid PersonId { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        Gender? Gender { get; set; }
        int IdNumber { get; set; }
        string Email { get; set; }
        int ContactNo { get; set; }
        bool Active { get; set; }
    }
}