using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    public class EmpWageBuilderArray
    {
        const int IS_FUL_TIME = 1;
        const int IS_PART_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;
        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany]=new CompanyEmpWage (company , empRatePerHour, numOfWorkingDays,maxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0;i<numOfCompany;i++)
            {
                companyEmpWageArray[i].setTotalEmpWage (this.computeEmpWage (this.companyEmpWageArray[i]));
                Console .WriteLine (this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage )
        {
            int dayHour = 0;
            int totalHours = 0;
            int totalWorkingDays = 0;
            while (totalHours < companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
            return totalHours * companyEmpWage.empRatePerHour;
        }
    }
}
