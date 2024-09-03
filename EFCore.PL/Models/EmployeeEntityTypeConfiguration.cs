using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.PL.Models
{
    public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(emp => emp.PhoneNumber).IsRequired(true);
            builder.Property(emp => emp.Salary).IsRequired(true);
            builder.Property(emp => emp.FName).IsRequired(true);
            builder.Property(emp => emp.LName).IsRequired(true);
            builder.Property(emp => emp.Email).IsRequired(false);

            builder.Property(emp => emp.FName).HasMaxLength(10);
            builder.Property(emp => emp.LName).HasMaxLength(10);

            builder.Property(emp => emp.PhoneNumber).HasMaxLength(18);
            builder.Property(emp => emp.Email).HasMaxLength(30);
            builder.Property(emp => emp.Salary).HasColumnType("decimal(10,2)");
            builder.Property(emp => emp.Salary).HasDefaultValue(3000m);
            builder.HasIndex(emp => emp.PhoneNumber).IsUnique();
            builder.Property(emp => emp.NewSalary).HasComputedColumnSql("(([Salary] * 0.05) + [Salary])");
            builder.Property(emp => emp.EmployeeId).HasColumnName("EmployeeId");

            builder.HasKey(emp => emp.EmployeeId);
            builder.Property(emp => emp.EmployeeId).ValueGeneratedOnAdd()
                .HasAnnotation("SqlServer:Identity", "1, 1");

            builder.HasIndex(emp => emp.EmployeeId).HasDatabaseName("IN_EmployeeId");
            builder.ToTable(t => t.HasCheckConstraint("CK_Salary", "[Salary] between 1000 and 8000"));




        }
    }
}
