using System;
using BandanaPractice.Model;

namespace BandanaPractice
{
    public class Employee
    {
        public string Id { get; private set ; }

        public Name EmployeeName { get; private set; }

        public DateTime Dob { get; private set; }

        public int Age => GetAge();

        public int GetAge()
        {
            return (DateTime.Now.Date.Year - Dob.Date.Year);
        }

        public EmployeeType EmployeeType { get; private set; }

        public Employee(string id, Name employeeName, DateTime date , EmployeeType employeeType)
        {
            this.Id = id;
            this.EmployeeName = employeeName;
            this.Dob = date;
            this.EmployeeType = employeeType;
        }

        public override string ToString()
        {
            return Id + EmployeeName.ToString() + Dob.Date+ GetAge() +EmployeeType;
        }

    }
}
