using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem.businessLogic
{
    public class GymManager
    {
        private string adminPassode = "4321"; //password for authentication
        private List<string> members; // List to store gym members

        public GymManager()
        {
            // Initialize the members list with some default members
            members = new List<string> { "Chacha", "Rayray", "Sushi", "Shell", "Rose" };
        }

        // Method to authenticate admin access
        public bool Verify(string inputPassword)
        {
            return inputPassword == adminPassode;
        }

        // Method to get a copy of the members list
        public List<string> GetMembers()
        {
            return new List<string>(members); // Return a copy to prevent external modifications
        }

        // Method to remove a member by index
        public bool RemoveMember(int index)
        {
            if (index >= 0 && index < members.Count)
            {
                members.RemoveAt(index); // Remove member at the specified index
                return true;
            }
            return false; // Return false if index is out of range
        }

        // Method to get a list of workout plans
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
    }
}
