using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public bool ReceptionistOnPhone { get; set; }

        public Receptionist()
        {
        }

        public void AddReceptionist()
        {
        }

        public void OnPhone()
        {
            if (ReceptionistOnPhone == true)
            {
                ReceptionistOnPhone = true;
                Console.WriteLine("The receptionist can help you");
            }
            else
            {
                ReceptionistOnPhone = false;
                Console.WriteLine("The receptionist is talking to her boyfriend");

            }
        }

        public void GetsPaid()
        {
            Console.WriteLine("Here is $45,000.");
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
