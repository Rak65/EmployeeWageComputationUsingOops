using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    public class EmpWageBuilderArray : IEmpWageBuilderArray
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private ArrayList companyEmpWageArrayList;
        private Dictionary<string, CompanyEmpWage> companyEmpWageMap;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArrayList = new ArrayList();
            this.companyEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageArrayList.Add(companyEmpWage);
            this.companyEmpWageMap.Add(company, companyEmpWage);
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageArrayList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            //Variables
            int empHours = 0;
            int totalEmpHrs = 0, totalWorkingDays = 0;

            //Computation
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;
                    case IS_PART_TIME:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                int dailyWage = empHours * companyEmpWage.empRatePerHour;
                totalEmpHrs += empHours;
                Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hrs: " + empHours + " Daily Wage: {0}", dailyWage);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
        public int getTotalWage(string company)
        {
            return this.companyEmpWageMap[company].totalEmpWage;
        }
    }
}
