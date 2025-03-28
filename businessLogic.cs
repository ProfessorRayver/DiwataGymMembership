using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem.businessLogic
{
    public class GymManager
    {
        private string adminPassword = "4321"; //password for autentication
        private List<Member> members; //list to store gym members

        public GymManager()
            {
            // Initialize the members list with some default members
            members = new List<Member>
            {
                new Member { Name = "Chacha", MembershipType = "Ordinary" },
                new Member { Name = "Rayray", MembershipType = "VIP" },
                new Member { Name = "Sushi", MembershipType = "Ordinary" },
                new Member { Name = "Shell", MembershipType = "VIP" },
                new Member { Name = "Rose", MembershipType = "Ordinary" }
            };
            }

        //method to authenticate access
        public bool Verify(string inputPassword)
             {
            return inputPassword == adminPassword;
        }

        //to get a copy of the members list
        public List<string> GetMembers()
             {
            return members.Select(m => m.Name).ToList(); // Return a list of member names
        }

        //remove a member by index
        public bool RemoveMember(int index)
             {
            if (index >= 0 && index < members.Count)
            {
                members.RemoveAt(index); //remove member at the specified index
                return true;
            }
            return false; //return false if index is out of range
        }

        //get a list of workout plans
        public List<string> GetWorkoutPlans()
             {
            return new List<string>
            {
                "Chest Day: Bench Press, Push-ups, Dumbbell Flyes",
                "Back Day: Deadlifts, Pull-ups, Lat Pulldowns",
                "Leg Day: Squats, Lunges, Leg Press",
                "Arm Day: Bicep Curls, Triceps Dips, Hammer Curls",
                "Shoulder Day: Overhead Press, Lateral Raises, Face Pulls",
                "Cardio: Running, Cycling, Jump Rope"
            };
        }

        //method to add a new member with membership type
        public void AddMember(string name, string membershipType)
            {
            members.Add(new Member { Name = name, MembershipType = membershipType });
        }

        //get a list of members with their membership types
        public List<Member> GetMembersWithTypes()
            {
            return new List<Member>(members); //return a copy of list
        }
    }

    public class Member
    {
        public string Name { get; set; }
        public string MembershipType { get; set; }
    }
}

