using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops1EmployeeWage
{
    public class CalEmpDailyWage
    {
        public void CalculateWage()
        {

            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            int EmpHrs = 0;
            int EmpWage = 0;

            Random random = new Random();
            int EmpCheck = random.Next(3);

            if (EmpCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Present");
                EmpHrs = 8;
            }
            else if (EmpCheck == IS_PART_TIME)
            {
                Console.WriteLine("Part Time Employee");

                EmpHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee Absent");
                EmpHrs = 0;
            }
            EmpWage = EmpHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("...............");

            Console.WriteLine("Employee Wage is " + EmpWage);
        }
    }
}
