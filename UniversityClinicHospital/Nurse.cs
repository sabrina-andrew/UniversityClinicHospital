using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        public bool Paid { get; set; }
       

        public Nurse()
        {
        }

        public void AddNurse()
        {
           
        }

        public void NurseGetsPaid()
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
            Console.WriteLine("Employee Name:  " + Name);
            Console.WriteLine("Employee ID Number:  " + EmployeeNumber);
            Console.WriteLine("Salary:  " + Salary);
            Console.WriteLine("Paid:  " + GotPaid);
        }

    }
}
