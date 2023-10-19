using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using A2;

namespace A23
{
    class program
    {
        static void Main(string[] args)
        {            
            List<Staff> employee = new List<Staff>(); //used to create a new list of Staff objects.
            Console.Write("Input the number of people: ");            
            int number = int.Parse(Console.ReadLine()); //Used to enter the number of employees to be imported.
            for (int i = 0; i < number; i++) //Create a loop to enter information for each employee.
            {
                Console.WriteLine("Enter 1 for a Intern, 2 for a Official Employee, or 3 for a Long-time Employee:");
                Console.WriteLine();
                Console.WriteLine("1. Interns have a basic salary of $3,000. They have overtime and salary deductions, but no bonuses.");
                Console.WriteLine();
                Console.WriteLine("2. Official employees have a basic salary of $4,000. They have overtime pay, salary deductions and bonuses.");
                Console.WriteLine();
                Console.WriteLine("3. Long-term employees receive a basic salary calculated on an annual basis. They are overtime pay, salary deductions and bonuses.");
                Console.WriteLine();
                int choice = int.Parse(Console.ReadLine());//Used to enter employee level selection.                
                Staff staff = new Staff(); //Used to create a new Staff object.                
                if (choice == 1)//Enter 1 to choose to enter information for interns.
                {
                    //Means that the "staff" variable is now a "SalaryInterns" object.
                    staff = new SalaryInterns();
                    //Casts the "staff" object to a "SalaryInterns" object and then calls the "Input()" method on the "SalaryInterns" object.
                    ((SalaryInterns)staff).Input();                    
                    employee.Add(staff);//Add the "staff" object to the "employee" list
                }                
                else if (choice == 2) //Enter 2 to choose to enter information for Official Employee.
                {
                    //Means that the "staff" variable is now a "SalaryOfficialEmployees" object.
                    staff = new SalaryOfficialEmployees();
                    //Casts the "staff" object to a "SalaryInterns" object and then calls the "Input()" method on the "SalaryOfficialEmployees" object.
                    ((SalaryOfficialEmployees)staff).Input();                    
                    employee.Add(staff);//Add the "staff" object to the "employee" list
                }                
                else if (choice == 3) //Enter 3 to choose to enter information for Long-time Employee.
                {
                    //Means that the "staff" variable is now a "SalaryLong_timeEmployees" object.
                    staff = new SalaryLong_timeEmployees();
                    //Casts the "staff" object to a "SalaryInterns" object and then calls the "Input()" method on the "SalaryLong_timeEmployees" object.
                    ((SalaryLong_timeEmployees)staff).Input();                    
                    employee.Add(staff);//Add the "staff" object to the "employee" list
                }
                else//Entering numbers other than 1,2 and 3 will display "Invalid selection".
                {
                    Console.WriteLine("Invalid choice.");
                    continue;
                }
            }
            Console.Clear();
            // Creates a new list of "Staff" objects that is sorted by the "FullName" property in ascending order. 
            List<Staff> sortedList = employee.OrderBy(p => p.FullName).ToList();
            Console.WriteLine();
            Console.WriteLine("List of Interns");
            Console.WriteLine();
            // Iterates through the "employee" list and returns only the "Staff" objects that are instances of the "SalaryInterns" class.
            foreach (Staff p in employee.Where(p => p is SalaryInterns))
            {
                Console.WriteLine(p);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("List of Official Employees");
            Console.WriteLine();
            // Iterates through the "employee" list and returns only the "Staff" objects that are instances of the "SalaryOfficialEmployees" class.
            foreach (Staff p in employee.Where(p => p is SalaryOfficialEmployees))
            {
                Console.WriteLine(p);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("List of Long_time Employees");
            Console.WriteLine();
            // Iterates through the "employee" list and returns only the "Staff" objects that are instances of the "SalaryLong-timeEmployees" class.
            foreach (Staff p in employee.Where(p => p is SalaryLong_timeEmployees))
            {
                Console.WriteLine(p);
                Console.WriteLine();
            }
        }
    }
}