using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops1EmployeeWage
{
    public class EmpWageForMultCom
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public void EmpWageForCompanies(string Company, int RatePerHour, int NumofWorkingDays, int MaxHoursPerMonth)
        {
            //Variables

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //Computation

            while(totalEmpHrs<=MaxHoursPerMonth && totalWorkingDays<NumofWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int EmployeeCheck=random.Next(3);

                switch(EmployeeCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days :" + totalWorkingDays + + empHrs + " empHrs");
            }
            int TotalEmpWage = totalEmpHrs * RatePerHour;
            Console.WriteLine("Total Employee Wage for :" + Company + " is " + TotalEmpWage );
        }
    }
}
