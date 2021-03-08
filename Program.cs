using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");
            Console.WriteLine("---------------");
            Console.WriteLine("To add a member to the team enter a name below.");
            Console.WriteLine(">");
            string memberName = Console.ReadLine();
            TeamMember recruit = new TeamMember(){ FirstName = memberName};
            Console.WriteLine("Great! now waht is his skill level? (must be a number greater than 1");
            Console.WriteLine(">");
            string memberSkillLevel = Console.ReadLine();
            recruit.SkillLevel = int.Parse(memberSkillLevel) ;
            Console.WriteLine("Wowweee! Look at thsoe skills! but are the courageous?");
            Console.WriteLine("On a scale of 0.0 to 2.0....how courageous would you say they are?");
            string courage = Console.ReadLine();
            recruit.Courage = decimal.Parse(courage);
            Console.WriteLine("We'll see if they are truly that courageous once bullets start flying.");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine("So this is what we got:");
            Console.WriteLine($@"
            Name: {recruit.FirstName}
            Skill Level: {recruit.SkillLevel}
            Courage: {recruit.Courage} (<---- take this how you will)
            ");


            

        }
    }
}
