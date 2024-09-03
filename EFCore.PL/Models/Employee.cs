
namespace EFCore.PL.Models
{
    public class Employee : IComparable<Employee>
    {

        public byte EmployeeId { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public decimal Salary { get; set; }
        public decimal NewSalary { get; set; }
        public byte DepartmentId { get; set; }
        public virtual Department Department { get; set; } = null!;

        public int CompareTo(Employee? employee)
        {
            if (employee is null)
                return 1;
            return EmployeeId.CompareTo(employee.EmployeeId);
        }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   EmployeeId == employee.EmployeeId &&
                   FName == employee.FName &&
                   LName == employee.LName &&
                   PhoneNumber == employee.PhoneNumber &&
                   Email == employee.Email &&
                   Salary == employee.Salary &&
                   NewSalary == employee.NewSalary &&
                   DepartmentId == employee.DepartmentId &&
                   EqualityComparer<Department?>.Default.Equals(Department, employee.Department);
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(EmployeeId);
            hash.Add(FName);
            hash.Add(LName);
            hash.Add(PhoneNumber);
            hash.Add(Email);
            hash.Add(Salary);
            hash.Add(NewSalary);
            hash.Add(DepartmentId);
            hash.Add(Department);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return $"{EmployeeId}\t" +
                        $"{FName}\t" +
                        $"{LName}\t" +
                        $"{PhoneNumber}\t" +
                        $"{Salary}\t" +
                        $"{NewSalary:f}\t" +
                        $"{Email}";
        }
    }
}
