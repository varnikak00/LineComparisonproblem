﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Employeewageuc5
{
    class Employeecs : EmployeecsBase1, EmployeecsBase
    {
        public static void () public const int IS_FULL_TIME = 2;

        private int companyCount = 0;
        private CompanyEmpWage[] companyEmpWages;

        public EmpWageBuilder()
        {
            this.companyEmpWages = new CompanyEmpWage[5];
        }

        public void addCompanyEmp(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonths)
        {
            companyEmpWages[this.companyCount] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonths);
            companyCount++;
        }

        //Computing emp wage
        public void computeEmpWage()
        {
            for (int i = 0; i < companyCount; i++)
            {
                companyEmpWages[i].setSalary(this.computeEmpWage(this.companyEmpWages[i]));
                Console.WriteLine(this.companyEmpWages[i].displaySalary());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHour = 0, workingDay = 0, totalHours = 0;
            int empCheck;
            Random random = new Random();
            while (workingDay <= companyEmpWage.numOfWorkingDays && totalHours <= companyEmpWage.maxHoursPerMonths)
            {
                workingDay++;
                empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHour = 8;
                        break;
                    case IS_FULL_TIME:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                totalHours += empHour;
                Console.WriteLine("Day's {0} Emp hours {1}", workingDay, totalHours);
            }
            return totalHours * companyEmpWage.empRatePerHour;

        }
    }
