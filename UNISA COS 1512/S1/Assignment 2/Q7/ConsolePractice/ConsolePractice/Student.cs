using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    class Student : IStudent
    {
        //Member Variables
        protected string name,
            studentNo,
            address,
            degree;

        protected int regFee(string type)
        {
            if (type.ToLower()[0] == 'b')
                return 500;
            else
                return 600;
        }

        public string displayInfo(Student s)
        {
            return "Name: " + s.name + "\nStudent Number: " + s.studentNo + "\nAddress: "
                + s.address + "\nDegree: " + s.degree + "\nRegistration Fee: R" + regFee(s.degree);
        }

        //Accessors
        public string getName() { return name; }
        public string getStdNo() { return studentNo; }
        public string getAdd() { return address; }
        public string getDeg() { return degree; }

        //Mutators
        public void setName(string n) { name = n; }
        public void setStdNo(string stdNo) { studentNo = stdNo; }
        public void setAdd(string a) { address = a; }
        public void setDeg(string d) { degree = d; }

    }
}
