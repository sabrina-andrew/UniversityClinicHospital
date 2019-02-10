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
            Name = "Dr Smith";
            EmployeeNumber = 111;
            Specialty = "heart";
        }

        public void AddDoctor()
        {
        }

        private bool wasExecuted = false;
        public void GetsPaid()
        {
            if (wasExecuted)
            {
                Console.WriteLine("Here is $90,000.");
            }
            else
            {
                Console.Write("Doctor was already paid");
                wasExecuted = true;
            }
        }
        
        public override void EmployeeStatus()
        {
            Console.WriteLine("Employee Name:  " + Name);
            Console.WriteLine("Employee ID Number:  " + EmployeeNumber);
            Console.WriteLine("Salary:  " + Salary);
            Console.WriteLine("Paid:  " + GotPaid);
        }
    }
}




