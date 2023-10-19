using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    class SalaryOfficialEmployees: Staff //Creates a new class called "SalaryOfficialEmployees" that inherits from the "Staff" class. 
    {
        //defines a public property 
        int year;
        public int Id { get; private set; }
        public int OvertimePay { get; set; }
        public int SalaryDeductions { get; set; }
        public int Bonus { get; set; }

        public SalaryOfficialEmployees()
        {
            Id = GenerateOfficialEmployeeID(); // Automatically Generate Official Employee ID
        }
        private static int OfficialEmployeeIDCounter = 1; //used to create a static counter for the IDs of salary Official Employee
        private int GenerateOfficialEmployeeID() //private method that generates a unique ID for a salary Official Employees .
        {
            return OfficialEmployeeIDCounter++;//increments the "OfficialEmployeesIDCounter" variable by 1 and returns the new value
        }
        public new void Input()//Create code to enter information
        {
            base.Input();
            Console.Write("Enter length of time worked (less than 5 years): ");
            year = int.Parse(Console.ReadLine());//enter year
            while (year > 4) //Continuously prompt the user to enter a working period until the user enters less than 5.
            {
                Console.Write("Enter length of time worked (less than 5 years): ");
                year = int.Parse(Console.ReadLine());
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
            return $"Official Employee's ID: OE{Id}\n{base.ToString()}\n- Years of service: {year} \n- Basic Salary: 4000$ \n+ Overtime Pay: {OvertimePay}$" +
                $"\n+ Salary Deductions: {SalaryDeductions}$ \n+ Bonus: {Bonus}$\n+ Total: {4000 + OvertimePay - SalaryDeductions + Bonus}$ ";
        }
    }
}
