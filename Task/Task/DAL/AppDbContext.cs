using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace Task.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<AboutInfo> AboutInfos { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
