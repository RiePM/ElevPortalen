using ElevPortalen.Models;
using Microsoft.EntityFrameworkCore;

namespace ElevPortalen.DBContext
{   //Lavet af Jozsef
    public class PortalDBContext : DbContext
    {
        public PortalDBContext(DbContextOptions<PortalDBContext> options) : base(options)
        {

        }

        public DbSet<StudentModel> Student { get; set; }
        public DbSet<CompanyModel> Commpany { get; set; }
    }
}
