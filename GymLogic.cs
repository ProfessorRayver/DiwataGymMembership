using System;
using System.Collections.Generic;

public class GymLogic
{
    // List to store all the members of the gym
    public List<Member> Members = new List<Member>();

    // List of predefined workout routines
    public List<string> WorkoutRoutines = new List<string> {
        "Chest Day: Bench Press, Push-ups, Dumbbell Flyes",
        "Back Day: Deadlifts, Pull-ups, Lat Pulldowns",
        "Leg Day: Squats, Lunges, Leg Press",
        "Arm Day: Bicep Curls, Triceps Dips, Hammer Curls",
        "Shoulder Day: Overhead Press, Lateral Raises, Face Pulls",
        "Cardio: Running, Cycling, Jump Rope"
    };

    //adds a new member to the gym
    public void AddMember(string name, string membershipType)
    {
        //adds a new member with the provided name and membership type
        Members.Add(new Member(name, membershipType, ""));
    }

    //method to remove a member from the gym
    public void RemoveMember(string name)
    {
        //iterate through the list of members to find the member to remove
        for (int i = 0; i < Members.Count; i++)
        {
            //if the member's name matches the provided name, remove the member
            if (Members[i].Name.ToLower() == name.ToLower())
            {
                Members.RemoveAt(i);
                break;
            }
        }
    }

    //method to get the list of all members
    public List<Member> GetMembers()
    {
        //displays the list of members
        return Members;
    }

    //get the list of workout routines
    public List<string> GetWorkoutRoutines()
    {
        //displays the list of workout routines
        return WorkoutRoutines;
    }
}

public class Member
{
    //fields to store member information
    public string Name;
    public string MembershipType;
    public string WorkoutRoutine;

    //constructor to initialize a new member
    public Member(string name, string membershipType, string workoutRoutine)
    {
        Name = name;
        MembershipType = membershipType;
        WorkoutRoutine = workoutRoutine;
    }
}
