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

        public override void PayEmployees()
        {
            if (Paid == false)
            {
                Paid = true;
                Console.WriteLine("The Doctor got paid $90,000.");
            }
            else
            {
                Console.WriteLine("\nThe Doctor already got paid.");
            }
        }


        public override void EmployeeStatus()
        {
            Console.WriteLine("\n\nEmployee Name:  " + Name);
            Console.WriteLine("Employee ID Number:  " + EmployeeNumber);
            Console.WriteLine("Salary:  " + Salary);
            Console.WriteLine("Paid:  " + Paid);
            Console.WriteLine("Position:  " + Type);
            Console.WriteLine("Specialty:  " + Specialty);
            
        }
    }
}




