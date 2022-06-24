using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MON institutionList = new MON();

            int year, students, teachers, classes;

            int status = 1;
            while (status != 0)
            {
                Console.WriteLine("Choose an option:\n1 - add new institution,\n2 - show list,\n0 - exit");
                int mode = Convert.ToInt32(Console.ReadLine());
                switch (mode)
                {
                    case 1:
                        Console.WriteLine("Input numbers: number of students, teachers:");
                        
                        students = Convert.ToInt32(Console.ReadLine());
                        teachers = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("What type of institution? (u - university, s - school)");
                        char inst = Convert.ToChar(Console.ReadLine());
                        switch (inst)
                        {
                            case 'u':
                                Console.WriteLine("Number of faculties: ");
                                int faculties = Convert.ToInt32(Console.ReadLine());

                                Institution university = new University(students, teachers, faculties);
                                institutionList.list.Add(university);

                                for (int i = 0; i < faculties; i++)
                                {
                                    Console.WriteLine("Creating faculty... Input data: students, teachers, year");
                                    students = Convert.ToInt32(Console.ReadLine());
                                    teachers = Convert.ToInt32(Console.ReadLine());
                                    year = Convert.ToInt32(Console.ReadLine());

                                    Institution faculty = new Faculty(students, teachers, year);
                                    ((University)university).FacultiesList.Add((Faculty)faculty);
                                }
                                ((University)university).ShowList();
                                break;
                            case 's':
                                Console.WriteLine("Number of classes: ");
                                classes = Convert.ToInt32(Console.ReadLine());
                                
                                Institution school = new School(students, teachers, classes);
                                institutionList.list.Add(school);
                                break;
                            default:
                                Console.WriteLine("Wrong input!");
                                break;
                        }
                        break;
                    case 2:
                        institutionList.ShowList();
                        break;
                    case 0:
                        status = 0;
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }

        }
    }
}
