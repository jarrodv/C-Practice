using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JarrodLib;

namespace Q5
{
    class Voter : IVoter
    {
        JarrodLib.StringMethods stringMehtods = new StringMethods();

        //Member Variables
        protected string ID;
        protected int xVoted;
        protected bool voted;

        //Constructors
        public Voter()
        {
            ID = "";
            xVoted = 0;
            voted = false;
        }

        public Voter(string id, int xV, bool v)
        {
            ID = id;
            xVoted = xV;
            voted = v;
        }

        //Operators
        public static Voter operator ++(Voter v)
        {
            v.xVoted++;
            return v;
        }

        

        //Accessors
        public string getID() { return ID; }
        public bool getVoted() { return voted; }

        public int getXVoted() { return xVoted; }

        //Modifiers
        public void setID(string id) { ID = id; }

        public void setVoted(bool v) { voted = v; }

        public void setXVoted(int x) { xVoted = x; }

        public List<Voter> votersRollInStreamer(string path)
        {
            FileStream inStream;
            inStream = File.Open(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inStream);
            

            List<Voter> votes = new List<Voter>();
            List<string> lines = new List<string>();

            string stream = reader.ReadLine();
            while ((stream != null))
            {
                Voter vote = new Voter();
                lines = stream.Split(' ').ToList(); //Splits line according to spaces
                lines.RemoveAll(x => string.IsNullOrEmpty(x)); //Removes all spaces

                vote.setID(lines[0]);
                vote.setXVoted(int.Parse(lines[1]));
                if (int.Parse(lines[2]) == 0)
                    vote.setVoted(false);
                else
                    vote.setVoted(true);
                votes.Add(vote);               
                stream = reader.ReadLine(); //Needed to get next line from the stream
            }
            reader.Close();
            return votes;
        }

        public List<string> votersStreamer(string path)
        {
            FileStream inStream;
            inStream = File.Open(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inStream);

            List<string> voters = new List<string>();

            string stream = reader.ReadLine();
            while (stream != null)
            {
                stream = stringMehtods.removeWhiteSpace(stream);
                voters.Add(stream);
                stream = reader.ReadLine();
            }
            return voters;
        }

        public void votersRollOutStreamer(List<Voter> voters, string path)
        {
            FileStream outStream;
            outStream = File.Create(path);
            StreamWriter writer = new StreamWriter(outStream);

            for (int i = 0; i < voters.Count(); i++)
            {
                string line = voters[i].getID() + " " + voters[i].getXVoted()
                    + " ";
                if (voters[i].getVoted() == true)
                    line = line + "1";
                else
                    line = line + "0";
                writer.WriteLine(line);
            }

            writer.Close();
        }
    }
}
