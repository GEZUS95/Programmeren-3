using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class Team
    {
        private List<Programmer> programmers;

        public Team()
        {
            programmers = new List<Programmer>();
        }

        public void PrintAllTeamMembers()
        {
            foreach (Programmer p in programmers)
            {
                p.Print();
            }
        }

        public void AddProgrammer(Programmer p)
        {
            programmers.Add(p);
        }
    }
}
