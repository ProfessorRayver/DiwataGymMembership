using System;
using GymSystem.businessLogic;
using System.Collections.Generic;

// Rayver S. Reyes
// BSIT 2-1

// My system aims to track the gym memberships, able to add and remove active and inactive memberships.
// This system aims to help the gym to be paperless when it comes to documentation
// of the memberships of the gym peeps.

namespace GymSystem.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GymManager gymManager = new GymManager();

            // Prompt to show or ask admin password
            Console.Write("Enter the ADMIN pass to access the system: ");
            string adminPass = Console.ReadLine();

            // Authenticate admin access
            if (!gymManager.Verify(adminPass))
            {
                Console.WriteLine("You have entered the WRONG password.");
                return;
            }

            Console.WriteLine("WELCOME TO DIWATA GYM OVERLOAD!\nUNLI BUHAT, UNLI WEIGHTS, UNLI PAWIS!");

            // Main loop for user interaction
            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("[1] View Active Members");
                Console.WriteLine("[2] Remove Member");
                Console.WriteLine("[3] View Workout Plans");
                Console.WriteLine("[0] Exit");
                Console.Write("Enter Choice: ");

                // Parse user input
                if (!int.TryParse(Console.ReadLine(), out int userAction))
                {
                    Console.WriteLine("Invalid input, try again.");
                    continue;
                }

                // Handle user actions
                switch (userAction)
                {
                    case 1:
                        ViewMembers(gymManager);
                        break;
                    case 2:
                        RemoveMember(gymManager);
                        break;
                    case 3:
                        ViewWorkoutRoutines(gymManager);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }

        // Display the list of active members
        static void ViewMembers(GymManager gymManager)
        {
            List<string> members = gymManager.GetMembers();

            Console.WriteLine("\n|||| Members List ||||");
            if (members.Count == 0)
            {
                Console.WriteLine("No active members.");
                return;
            }

            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {members[i]}");
            }
        }

        // Remove a member by their index
        static void RemoveMember(GymManager gymManager)
        {
            ViewMembers(gymManager);
            Console.Write("Enter Member Number to Remove: ");

            if (!int.TryParse(Console.ReadLine(), out int index) || index < 1)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (gymManager.RemoveMember(index - 1))
            {
                Console.WriteLine("Member Removed Successfully!");
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        // Display the list of workout plans
        static void ViewWorkoutRoutines(GymManager gymManager)
        {
            List<string> workouts = gymManager.GetWorkoutPlans();
            Console.WriteLine("\n|||| Workout Plans ||||");

            for (int i = 0; i < workouts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {workouts[i]}");
            }
        }
    }
}
