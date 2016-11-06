using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Delegate
{
    class DelegateSample2
    {

        //public static void Main(string[] args)
        //{

        //    var employees = new List<Employee>();

        //    employees.Add(new Employee() { ID = 1, Name = "Mr.One", Experience = 3 });
        //    employees.Add(new Employee() { ID = 2, Name = "Mr.Two", Experience = 4 });
        //    employees.Add(new Employee() { ID = 3, Name = "Mr.Three", Experience = 5 });
        //    employees.Add(new Employee() { ID = 4, Name = "Mr.Four", Experience = 6 });

        //    // 把方法(with logic)包成delegate傳過去
        //    var IsEligibleToPromote = new IsPromotable(Promote);

        //    Employee.PromoteEmployee(employees, IsEligibleToPromote);
        //    Console.WriteLine("----------------------");
        //    // Lambda 一行就搞定
        //    Employee.PromoteEmployee(employees, emp => emp.Experience>=5);
        //}

        // Business logic
        public static bool Promote(Employee employee)
        {
            if (employee.Experience >= 5)
                return true;

            return false;
        }

    }

    delegate bool IsPromotable(Employee employee);

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employees, IsPromotable IsEligibleToPromote)
        {
            foreach (var employee in employees)
            {
                if(IsEligibleToPromote(employee))
                    Console.WriteLine(employee.Name+" gets promoted");
            }
        }
    }
}
