using EFCore.PL.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.PL.Connection
{
    public class ApplecationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder option) =>
            option.UseSqlServer("Data Source=DESKTOP-L558MLK;Initial Catalog = EFCore ;Integrated Security=True;Trust Server Certificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new EmployeeEntityTypeConfiguration().Configure(modelBuilder.Entity<Employee>());
            new DepartmentEntityTypeConfiguration().Configure(modelBuilder.Entity<Department>());
            modelBuilder.Entity<Employee>()
                .HasOne(emp => emp.Department)
                .WithMany(emp => emp.Employees)
                .HasForeignKey(emp => emp.DepartmentId);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
