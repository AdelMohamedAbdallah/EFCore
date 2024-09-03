using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.PL.Models
{
    internal class DepartmentEntityTypeConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(b => b.DepartmentId);
            builder.Property(b => b.DepartmentId).ValueGeneratedOnAdd()
                .HasAnnotation("SqlServer:Identity", "1, 1");
            builder.Property(b => b.Name).HasMaxLength(15);
            builder.Property(b => b.Name).IsRequired();
        }
    }
}
