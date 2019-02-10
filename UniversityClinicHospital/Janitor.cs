using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public bool Sweep { get; set; }
        public string Type { get; set; }
        public bool Paid { get; set; }
       
        public Janitor()
        {
            Name = "Fred";
            EmployeeNumber = 26;
            Salary = 40000;
        }

        public void AddJanitor()
        {
            
        }

        public void JanitorSweeping()
        {
            bool sweep = true;
            if (sweep == true)
            {
                sweep = false;
                Console.WriteLine("The janitor is sweeping");
            }
            else
            {
                sweep = true;
                Console.WriteLine("The janitor is on his break");
            }
        }

        public override void PayEmployees()
        {

            bool Paid = true;
            if (Paid == true)
            {
                Paid = false;
                Console.WriteLine("\nThe janitor got paid $40,000.");
            }
            else
            {
                Paid = true;
                Console.WriteLine("\nThe janitor already got paid.");
            }
        }

        public override void EmployeeStatus()
        {
            Console.WriteLine("\n\nEmployee Name:  " + Name);
            Console.WriteLine("Employee ID Number:  " + EmployeeNumber);
            Console.WriteLine("Salary:  " + Salary);
            Console.WriteLine("Paid:  " + GotPaid);
            Console.WriteLine("What is the janitor doing:  " + Sweep);
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
