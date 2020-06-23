using _01._Exercise__Abstract_Classes_and_Interfaces_.Models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace _01._Exercise__Abstract_Classes_and_Interfaces_
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Petar", "Pecale30", 5330, new Dictionary<StudentGrades, int>());
            Student student2 = new Student(2, "Simona", "Mona", 0000, new Dictionary<StudentGrades, int>());
            student1.Grades.Add(new StudentGrades("Science", 5), 4);
            student2.Grades.Add(new StudentGrades("Biology", 3), 2);
            Teacher teacher1 = new Teacher(1, "Slavica", "Slav4e", 2558, "Law");
            Teacher teacher2 = new Teacher(2, "Robert", "Robe", 3300, "Web Development");
            int button;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Press 1 to see Student grades, Press 2 to see Teacher subjects");
                bool validate = int.TryParse(Console.ReadLine(), out button);

                    if (button == 1)
                    {
                        Console.Clear();
                        student1.PrintUser();
                        student2.PrintUser();
                    }
                    else if (button == 2)
                    {
                        Console.Clear();
                        teacher1.PrintUser();
                        teacher2.PrintUser();
                    }
                    else
                    {
                        continue;
                    }

                break;
            }

          


          
         
 

         
 



            Console.ReadLine();
        }
    }
}
