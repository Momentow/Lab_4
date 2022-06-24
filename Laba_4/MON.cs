using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class MON
    {
        public List<Institution> list;
        public MON()
        {
            list = new List<Institution>();
        }
        public void ShowList()
        {
            Console.WriteLine("\n==========================");
            foreach (Institution aPart in list)
            {
                Console.WriteLine(aPart + aPart.ShowInfo());  
            }
            Console.WriteLine("==========================\n");
        }
    }
}
