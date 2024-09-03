using EFCore.PL.Connection;

namespace EFCore.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new ApplecationDbContext();
            context.Database.EnsureCreated();
            var employees = context.Employees;
            var departments = context.Departments;
            //var emps = new List<Employee>
            //{
            //    new Employee{FName="Adel",LName="Mohamed",PhoneNumber = "01082254939",Email="adel@gmail.com",Salary = 3000m ,DepartmentId = 1},
            //    new Employee{FName="Ali",LName="Said",PhoneNumber = "01143254976",Email="ali@gmail.com",Salary = 4000m,DepartmentId = 4},
            //    new Employee{FName="Ahmed",LName="Khaled",PhoneNumber = "01003218738",Email="ahmed@gmail.com",Salary = 5000m,DepartmentId = 2},
            //    new Employee{FName="Kamal",LName="Morsey",PhoneNumber = "01143103254",Email="kamal@gmail.com",Salary = 3000m, DepartmentId = 1},
            //    new Employee{FName="Nader",LName="Abas",PhoneNumber = "01543201931",Email="nader@gmail.com",Salary = 2000m , DepartmentId = 3},
            //    new Employee{FName="Maher",LName="Mohamed",PhoneNumber = "01143994997",Email="maher@gmail.com",Salary = 6000m , DepartmentId = 3},
            //    new Employee{FName="Emad",LName="Hamdy",PhoneNumber = "01043259170",Email="emad@gmail.com",Salary = 8000m , DepartmentId = 2},
            //    new Employee{FName="Saad",LName="Ali",PhoneNumber = "01143232132",Email="saad@gmail.com",Salary = 1000m , DepartmentId = 2},
            //    new Employee{FName="Mariam",LName="Kamal",PhoneNumber = "01199254935",Email="mariam@gmail.com",Salary = 7000m , DepartmentId = 4},
            //    new Employee{FName="Mona",LName="Zaky",PhoneNumber = "01043200910",Email="mona@gmail.com",Salary = 2000m , DepartmentId = 3},
            //    new Employee{ FName = "Ahmed", LName = "Hassan", PhoneNumber = "01012345678", Email = "ahmed.hassan@example.com", Salary = 2500m, DepartmentId = 2 },
            //    new Employee{ FName = "Laila", LName = "Saad", PhoneNumber = "01087654321", Email = "laila.saad@example.com", Salary = 3000m, DepartmentId = 4 },
            //    new Employee{ FName = "Khaled", LName = "Ali", PhoneNumber = "01009876543", Email = "khaled.ali@example.com", Salary = 2200m, DepartmentId = 1 },
            //    new Employee{ FName = "Salma", LName = "Youssef", PhoneNumber = "01056473829", Email = "salma.youssef@example.com", Salary = 2800m, DepartmentId = 4 },
            //    new Employee{ FName = "Yasser", LName = "Mohamed", PhoneNumber = "01019283746", Email = "yasser.mohamed@example.com", Salary = 2700m, DepartmentId = 3 },
            //    new Employee{ FName = "Sara", LName = "Nasser", PhoneNumber = "01029384756", Email = "sara.nasser@example.com", Salary = 2400m, DepartmentId = 2 },
            //    new Employee{ FName = "Omar", LName = "Hussein", PhoneNumber = "01038475692", Email = "omar.hussein@example.com", Salary = 2600m, DepartmentId = 4 },
            //    new Employee{ FName = "Nadia", LName = "Fahmy", PhoneNumber = "01047586921", Email = "nadia.fahmy@example.com", Salary = 3200m, DepartmentId = 1 },
            //    new Employee{ FName = "Mohamed", LName = "Ibrahim", PhoneNumber = "01059638274", Email = "mohamed.ibrahim@example.com", Salary = 3100m, DepartmentId = 2 },
            //    new Employee{ FName = "Fatma", LName = "Kamel", PhoneNumber = "01067849305", Email = "fatma.kamel@example.com", Salary = 3300m, DepartmentId = 1 },
            //    new Employee{ FName = "Ali", LName = "Ahmed", PhoneNumber = "01078956432", Email = "ali.ahmed@example.com", Salary = 2900m, DepartmentId = 3 },
            //    new Employee{ FName = "Reem", LName = "Salem", PhoneNumber = "01089067543", Email = "reem.salem@example.com", Salary = 3500m, DepartmentId = 2 },
            //    new Employee{ FName = "Tamer", LName = "Gad", PhoneNumber = "01090178654", Email = "tamer.gad@example.com", Salary = 2100m, DepartmentId = 4 },
            //    new Employee{ FName = "Dina", LName = "Mahmoud", PhoneNumber = "01001234567", Email = "dina.mahmoud@example.com", Salary = 2900m, DepartmentId = 1 },
            //    new Employee{ FName = "Hassan", LName = "Sayed", PhoneNumber = "01012345098", Email = "hassan.sayed@example.com", Salary = 2700m, DepartmentId = 2 },
            //    new Employee{ FName = "Manal", LName = "Fouad", PhoneNumber = "01023456109", Email = "manal.fouad@example.com", Salary = 3100m, DepartmentId = 1 },
            //    new Employee{ FName = "Adel", LName = "Younes", PhoneNumber = "01034567210", Email = "adel.younes@example.com", Salary = 2800m, DepartmentId = 1 },
            //    new Employee{ FName = "Mona", LName = "Gaber", PhoneNumber = "01045678321", Email = "mona.gaber@example.com", Salary = 2600m, DepartmentId = 3 },
            //    new Employee{ FName = "Hisham", LName = "Amin", PhoneNumber = "01056789432", Email = "hisham.amin@example.com", Salary = 3400m, DepartmentId = 4 },
            //    new Employee{ FName = "Nour", LName = "Saleh", PhoneNumber = "01067890543", Email = "nour.saleh@example.com", Salary = 2300m, DepartmentId = 1 }
            //};


            //context.Employees.AddRange(emps);

            //var departs = new List<Department>
            //{
            //    new Department{Name = "Sales" },
            //    new Department{Name = "Purchases" },
            //    new Department{Name = "Accountancy" },
            //    new Department{Name = "Credenza" }
            //};

            //context.Departments.AddRange(departs);






            //var result = employees.OrderBy(emp => emp.FName).LastOrDefault();
            //Console.WriteLine(result);
            //Console.WriteLine("=======================");
            //var result1 = employees.Skip(employees.Count() - 1).Take(1);
            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item);
            //}

            //var result2 = employees.Average(emp => emp.Salary);
            //Console.WriteLine($"{result2:f}");

            //var result3 = employees.Sum(emp => emp.Salary);
            //Console.WriteLine($"{result3:f}");

            //var result4 = employees.Count(emp => emp.Salary > 2000);
            //Console.WriteLine($"{result4}");

            //var result5 = employees.Max(emp => emp.Salary);
            //Console.WriteLine(result5);

            //var result6 = employees.ToList().MaxBy(emp => emp.Salary);
            //Console.WriteLine(result6);

            //var result7 = employees.ToList().Max();
            //Console.WriteLine(result7);

            //var result5 = employees.Min(emp => emp.Salary);
            //Console.WriteLine(result5);

            //var result6 = employees.ToList().MinBy(emp => emp.Salary);
            //Console.WriteLine(result6);

            //var result7 = employees.ToList().Min();
            //Console.WriteLine(result7);

            //employees.ToList().ForEach(item =>
            //{
            //    if (item.Email is null)
            //        item.Email = "Null";
            //    Console.WriteLine(item);
            //});

            //Console.WriteLine("======================");
            //var result8 = employees.ToList().DistinctBy(emp => emp.Salary);

            //foreach (var item in result8)
            //{
            //    Console.WriteLine(item);
            //}



            //var result = employees.AsNoTracking().ToList().GroupBy(emp => emp.DepartmentId).OrderByDescending(emp => emp.Count()).FirstOrDefault();
            //if (result == null)
            //    return;
            //Console.WriteLine($"{result.Key} => \"{departments.SingleOrDefault(dept => dept.DepartmentId == result.Key)?.Name}\"");
            //foreach (var item in result.ToList())
            //{
            //    Console.WriteLine(item);
            //}

            //context.SaveChanges();

            // [1] Eager loading
            //var result = employees.Include(emp => emp.Department).AsNoTracking().Where(emp => emp.Salary > 3000);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Department?.Name);
            //}

            //[2] Explicit loading by referenc
            //var result = employees.AsNoTracking().FirstOrDefault(emp => emp.Salary == 3000);
            //context.Entry(result).Reference(emp => emp.Department).Load();
            //Console.WriteLine(result.Department.DepartmentId + " " + result.Department.Name);

            //[2] Explicit loading by Collection
            //var result = departments.AsNoTracking().FirstOrDefault(emp => emp.DepartmentId == 1);
            //context.Entry(result).Collection(emp => emp.Employees).Load();
            //foreach (var item in result.Employees)
            //{
            //    Console.WriteLine(item);
            //}

            // [*] Update 
            //var result = employees.Where(emp => emp.Salary >= 2000 && emp.Salary < 3000).ToList();
            //foreach (var employee in result)
            //{
            //    employee.Salary = 3000m;
            //}
            //context.UpdateRange(result);
            //context.Entry(result).Property(emp => emp).IsModified = true;


            //var findemp = new Employee
            //{
            //    EmployeeId = 49,
            //    LName = "Nabile",
            //};

            //context.Update(findemp);
            //context.Entry(findemp).Property(emp => emp.DepartmentId).IsModified = false;
            //context.Entry(findemp).Property(emp => emp.FName).IsModified = false;
            //context.Entry(findemp).Property(emp => emp.Email).IsModified = false;
            //context.Entry(findemp).Property(emp => emp.Salary).IsModified = false;
            //context.Entry(findemp).Property(emp => emp.PhoneNumber).IsModified = false;
            //employees.ExecuteDelete();

            //employees.Where(emp => emp.Salary < 4000)
            //    .ExecuteUpdate(prop => prop.SetProperty(emp => emp.Salary, emp => 4000m));

            //context.SaveChanges();


            // [*] Transaction....
            //Stopwatch sw = Stopwatch.StartNew();
            //sw.Start();
            //using var transaction = context.Database.BeginTransaction();
            //try
            //{
            //    var result = employees.AsNoTracking().Where(emp => emp.FName == null ? emp.FName == "Null" : emp.FName.StartsWith("a")).ToList();
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    transaction.Commit();
            //}
            //catch
            //{
            //    transaction.Rollback();
            //}
            //sw.Stop();
            //Console.WriteLine($"Operation Time : {sw.ElapsedMilliseconds}ms");





        } // block of Main Method ....
    } // block of Class Program ...
} // block of namespace....
