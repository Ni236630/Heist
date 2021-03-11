﻿using System;


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
            //run  multiple times
            Console.WriteLine("Enter the number of times you would like to run this senario below.");
            Console.Write(">");
            int NumberOfTrials = Console.Read();
            //for loop for # of Senarios
            for (int i = 0; i < NumberOfTrials; i++)
            {
                //bank info
                int bankDifficulty = 100;
                Random Luck = new Random();
                int HeistLuck = Luck.Next(-10,10);
                int bankDifficultyWithLuck = bankDifficulty + HeistLuck;
                
                if( HeistCrew.TeamSkillTotal < bankDifficultyWithLuck )
                {    
                    Console.WriteLine($@"
                    Bank difficulty: {bankDifficultyWithLuck}
                    Crew's Skill: {HeistCrew.TeamSkillTotal}");
                    Console.WriteLine("Looks like you'll be spending some time in the slammer. Better look for a day job when you get out cause you're not cut out for this.");
                }
                else 
                {
                    Console.WriteLine($@"
                    Bank difficulty: {bankDifficultyWithLuck}
                    Crew's Skill: {HeistCrew.TeamSkillTotal}
                    ");
                    Console.WriteLine("You and your crew made out with some goodies, but time to plan the next job!");
                }
            }
        }
    }
}

