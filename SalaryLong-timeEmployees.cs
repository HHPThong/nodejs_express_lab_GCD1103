using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    class SalaryLong_timeEmployees : Staff //Creates a new class called "SalaryLong_timeEmployees" that inherits from the "Staff" class. 
    {
        //defines a public property 
        int year;
        int BasicSalary;
        public int Id { get; private set; }
        public int OvertimePay { get; set; }
        public int SalaryDeductions { get; set; }
        public int Bonus { get; set; }

        public SalaryLong_timeEmployees()
        {
            Id = GenerateSalaryLong_timeEmployeesID(); // Automatically Generate Long_time Employees ID
        }
        private static int SalaryLong_timeEmployeesIDCounter = 1;  //used to create a static counter for the IDs of salary Long_time Employees
        private int GenerateSalaryLong_timeEmployeesID() //private method that generates a unique ID for a Salary Long_time Employees.
        {
            return SalaryLong_timeEmployeesIDCounter++;//increments the "SalaryLong_timeEmployeesIDCounter" variable by 1 and returns the new value
        }
        public new void Input()//Create code to enter information
        {
            base.Input(); //method to get the base class implementation
            Console.Write("Enter length of time worked (5 years or more): ");
            year = int.Parse(Console.ReadLine()); //enter year
            while (year < 5) //Continuously prompt the user to enter a working period until the user enters a number greater than or equal to 5.
            {
                Console.Write("Enter length of time worked (5 years or more): ");
                year = int.Parse(Console.ReadLine());
            }
            if (year > 4 && year < 7)//Enter the number of years of work from 5 to 6 years, the basic salary is $5,000
            {
                BasicSalary = 5000;
            }
            else if (year >= 7 && year < 10) //Enter the number of years of work from 7 to 9 years, the basic salary is $5,500
            {
                BasicSalary = 5500;
            }
            else if (year >= 10) //Enter the number of years worked for 10 years or more, the basic salary is $7,000
            {
                BasicSalary = 7000;
            }
            
            Console.Write("Enter OvertimePay: ");
            OvertimePay = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary Deductions: ");
            SalaryDeductions = int.Parse(Console.ReadLine());
            if (SalaryDeductions - OvertimePay > 0) //if "SalaryDeductions" - "OvertimePay" is greater than 0, do not enter "Bonus".
            {
                Console.WriteLine("There is no salary bonus this month.");
                Bonus = 0;
            }
            else
            {
                Console.Write("Enter Bonus: ");
                Bonus = int.Parse(Console.ReadLine());
            }
        }
        public override string ToString()
        {
            //returns a formatted string that contains the values of the variables
            return $"Long_time Employees's ID: LE{Id}\n{base.ToString()}\n- Years of service: {year}\n+ Basic Salary: {BasicSalary}$" +
                $"\n+ Overtime Pay: {OvertimePay}$\n+ Salary Deductions: {SalaryDeductions}$ \n+ Bonus: {Bonus}$" +
                $"\n- TOTAL: {BasicSalary + OvertimePay - SalaryDeductions + Bonus}$ ";
        }
    }
}
