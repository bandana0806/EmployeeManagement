using BandanaPractice.Contract;
using BandanaPractice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandanaPractice.Core
{
    class PermanentEmployeeManager : IManager
    {
        public OverAllManager overAllManager;
        public PermanentEmployeeManager(OverAllManager overAllManager)
        {
            this.overAllManager = overAllManager;
        }
       
        public void AddEmployee(Employee emp)
        {
                overAllManager.permanent.Add(emp);
            overAllManager.allEmployee.Add(emp);
        }

        public void RemoveEmployee(Employee emp)
        {
            foreach(var employee in overAllManager.permanent)
            {
                if (emp.Dob == employee.Dob)
                {
                    overAllManager.permanent.Remove(employee);
                    overAllManager.allEmployee.Remove(employee);
                }
            }
        }
    }
}
