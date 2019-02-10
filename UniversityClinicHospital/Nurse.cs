using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        public bool Paid { get; set; }
        public string Type { get; set; }
       

        public Nurse()
        {
            Name = "Christine";
            EmployeeNumber = 1;
            Salary = 50000;
            Type = "Nurse";
        }

        public void AddNurse()
        {
           
        }

        public override void PayEmployees()
        {

            bool Paid = true;
            if (Paid == true)
            {
                Paid = false;
                Console.WriteLine("The Nurse got paid $50,000.");
            }
            else
            {
                Paid = true;
                Console.WriteLine("The Nurse already got paid.");
            }
        }

        public void CheckBloodLevel()
        {
            Console.WriteLine("The nurse checked the patients blood");
        }

        public override void EmployeeStatus()
        {
            Console.WriteLine("\nEmployee Name:  " + Name);
            Console.WriteLine("Employee ID Number:  " + EmployeeNumber);
            Console.WriteLine("Salary:  " + Salary);
            Console.WriteLine("Paid:  " + GotPaid);
            Console.WriteLine("Position: " + Type);
        }
    }
  }
