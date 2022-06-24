using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class University : Institution
    {
        public int countFaculties;
        public List<Faculty> FacultiesList;
        public University(int students, int teachers, int faculties) : base(students, teachers, faculties)
        {
            FacultiesList = new List<Faculty>();
        }
        public void ShowList()
        {
            Console.WriteLine("\n==========================");
            foreach (Institution aPart in FacultiesList)
            {
                Console.WriteLine("Faculties:");
                Console.WriteLine(aPart + "(" + aPart.Param + ")");
            }
            Console.WriteLine("==========================\n");
        }
    }
}
