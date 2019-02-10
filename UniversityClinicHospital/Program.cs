using System;
using System.Collections.Generic;

namespace UniversityClinicHospital
{
    public class Program
    {
        private static string EmployeeNumber;

        public static string Name { get; private set; }
        public static string Specialty { get; private set; }
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
            

            List<Employee> employeeList = new List<Employee>();
            List<Patient> patientList = new List<Patient>();

            bool run = true;

            do
            { 
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
                        run = false;
                        break;
                    case "1":
                        Console.WriteLine("Please give me the doctor information");
                        Console.WriteLine("What is your doctors name?");
                        Name = Console.ReadLine();
                        Console.WriteLine("What is the doctors specialty?");
                        Specialty = Console.ReadLine();
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
                        Console.WriteLine("Press 3 to see the receptionists status");
                        Console.WriteLine("Press 4 to see the janitors status");
                        Console.WriteLine("Press 5 to see the doctors status");
                        Console.WriteLine("Press 6 to see the nurses status");
                        Console.WriteLine("Press 7 to see the patients status");
                        Console.WriteLine("Press 8 to go back to the Main Menu");
                        Console.WriteLine("Press 0  to go to the main menu");

                        string interMenu;
                        interMenu = Console.ReadLine();
                        switch (interMenu)
                        {
                            case "1":
                                patient.DrDrewBlood();
                                break;
                            case "2":
                                patient.NurseDrewBlood();
                                break;
                            case "3":
                                receptionist.EmployeeStatus();
                                receptionist.OnPhone();
                                receptionist.GetsPaid();
                                break;
                            case "4":
                                janitor.EmployeeStatus();
                                janitor.JanitorGetsPaid();
                                break;
                            case "5":
                                doctor.EmployeeStatus();
                                doctor.GetsPaid();
                                break;
                            case "6":
                                nurse.EmployeeStatus();
                                nurse.NurseGetsPaid();
                                break;
                            case "7":
                                patient.Status();
                                break;
                            case "8":
                                MainMenu();
                                break;
                            case "0":
                                Console.WriteLine("Stay well, friend");
                                run = false;
                                break;
                            default:
                                Console.WriteLine("Please follow the instructions");
                                break;
                        }
                    }
                }
            } while (run);
        }
    }
}

