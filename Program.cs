using System;
using System.Collections.Generic;

class Program
{
    static GymLogic gymLogic = new GymLogic();

    static void Main()
    {
        //loop the whole system until exit is selected
        while (true)
        {
            Console.WriteLine("\n \nWELCOME TO DIWATA GYM OVERLOAD!\nUNLI BUHAT, UNLI WEIGHTS, UNLI PAWIS!\n\n");
            Console.WriteLine("1. Add Member");
            Console.WriteLine("2. Remove Member");
            Console.WriteLine("3. Display Members");
            Console.WriteLine("4. Show Workout Routines");
            Console.WriteLine("5. Exit");
            Console.Write("\nChoose an option: ");

            //choices of the user
            string choice = Console.ReadLine();
            if (choice == "1") //adds new member
            {
                AddMember();
            }
            else if (choice == "2")//removes a member on the list
            {
                RemoveMember();
            }
            else if (choice == "3")//displays all the members
            {
                DisplayMembers();
            }
            else if (choice == "4")//suggestion list of workout
            {
                ShowWorkoutRoutines();
            }
            else if (choice == "5")//exit the system and end the loop
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid input, try again.");
            }
        }
    }

    //adds the members to the list of active members of the month
    static void AddMember()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter membership type (NORMAL/VIP): ");
        string membershipType = Console.ReadLine();

        gymLogic.AddMember(name, membershipType);
        Console.WriteLine("Member added successfully! \n");
    }

    //removes the members from the list of active members of the month
    static void RemoveMember()
    {
        DisplayMembers();
        Console.Write("Enter name to remove: ");
        string name = Console.ReadLine();
        gymLogic.RemoveMember(name);
        Console.WriteLine("Member removed successfully! \n");
        
    }

    //displaying the list of members
    static void DisplayMembers()
    {
        Console.WriteLine("\nList of Members:");
        List<Member> members = gymLogic.GetMembers();
        for (int i = 0; i < members.Count; i++)
        {
            Console.WriteLine("Name: " + members[i].Name + ", Membership: " + members[i].MembershipType + "\n\n");
        }
    }

    //to access the list of workout routines suggestions
    static void ShowWorkoutRoutines()
    {
        Console.WriteLine("\nAvailable Workout Routines:");
        List<string> routines = gymLogic.GetWorkoutRoutines();
        for (int i = 0; i < routines.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + routines[i]);
        }
    }
}
