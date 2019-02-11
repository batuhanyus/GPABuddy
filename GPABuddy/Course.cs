using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPABuddy
{
    [Serializable]
    public class Course
    {
        public int ID;
        public string name;
        public int akts;
        public int semester;
        public float grade;
        public bool isTaken;
        public int semesterGrade; //For re-takes.

        public Course(int iD, string name, int akts, int semester)
        {
            ID = iD;
            this.name = name;
            this.akts = akts;
            this.semester = semester;
        }
    }
}
