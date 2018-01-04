using System.Collections.Generic;

namespace BandanaPractice.Core
{
    public class OverAllManager
    {
        public List<Employee> permanent = new List<Employee>();
        public List<Employee> temprorary = new List<Employee>();
        public List<Employee> allEmployee;
        public OverAllManager()
        {
            allEmployee = new List<Employee>();
        }
        public List<Employee> GetAllEmployee()
        {
            return allEmployee;
        }
    }
}