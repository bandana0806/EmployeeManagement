using BandanaPractice.Contract;
using BandanaPractice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandanaPractice.Core
{
    public class TemproraryEmployeeManager:IManager
    {
        public OverAllManager overAllManager;
        public TemproraryEmployeeManager(OverAllManager overAllManager)
        {
            this.overAllManager = overAllManager;
        }

        public void AddEmployee(Employee emp)
        {
            overAllManager.temprorary.Add(emp);
            overAllManager.allEmployee.Add(emp);
        }

        public void RemoveEmployee(Employee emp)
        {
            foreach (var employee in overAllManager.permanent)
            {
                if (emp.Dob == employee.Dob)
                {
                    overAllManager.temprorary.Remove(employee);
                    overAllManager.allEmployee.Remove(employee);
                }
            }
        }
    }
}
