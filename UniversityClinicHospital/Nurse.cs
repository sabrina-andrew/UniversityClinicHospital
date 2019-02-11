using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        
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
                if (Paid == false)
            {
                Paid = true;
                Console.WriteLine("The Nurse got paid $50,000.");
            }
            else
            {
                Console.WriteLine("\nThe Nurse already got paid.");
            }
        }

        public void CheckBloodLevel()
        {
            Console.WriteLine("\nThe nurse checked the patients blood");
        }

        public override void EmployeeStatus()
        {
            Console.WriteLine("\n\nEmployee Name:  " + Name);
            Console.WriteLine("Employee ID Number:  " + EmployeeNumber);
            Console.WriteLine("Salary:  " + Salary);
            Console.WriteLine("Paid:  " + base.Paid);
            Console.WriteLine("Position: " + Type);
        }
    }
  }
