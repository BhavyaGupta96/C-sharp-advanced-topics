using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsExample
{
    class Employee
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public void Promotion(List<Employee> empList)
        {
            foreach(Employee e in empList)
            {
                if (e.Experience >= 5)
                {
                    Console.WriteLine("{0}", e.Name);
                }
            }
        }
    }
}
