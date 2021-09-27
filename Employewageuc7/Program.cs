using System;

namespace Employewageuc7
{
    class Program
    {
       public static void Main(string[] args)
        { }
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonths;
        public int salary;
        public Employewageuc7(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonths)
        { 
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonths = maxHoursPerMonths;
        }

        public Program(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonths, int salary)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonths = maxHoursPerMonths;
            this.salary = salary;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        public string displaySalary()
        {
            return "total Emp wage for company: " + company + " is " + salary;


        }
    }
}
