using System;
using System.Collections.Generic;

namespace Heist
{
    public class TheTeam
    {
        public List<TeamMember> TeamMates{ get; } = new List<TeamMember>(); 

        public int TeamSkillTotal = 0;

        public void addTeamMate( TeamMember member)
        {
            TeamMates.Add(member);
            
        }
    }
}