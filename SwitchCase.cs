using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops1EmployeeWage
{
    public class SwitchCase
    {
        public void SwitchCaseCal()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int NUM_OF_WORKING_DAYS = 20;

            int EmpHrs = 0;
            int EmpWage = 0;
            int MonthWage = 0;

            Random random = new Random();
            int EmpCheck = random.Next(3);

            switch (EmpCheck)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("Full Time Employee");
                    EmpHrs = 8;
                    break;

                case IS_PART_TIME:
                    Console.WriteLine("Part Time Employee");
                    EmpHrs = 4;
                    break;

                default:
                    Console.WriteLine("Employee is Absent");
                    EmpHrs = 0;
                    break;
            }
            EmpWage = EmpHrs * EMP_RATE_PER_HOUR;
            MonthWage = EmpWage * NUM_OF_WORKING_DAYS;

            Console.WriteLine("----------------");
            Console.WriteLine("Employee Daily Wage " + EmpWage);
            Console.WriteLine("----------------");
            Console.WriteLine("Employee Monthly Wage " + MonthWage);
        }
    }
}
