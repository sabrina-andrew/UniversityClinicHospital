using System;
using System.Collections.Generic;

namespace UniversityClinicHospital
{
    public class Program
    {
   
        public static string Name { get; private set; }
        public static string Age { get; private set; }

        static void Main(string[] args)
        {
            MainMenu();
        }
        private static void MainMenu()
        {

            Doctor doctor = new Doctor();
            Nurse nurse = new Nurse();
            Janitor janitor = new Janitor();
            Receptionist receptionist = new Receptionist();
            Patient patient = new Patient();
       
            bool run = true;

            do
            { 
                Console.WriteLine("Hospital Menu");
                Console.WriteLine("Press 1 to have the doctor care for the patient");
                Console.WriteLine("Press 2 to have the nurse care for the patient");
                Console.WriteLine("Press 3 to check patient stats");
                Console.WriteLine("Press 4 to to check employee stats");
                Console.WriteLine("Press 5 to pay the employees");
                Console.WriteLine("Press 6 to interact with the receptionist");
                Console.WriteLine("PRess 7 to interact with the janitor");
                Console.WriteLine("Press 0 to quit");

                string EmployeeOrPatientMenu = Console.ReadLine();

                switch (EmployeeOrPatientMenu)
                {
                    case "0":
                        Console.WriteLine("Stay well, friend");
                        run = false;
                        break;
                    case "1":
                        patient.DrDrewBlood();
                        break;
                    case "2":
                        patient.NurseDrewBlood();
                        break;
                    case "3":
                        patient.Status();
                        break;
                    case "4":
                        doctor.EmployeeStatus();
                        nurse.EmployeeStatus();
                        receptionist.EmployeeStatus();
                        janitor.EmployeeStatus();
                        break;
                    case "5":
                        doctor.PayEmployees();
                        nurse.PayEmployees();
                        receptionist.PayEmployees();
                        janitor.PayEmployees();
                        break;
                    case "6":
                        receptionist.OnPhone();
                        break;
                    case "7":
                        janitor.JanitorSweeping();
                        break;
                }
            } while (run);
        }
    }
}

