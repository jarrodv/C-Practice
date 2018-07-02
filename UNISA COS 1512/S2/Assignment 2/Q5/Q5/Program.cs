using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Voter vote = new Voter();



            string votersRollPath = "D:/Users/defaultuser0/Documents/Programs/C# Practice/UNISA COS 1512/S2/Assignment 2/Q5/Q5/VotersRoll.txt",
                votersPath = "D:/Users/defaultuser0/Documents/Programs/C# Practice/UNISA COS 1512/S2/Assignment 2/Q5/Q5/Voters.txt";

            List<Voter> votersRoll = vote.votersRollInStreamer(votersRollPath);
            List<string> voters = vote.votersStreamer(votersPath);

            for (int i = 0; i < votersRoll.Count; i++)
            {
                for (int j = 0; j < voters.Count; j++)
                {
                    if (votersRoll[i].getID() == voters[j])
                    {
                        if (votersRoll[i].getVoted() == true)
                        {
                            Console.WriteLine(votersRoll[i].getID() + " has voted already and cannot vote again");                           
                        }
                        else
                        {
                            votersRoll[i]++;
                            votersRoll[i].setVoted(true);
                            Console.WriteLine(votersRoll[i].getID() + " is eligable for voting, and has now voted");
                        }
                    }
                }
            }
            string updatedPath = "D:/Users/defaultuser0/Documents/Programs/C# Practice/UNISA COS 1512/S2/Assignment 2/Q5/Q5/VotersRollUpdated.txt";
            vote.votersRollOutStreamer(votersRoll, updatedPath);
            Console.Read();
        }
    }
}
