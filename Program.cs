using System;
using System.Collections.Generic;
namespace ElectionWeek6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> candidateVoteCount = new Dictionary<string, int>();
            List<string> candidateVotes = new List<string>();
            string quit = "***";
            string name = "";

            while (name != quit)
            {
                name = Console.ReadLine();

                if (name == quit)
                {
                    continue;
                }
                else
                {
                    candidateVotes.Add(name);
                }
            }

            HashSet<string> candidateNames = new HashSet<string>(candidateVotes);

            foreach (var n in candidateNames)
            {
                candidateVoteCount.Add(n, 0);
            }


            foreach (string n in candidateVotes)
            {
                candidateVoteCount[n] += 1;
            }

            int maxVote = 0;

            foreach (var kvp in candidateVoteCount)
            {
                if (kvp.Value >= maxVote)
                {
                    maxVote = kvp.Value;
                }
            }

            int maxVoteQty = 0;

            foreach (var kvp in candidateVoteCount)
            {
                if (kvp.Value == maxVote)
                {
                    maxVoteQty += 1;
                    name = kvp.Key;
                }
            }

            if (maxVoteQty > 1)
            {
                Console.WriteLine("Runoff!");
            }
            else
            {
                Console.WriteLine(name);
            }
        }
    }
}