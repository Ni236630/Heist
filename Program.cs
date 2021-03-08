using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");
            Console.WriteLine("---------------");

            TheTeam HeistCrew = new TheTeam();
            bool stayInLoop = true;
            string memberName;
            int bankDifficulty = 100;

            while (stayInLoop == true)
            {


                Console.WriteLine("To add a member to the team enter a name below.");
                Console.Write(">");
                memberName = Console.ReadLine();
                if (memberName != "")
                {

                    TeamMember recruit = new TeamMember(memberName);
                    Console.WriteLine("Great! now what is his skill level? (must be a number greater than 1");
                    Console.Write(">");
                    string memberSkillLevel = Console.ReadLine();
                    recruit.SkillLevel = int.Parse(memberSkillLevel);
                    Console.WriteLine("Wowweee! Look at thsoe skills! but are the courageous?");
                    Console.WriteLine("On a scale of 0.0 to 2.0....how courageous would you say they are?");
                    string courage = Console.ReadLine();
                    recruit.Courage = decimal.Parse(courage);
                    Console.WriteLine("We'll see if they are truly that courageous once bullets start flying.");
                    Console.WriteLine(".");
                    Console.WriteLine(".");
                    Console.WriteLine(".");
                    //adding the recruit to the team
                    HeistCrew.addTeamMate(recruit);
                    HeistCrew.TeamSkillTotal  += recruit.SkillLevel;
                }
                else
                {
                    stayInLoop = false;
                }

            }

            Console.WriteLine("So this is what we got.");
            int numberOfMembers = HeistCrew.TeamMates.Count;
            Console.WriteLine($"You have {numberOfMembers} crew members:");
           if( HeistCrew.TeamSkillTotal < bankDifficulty)
           {
               Console.WriteLine("Looks like you'll be spending some time in the slammer. Better look for a day job when you get out cause you're not cut out for this.");
           }
            else 
            {
                Console.WriteLine("You and your crew made out with some goodies, but time to plan the next job!");
            }
        }
    }
}

