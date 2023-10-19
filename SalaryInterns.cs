using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using A2;

namespace A2
{
    class SalaryInterns : Staff //Creates a new class called "SalaryInterns" that inherits from the "Staff" class. 
    {
        //defines a public property 
        public int Id { get; private set; }
        public int OvertimePay { get; set; }
        public int SalaryDeductions { get; set; }
        public SalaryInterns()
        {
            Id = GenerateInternID(); // Automatically generate Intern ID
        }
        private static int InternIDCounter = 1; //used to create a static counter for the IDs of salary interns
        private int GenerateInternID() //private method that generates a unique ID for a salary intern.
        {
            return InternIDCounter++;//increments the "InternIDCounter" variable by 1 and returns the new value.
        }
        public new void Input() //Create code to enter information
        {
            base.Input();
            Console.Write("Enter OvertimePay: ");
            OvertimePay = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary Deductions: ");
            SalaryDeductions = int.Parse(Console.ReadLine());
        } 
        public override string ToString()
        {
            return $"Intern's ID: I{Id}\n{base.ToString()} \n+ Basic Salary: 3000$ \n+ Overtime Pay: {OvertimePay}$" +
                $"\n+ Salary Deductions: {SalaryDeductions}$\n- TOALT: {3000 + OvertimePay - SalaryDeductions}$ " ;
        }
    }
}
