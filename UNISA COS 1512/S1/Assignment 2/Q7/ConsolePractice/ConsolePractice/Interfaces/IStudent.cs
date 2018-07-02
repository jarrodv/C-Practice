using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    interface IStudent
    {
        string displayInfo(Student s);

        //Accessors
        string getName();
        string getStdNo();
        string getAdd();
        string getDeg();

        //Mutators
         void setName(string n);
         void setStdNo(string stdNo);
         void setAdd(string a);
         void setDeg(string d);
    }
}
