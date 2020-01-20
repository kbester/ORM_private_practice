using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Private_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }

    interface IPerson
    {
        Guid PersonId { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        enum GenderChoice { get; set; }
        int IdNumber { get; set; }
        string Email { get; set; }
        int ContactNo { get; set; }
        bool Active { get; set; }
    }

    class Doctor : IPerson
    {
        public Guid PersonId { get; set; }
        Guid DoctorId { get; set; }
        string Specialist { get; set; }
        //Set from dictionary
        string CountryCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public enum GenderChoice { get; set; }
        public int IdNumber { get; set; }
        public string Email { get; set; }
        public int ContactNo { get; set; }
        public bool Active { get; set; }
    }



    class Client : IPerson
    {
        public Guid ClientId { get; set; }
        public Guid PersonId { get; set; }
        public string IllnessId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public enum GenderChoice { get; set; }
        public int IdNumber { get; set; }
        public string Email { get; set; }
        public int ContactNo { get; set; }
        public bool Active { get; set; }

    }

    class Visits
    {
        Guid VisitId { get; set; }
        Guid DoctorId { get; set; }
        Guid ClientId { get; set; }

    }

    class Illness
    {
        // Pull Illness data from ilness API
        string IllnessId { get; set; }
        string IllnessName { get; set; }
    }
}
