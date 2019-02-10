using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {

        public string NurseSalary = ("50,000");

        public Nurse()
        {
        }

        public void AddNurse()
        {
           
        }

        public void NurseGetsPaid()
        {
            Console.WriteLine("Here is $50,000.");
        }

        public void CheckBloodLevel()
        {
            Console.WriteLine("The nurse checked the patients blood");
        }

        public override void EmployeeStatus()
        {
            base.EmployeeStatus();

            Console.WriteLine("Employee Name:  " + Name);
            Console.WriteLine("Employee ID Number:  " + EmployeeNumber);
            Console.WriteLine("Salary:  " + Salary);
            Console.WriteLine("Paid:  " + GotPaid);
        }

    }
}
