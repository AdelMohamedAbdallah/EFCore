
namespace EFCore.PL.Models
{
    public class Department
    {
        public byte DepartmentId { get; set; }
        public string? Name { get; set; }
        public virtual List<Employee> Employees { get; set; } = null!;

        public override bool Equals(object? obj)
        {
            return obj is Department department &&
                   DepartmentId == department.DepartmentId &&
                   Name == department.Name &&
                   EqualityComparer<List<Employee>?>.Default.Equals(Employees, department.Employees);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 13 + DepartmentId.GetHashCode();
            if (Name is null)
                return hash;
            hash = hash * 13 + Name.GetHashCode();
            if (Employees is null)
                return hash;
            hash = hash * 13 + Employees.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            return $"{DepartmentId}\t{Name}";
        }
    }
}
