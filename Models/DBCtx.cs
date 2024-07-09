using Microsoft.EntityFrameworkCore;

namespace MVCAjax.Models
{
    public class DBCtx : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //use this to configure the context object
            //Configuring the Connection String
            optionsBuilder.UseSqlServer(@"Server=.;Database=EmployeesAPIDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
