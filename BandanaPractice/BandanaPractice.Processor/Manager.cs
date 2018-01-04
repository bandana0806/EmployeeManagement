using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BandanaPractice.Core;
using BandanaPractice.Contract;
using BandanaPractice.Manager;

namespace BandanaPractice.Processor
{
    public class Manager
    {
        EmployeeTypeFactory factory;
        public Employee employee;
        List<Employee> finalEmployee = new List<Employee>();
        public Manager(Employee emp)
        {
            factory = new EmployeeTypeFactory();
            employee = emp;
        }
        public Boolean Recruit(Employee emp)
        {
            factory.EmployeeFactory(emp).AddEmployee(emp);
            return true;
        }

        public Boolean Suspend(Employee emp)
        {
            factory.EmployeeFactory(emp).RemoveEmployee(emp);
            return true;
        }

        public List<Employee> View(Employee emp)
        {
            finalEmployee = factory.EmployeeFactory(emp).GetAllEmployee();
            return finalEmployee;
        }
    }
}
