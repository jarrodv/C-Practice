using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    interface IVoter
    {
        //Accessors
        string getID();
        int getXVoted();
        bool getVoted();

        //Mutators
        void setID(string ID);
        void setXVoted(int x);
        void setVoted(bool v);

        List<Voter> votersRollInStreamer(string path);

        void votersRollOutStreamer(List<Voter> voters, string path);

        List<string> votersStreamer(string path);
    }
}
