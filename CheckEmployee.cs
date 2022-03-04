using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops1EmployeeWage
{
    public class CheckEmployee
    {
        public int IS_FULL_TIME;
        
        public CheckEmployee(int a)
        {
            IS_FULL_TIME = a;
        }
        public void EmployeePresentOrNot()

        {
            // int IS_PART_TIME = 1;
            //int EMP_RATE_PER_HOUR = 20;

            //int EmpHrs = 0;
            //int EmpWage = 0;
            int Employee;
            Random random = new Random();
            Employee = random.Next(2);

            if (Employee == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
        }
    }
}
