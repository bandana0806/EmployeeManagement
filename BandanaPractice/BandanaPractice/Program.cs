using BandanaPractice.Contract;
using BandanaPractice.Core;
using BandanaPractice.Model;
using System;

namespace BandanaPractice
{
    public class Registration
    {
        static void Main(string[] a)
        {
            Name name = new Name("Bandana", "mahapatra");
            Name name1 = new Name("Deependra", "Tripathi");
            Employee emp = new Employee("854", name, new DateTime(1994, 11, 02), EmployeeType.PermanentEmployee);
            Employee emp1 = new Employee("894", name1, new DateTime(1994, 11, 02), EmployeeType.TemproraryEmployee);
            Console.WriteLine("HEllo Bandana Give it all .....mmmmmmmmuuuuuuaaaaaahhhhhhhhhh" + emp.ToString());
            Console.WriteLine("HEllo Bandana Give it all .....mmmmmmmmuuuuuuaaaaaahhhhhhhhhh" + emp1.ToString());
            OverAllManager overAllManager = new OverAllManager();
            IManager manager = EmployeeTypeFactory.EmployeeFactory(emp,overAllManager);
            IManager manager1 = EmployeeTypeFactory.EmployeeFactory(emp1, overAllManager);
            manager.AddEmployee(emp);
            manager1.AddEmployee(emp1);
            Console.WriteLine("employees");
            var all = overAllManager.GetAllEmployee();
            foreach (var e in overAllManager.GetAllEmployee())
            {
                Console.WriteLine(e.EmployeeName);
            }
            Console.ReadKey();
        }
    }
}
