using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    abstract class Institution
    {
        public int CountStudents { get; set; }
        public int CountTeachers { get; set; }
        public int Param { get; set; }

        public Institution(int students, int teachers, int param)
        {
            CountStudents = students;
            CountTeachers = teachers;
            Param = param;
        }

        public string ShowInfo()
        {
            return "(" + this.CountStudents + "st, " +
                this.CountTeachers + "t, " + this.Param + ")";
        }    
    }
}
