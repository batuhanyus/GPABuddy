using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GPABuddy
{
    [Serializable]
    public class Profile
    {
        public string name;
        public string program;

        public List<Course> courses = new List<Course>();

        public Profile(string name, string program)
        {
            this.name = name;
            this.program = program;
        }
    }
}
