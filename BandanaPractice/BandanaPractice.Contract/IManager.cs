using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandanaPractice.Contract
{
    public interface IManager
    {
        void AddEmployee(Employee emp);

        void RemoveEmployee(Employee emp);

    }
}
