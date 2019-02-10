using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {

        public string Specialty { get; set; }
        public string Type { get; set; }

        public Doctor()
        {
            Name = "Dr. Pepper";
            EmployeeNumber = 111;
            Specialty = "Heart";
            Salary = 90000;
            Type = "Doctor";
        }

        public void AddDoctor()
        {
        }

        private bool wasExecuted = false;
        public override void PayEmployees()
        {
            if (wasExecuted)
            {
                Console.WriteLine("\nHere is $" + Salary);
            }
            else
            {
                Console.Write("\nDoctor was already paid");
                wasExecuted = true;
            }
        }
        
        public override void EmployeeStatus()
        {
            Console.WriteLine("\n\nEmployee Name:  " + Name);
            Console.WriteLine("Employee ID Number:  " + EmployeeNumber);
            Console.WriteLine("Salary:  " + Salary);
            Console.WriteLine("Paid:  " + GotPaid);
            Console.WriteLine("Position:  " + Type);
            Console.WriteLine("Specialty:  " + Specialty);
            
        }
    }
}




