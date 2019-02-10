using System;
using System.Collections.Generic;

namespace UniversityClinicHospital
{
    public class Program
    {
        private static string EmployeeNumber;

        public static string Name { get; private set; }
        public static string specialty { get; private set; }
        public static string Age { get; private set; }

        static void Main(string[] args)
        {
            MainMenu();

        }
        static void MainMenu()
        {

            Doctor doctor = new Doctor();
            Nurse nurse = new Nurse();
            Janitor janitor = new Janitor();
            Receptionist receptionist = new Receptionist();
            Patient patient = new Patient();

            List<Employee> employeeList = new List<Employee>();
            List<Patient> patientList = new List<Patient>();

                Console.WriteLine("Hospital Menu");
                Console.WriteLine("Press 1 to add a doctor");
                Console.WriteLine("Press 2 to add a nurse");
                Console.WriteLine("Press 3 to add a janitor");
                Console.WriteLine("Press 4 to add a receptionist");
                Console.WriteLine("Press 5 to admit a patient");
                Console.WriteLine("Press 0 to quit");

                string addEmployeeOrPatientMenu = Console.ReadLine();

                switch (addEmployeeOrPatientMenu)
                {
                    case "0":
                        Console.WriteLine("Stay well, friend");
                        break;
                    case "1":
                        Console.WriteLine("Please give me the doctor information");
                        Console.WriteLine("What is your doctors name?");
                        Name = Console.ReadLine();
                        Console.WriteLine("What is the doctors specialty?");
                        specialty = Console.ReadLine();
                        Console.WriteLine("What is the employee ID number?");
                        EmployeeNumber = Console.ReadLine();
                        doctor.AddDoctor();
                        break;
                    case "2":
                        Console.WriteLine("Please give me the nurse information");
                        Console.WriteLine("What is your nurses name?");
                        Name = Console.ReadLine();
                        Console.WriteLine("What is the employee ID Number?");
                        EmployeeNumber = Console.ReadLine();
                        nurse.AddNurse();
                        break;
                    case "3":
                        Console.WriteLine("Please give me the janitors information");
                        Console.WriteLine("What is your janitors name?");
                        Name = Console.ReadLine();
                        Console.WriteLine("What is the ID Number?");
                        EmployeeNumber = Console.ReadLine();
                        janitor.AddJanitor();
                        break;
                    case "4":
                        Console.WriteLine("Please give me the receptionists information");
                        Console.WriteLine("What is the receptionist name?");
                        Name = Console.ReadLine();
                        Console.WriteLine("What is the employee ID Number?");
                        EmployeeNumber = Console.ReadLine();
                        receptionist.AddReceptionist();
                        
                        break;
                    case "5":
                        Console.WriteLine("Please give the patients information");
                        Console.WriteLine("What is the patients name?");
                        Name = Console.ReadLine();
                        Console.WriteLine("What is the patients age?");
                        Age = Console.ReadLine();
                        patient.AddPatient();
                        
                        break;
                    default:
                        Console.WriteLine("Please follow the instructions");
                        break;
                }
                                    
            {
                if (employeeList != null)
                {
                    Console.WriteLine("Press 1 to have the doctor draw blood from the patient");
                    Console.WriteLine("Press 2 to have the nurse draw blood from the patient");
                    Console.WriteLine("Press 3 to see if the receptionist is on the phone");
                    Console.WriteLine("Press 4 to see if the janitor is sweeping");

                    string interMenu;
                    interMenu = Console.ReadLine();
                    switch (interMenu)
                    {
                        case "1":
                            Console.WriteLine("The Doctor drew the patients blood");
                            break;
                        case "2":
                            Console.WriteLine("The Nurse drew the patients blood");
                            break;

                        default:
                            break;


                    }
                }
                
            } 
        }
    }
}

