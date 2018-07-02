using ConsolePractice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    class PostgradStudent : Student, IPostGradStudent
    {
        protected string dissertation;

        public string getDis() { return dissertation; }
        public void setDis(string d) { dissertation = d; }

        private int regFee(string type)
        {
            if (type.ToLower()[0] == 'b')
                return 500;
            else
                return 12000;
        }

        public string displayInfo(PostgradStudent pS)
        {
            return "Name: " + pS.name + "\nStudent Number: " + pS.studentNo + "\nAddress: "
                + pS.address + "\nDegree: " + pS.degree + "\nRegistration Fee: R" + 
                regFee(pS.degree) + "\nDissertation: " + pS.dissertation;
        }
    }
}
