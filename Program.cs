using System;

//Rayver S. Reyes
//BSIT 2-1

//My system aims to track the gym memberships, able to add and remove active and inactive memberships.
//this system aims to help the gym to be paperless when it comes to documentation
//of the memberships of the gym peeps.

namespace GymSystem
{
    internal class Program
    {
        //the ADMIN password: 1234
        static string Password = "1234";

        //manual input of members
        static string member1 = "Chacha";
        static string member2 = "Rayray";
        static string member3 = "Sushi";
        static int count = 3; //3 Active members

        static void Main(string[] args)
        {

            Console.Write("Enter the ADMIN pass to access the system. \nPASSWORD: ");
            string adminPass = Console.ReadLine();


            if (adminPass != Password)
            {

                Console.WriteLine("You have entered WRONG password.");
                return;
            }




            Console.WriteLine("WELCOME TO DIWATA GYM OVERLOAD! \nUNLI BUHAT, UNLI WIEGHTS, UNLI PAWIS!");

            //looping of choices (main functionality of my system)
            while (true)
            {
                Console.WriteLine("\nPlease do select your choices:    (pumili ng ninanais gawin)");
                Console.WriteLine("[1] View Active Members           (Tignan Ang Mga Aktibong Myembro)");
                Console.WriteLine("[2] Remove Member                 (Mag tanggal ng Myembro)");
                Console.WriteLine("[3] Exit");


                Console.Write("Enter Choice:");
                int userAction = Convert.ToInt16(Console.ReadLine());


                if (userAction == 1) ViewMem();
                else if (userAction == 2) RemoveMem();
                else if (userAction == 3) break;
                else Console.WriteLine("ooppss.. Try again. ^_^");
            }
        }

        static void ViewMem() // to view the active list of registered/active membership
        {
            Console.WriteLine("\n|||| Members List ||||");
            if (count == 0) Console.WriteLine("Empty members yet.");
            if (count >= 1) Console.WriteLine("1. " + member1);
            if (count >= 2) Console.WriteLine("2. " + member2);
            if (count >= 3) Console.WriteLine("3. " + member3);
        }

        static void RemoveMem() // to remove members who are not continuing to the gym (did not pay on time)
        {
            if (count == 0)
            {
                Console.WriteLine("there is no members to remove.");
                return;
            }

            ViewMem();
            Console.Write("Enter Member Number to Remove: ");
            int removeIndex = Convert.ToInt16(Console.ReadLine());

            if (removeIndex == 1) member1 = member2;
            if (removeIndex == 2) member2 = member3;
            if (removeIndex == 3) member3 = "";

            count--;
            Console.WriteLine("Member Removed!");
        }
    }
}
