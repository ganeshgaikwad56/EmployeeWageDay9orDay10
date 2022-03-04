using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops1EmployeeWage
{
    public class ClassDay8
    {
       public const int IS_FULL_TIME = 1;
       public const int IS_PART_TIME = 2;
       public const int EMP_RATE_PER_HOUR = 20;
       public const int NUM_OF_WORKING_DAYS = 20;
       public const int MAX_HRS_IN_MONTH = 100;

        public void EmployeeWage()
        {
 

            int EmpHrs = 0, TotalEmpHrs = 0, TotalWorkingDays = 0;

            while (TotalEmpHrs <= MAX_HRS_IN_MONTH && TotalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(3);

                switch (EmpCheck)
                {
                    case IS_FULL_TIME:
                        EmpHrs = 8;
                        break;

                    case IS_PART_TIME:
                        EmpHrs = 4;
                        break;

                    default:
                        EmpHrs = 0;
                        break;
                }
                TotalEmpHrs += EmpHrs;
                Console.WriteLine("Days: " + TotalWorkingDays + "Employee Hrs : " + EmpHrs);
            }
            int TotalEmpWage = TotalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage :" + TotalEmpWage);
        }

    }
}
