using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    public class EmpWageBuilderObject
    {
        const int IS_FUL_TIME = 1;
        const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            int dayHour = 0;
            int totalHours = 0;
            int totalWorkingDays = 0;
            while (totalHours < this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FUL_TIME:
                        dayHour = 8;
                        break;
                    case IS_PART_TIME:
                        dayHour = 4;
                        break;
                    default:
                        dayHour = 0;
                        break;

                }
                totalHours += dayHour;
                Console.WriteLine("Day# " + totalWorkingDays + " Employee hours = " + dayHour);
            }
            int totalEmpWage = totalHours * this.empRatePerHour;
            Console.WriteLine("Total Employee wage for company = " + company + " is " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Employee wage for company = " + company + " is " + totalEmpWage;
        }
    }
}
