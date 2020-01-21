using Private_Practice.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Private_Practice.DAL
{
    public class PracticeContext : DbContext
    {
        public PracticeContext(DbContextOptions<PracticeContext>Options) : base(Options)
        {
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Illness> Illnesses { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}
