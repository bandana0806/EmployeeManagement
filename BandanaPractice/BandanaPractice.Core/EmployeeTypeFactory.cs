using BandanaPractice.Contract;
using BandanaPractice.Model;

namespace BandanaPractice.Core
{
    public class EmployeeTypeFactory
    {
        public Employee factoryEmp { get; set; }

        //public EmployeeTypeFactory(Employee emp)
        //{
        //    this.factoryEmp = emp;
        //}
        public static IManager EmployeeFactory(Employee employeeType,OverAllManager overAllManager)
        {
            if (employeeType.EmployeeType == EmployeeType.PermanentEmployee)
            {
                return new PermanentEmployeeManager(overAllManager);
            }
            else
            {
                return new TemproraryEmployeeManager(overAllManager);
            }
        }

    }
}
