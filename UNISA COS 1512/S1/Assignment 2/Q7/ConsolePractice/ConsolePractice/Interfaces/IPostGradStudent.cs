using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.Interfaces
{
    interface IPostGradStudent
    {
        //Accessors
        string getDis();
        //Mutators
        void setDis(string d);

        //Member Methods
        string displayInfo(PostgradStudent pS);
    }
}
