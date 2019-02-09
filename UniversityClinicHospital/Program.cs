using System;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu()
        {
            Employee employee = new Employee();
            Doctor doctor = new Doctor();
            bool run = true;

            do
            {
                Console.WriteLine("Hospital Menu");
                Console.WriteLine("Press 1 to add a doctor");
                Console.WriteLine("Press 2 to add a nurse");
                Console.WriteLine("Press 3 to admit a patient");
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
                        doctor.AddDoctor();
                        break;
                        /*case "2":
                        Console.WriteLine("Please give me the nurse information:);
                           
                     
                     */
                }   

            } while (run == true);
        }
    }
}
