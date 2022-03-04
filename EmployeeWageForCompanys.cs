using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops1EmployeeWage
{
    public class EmployeeWageForCompanys
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int EmpRatePerHour;
        private int NumOfWorkingDays;
        private int MaxHourPerMonth;
        private int totalEmpWage;


        public EmployeeWageForCompanys(string company, int EmpRatePerHour, int NumOfWorkingDays, int MaxHourPerMonth)
        {
            this.company = company;
            this.EmpRatePerHour = EmpRatePerHour;
            this.NumOfWorkingDays = NumOfWorkingDays;
            this.MaxHourPerMonth = MaxHourPerMonth;
        }
        public void ComputeEmpWage()
        {


            int EmpHre = 0, totalWorkinghrs = 0, totalWorkingDays = 0;

            while (totalWorkinghrs <= this.MaxHourPerMonth && totalWorkingDays < this.NumOfWorkingDays)
            {

                totalWorkingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(3);

                switch (EmpCheck)
                {
                    case IS_FULL_TIME:
                        EmpHre = 8;
                        break;
                    case IS_PART_TIME:
                        EmpHre = 4;
                        break;
                    default:
                        EmpHre = 0;
                        break;
                }
                totalWorkinghrs += EmpHre;
                Console.WriteLine("Day#" + totalWorkingDays + " EmpHrs " + EmpHre);
            }
            totalEmpWage = totalWorkinghrs * this.EmpRatePerHour;
            Console.WriteLine("Tota Employee Wage For Company : " + company + " is " + totalEmpWage);
        }
        public string tostring()
            {
                return "Tota Employee Wage For Company : " + this.company + " is " + this.totalEmpWage;
            }
             
         }

    }
  


        


    

