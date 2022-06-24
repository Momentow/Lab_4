using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        public abstract class Institution
        {
            public string Name = "Institute";
            int students;
            public int teachers { get; set; }
            public Institution(int st, string name)
            {
                Name = name;
                students = st;
            }
            public virtual void Check()
            {
                Console.WriteLine($"\n In {Name} actually studying {students} students and working {teachers} teachers.");
            }
        }

        class School : Institution
        {
            string Name;
            int students = 0;
            public int teachers;
            public List<string> classes = new List<string> { };
            public School(int st, string name) : base(st, name) { }
            public override void Check()
            {
                base.Check();
                
                Console.WriteLine($"There are {classes.Count} classes: ");
                foreach (var c in classes)
                {   
                    Console.WriteLine($"{c} class");
                }
            }
        }

        class Faculty : Institution
        {
            public string Name;
            int students;
            
            public int year;
            public Faculty(int st, string name, int year) : base(st, name) { this.year = year; }

            public override void Check()
            {
                base.Check();
                Console.WriteLine($"Founded in {year}.");
                
            }
        }

        class University : Institution
        {
            string Name;
            string students;
            int teachers;
            public Dictionary<string, Faculty> faculties = new Dictionary<string, Faculty> { };
            

            public University(int st, string name, List<Faculty> dic) : base(st, name)
            {
                
                foreach (var x in dic)
                {
                    faculties.Add(x.Name, x);
                    teachers += x.teachers;
                }
                
            }
            public override void Check()
            {
                base.Check();
                
                Console.WriteLine($"There are {faculties.Count} faculties here:");
                foreach (var item in faculties)
                {
                    Console.WriteLine($"\t{item.Key}, founded in {item.Value.year}");
                }
            }
        }

        static void Main(string[] args)
        {
            Institution lnz = new School(1240, "liceum Naukova Zmina") { teachers = 110, classes = { "1A", "1B", "1C" } };
            lnz.Check();

            Faculty fict = new Faculty(3200, "FICT", 1986) { teachers = 140 };
            Faculty ipsa = new Faculty(2400, "IPSA", 1953) { teachers = 156 };
            fict.Check();
            ipsa.Check();
            
            Institution kpi = new University(57000, "KPI", new List<Faculty> { fict, ipsa });
            kpi.Check();
        }
    }
}
