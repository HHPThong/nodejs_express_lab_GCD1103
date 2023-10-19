using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    class Staff // base class
    {
        //defines a public property 
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public Staff() { } //a default constructor for the "Staff" class        
        public void Input() //Enter the staff member's full name, age, address, and phone number. This is "base.Input()"
        {
            Console.Write("Enter the employee's full name: ");
            FullName = Console.ReadLine();
            Console.Write("Enter the employee's age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter the employee's address: ");
            Address = Console.ReadLine();
            Console.Write("Enter the employee's phone number: ");
            PhoneNumber = int.Parse(Console.ReadLine());
        }
        //Provide a string representation of the "Staff" object
        public override string ToString()
        {
            //String interpolation expression that returns a string that contains the full name, age, address, and phone number of the `Staff` object.
            return $"\n- Full name: {FullName}\n- Age: {Age}\n- Address: {Address}\n- Phone Number: {PhoneNumber}";
        }
    }
}
