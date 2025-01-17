using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace EventManagementSystem
{
    class Program
    {
    //The main method is the entry point of the application
        static void Main(string[] args)
        {
            // Show welcome logo message with ASCII art
            Console.WriteLine();
            string ASCIIArt = 
@"  ______    _____   _   _     ______                          _         
 |  ____|  / ____| | \ | |   |  ____|                        | |        
 | |__    | (___   |  \| |   | |__    __   __   ___   _ __   | |_   ___ 
 |  __|    \___ \  | . ` |   |  __|   \ \ / /  / _ \ | '_ \  | __| / __|
 | |____   ____) | | |\  |   | |____   \ V /  |  __/ | | | | | |_  \__ \
 |______| |_____/  |_| \_|   |______|   \_/    \___| |_| |_|  \__| |___/";
            Console.WriteLine(ASCIIArt);
            Console.WriteLine("Welcome to the ESN Event Management System!");
            Console.WriteLine();

           //Initialize the logger
           //Logger.Initialize();

            // User can exit only if option is selected
            bool exit = false;

            // DB Connecttion test
            // DBHandler.TryDBConnection();

            while (!exit)
            {
                //Display the menu
                DisplayMainMenu();

                Console.Write("Please select an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        DisplayManageEventsMenu();
                        break;
                    case "2":
                        DisplayManageStudentsMenu();
                        break;
                    case "3":
                        DisplayManageEventParticipantsMenu();
                        break;
                    case "4":
                        DisplayReportingMenu();
                        break;
                    case "5":
                        LoadOrSaveDataMenu();
                        break;
                    case "6":
                        exit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please check your selected option and try again.");
                        break;
                }
                Console.WriteLine();
            }                                                
        }
        
        // Display the main menu
        static void DisplayMainMenu()
        { 
            Console.WriteLine("1. Manage Events");
            Console.WriteLine("2. Manage Students");
            Console.WriteLine("3. Manage Event Participants (Not implemented)");
            Console.WriteLine("4. Reporting options (Not implemented)");
            Console.WriteLine("5. Load or Save Data");
            Console.WriteLine("6. Exit");
        }

        //Display the Managing Events menu
        static void DisplayManageEventsMenu()
        {
            Console.WriteLine("1. Create Events");
            Console.WriteLine("2. List Events");
            Console.WriteLine("3. Edit Events");
            Console.WriteLine("4. Delete Events");
            Console.WriteLine("5. Back to Main Menu");
            Console.WriteLine("6. Exit");

            Console.Write("Please select an option: ");
           /* string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddEvents();
                    break;
                case "2":
                    ListEvents();
                    break;
                case "3":
                    EditEvents();
                    break;
                case "4":
                    DeleteEvents();
                    break;
                case "5":
                    DisplayMainMenu();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please check your selected option and try again.");
                    break;
            }*/
            Console.WriteLine();
        }

        // Create a list of events using polymorpphism
        /*List<Event> events = new List<Event>
            {
                new Event("Annual Meeting", new DateTime(2023, 12, 1), "London"),
                new Workshop("Photography Workshop", new DateTime(2023, 11, 15), "New York", "Jane Doe", 4)
            };*/

        // List all events
        static void ListEvents()
        {
            Console.WriteLine("List of Events:");
            foreach (Events e in Events.EventsList)
            {
                Console.WriteLine(e);
            }
        }

        //Display the Managing Students menu
        static void DisplayManageStudentsMenu()
        {
            
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. List Students");
            Console.WriteLine("3. Edit Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Back to Main Menu");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Please select an action:");

            /*string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    ListStudents();
                    break;
                case "3":
                    EditStudent();
                    break;
                case "4":
                    DeleteStudent();
                    break;
                case "5":
                    DisplayMainMenu();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please check your selected option and try again.");
                    break;
            }*/
            Console.WriteLine();
        }

        //Display the Managing Event Participants menu
        static void DisplayManageEventParticipantsMenu()
        {
            
            Console.WriteLine("1. Register Student for Event");
            Console.WriteLine("2. Unregister Student from Event");
            Console.WriteLine("3. Back to Main Menu");
            Console.WriteLine("4. Exit");

            Console.Write("Please select an option: ");
           /* string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    RegisterStudentForEvent();
                    break;
                case "2":
                    UnregisterStudentFromEvent();
                    break;
                case "3":
                    DisplayMainMenu();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please check your selected option and try again.");
                    break;
            }*/
            Console.WriteLine();
        }

        //Display the Reporting Menu
        static void DisplayReportingMenu()
        {
            
            Console.WriteLine("1. List all participants for an event");
            Console.WriteLine("2. List all events a participant is registered for");
            Console.WriteLine("3. Back to Main Menu");
            Console.WriteLine("4. Exit");

            Console.Write("Please select an option: ");
            /*string choice = Console.ReadLine();
            switch (choice)
            {
               case "1":
                    ListAllParticipantsForEvent();
                    break;
                case "2":
                    ListAllEventsForParticipant();
                    break;
                case "3":
                    DisplayMainMenu();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please check your selected option and try again.");
                    break; 
            }*/
            Console.WriteLine();
        }

        //Display the Load or Save Data Menu
        static void LoadOrSaveDataMenu()
        {
            
            Console.WriteLine("1. Load Data from CSV");
            Console.WriteLine("2. Save Data to CSV");
            Console.WriteLine("3. Back to Main Menu");
            Console.WriteLine("4. Exit");

            Console.Write("Please select an option: ");
            /*string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CSVHandler.LoadDataFromCSV();
                    break;
                case "2":
                    CSVHandler.SaveDataToCSV();
                    break;
                case "3":
                    DisplayMainMenu();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please check your selected option and try again.");
                    break;
            }*/
            Console.WriteLine();
        }
    }
}