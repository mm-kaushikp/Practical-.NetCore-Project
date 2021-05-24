using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class LoginDbContext : DbContext
    {

        public LoginDbContext()
        {
        }

        public LoginDbContext(DbContextOptions<LoginDbContext> options)
            : base(options)
        {
        }
        public DbSet<LoginModel> loginModels { get; set; }
        public DbSet<Registration> registrations { get; set; }
        public DbSet<customerEntery> customerEnteries { get; set; }
        public DbSet<employeInformation> employeInformation { get; set; }
        public DbSet<clientMaster> clientMasters { get; set; }
        public DbSet<departmentReport> departmentReports { get; set; }
        public DbSet<mobileDisplay> mobileDisplays { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Server01,1983;Database=Test;User ID=Test;Password=test;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        }
    }
}
