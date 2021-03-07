using _01._Exercise__Abstract_Classes_and_Interfaces_.Interfaces;
using System;
using System.Collections.Generic;

namespace _01._Exercise__Abstract_Classes_and_Interfaces_.Models
{
    public class Student : User, IStudent
    {
        public Dictionary<StudentGrades, int> Grades { get; set; }

        public Student(int id, string name, string userName, int password, Dictionary<StudentGrades, int> grades)
            : base (id, name, userName, password)
        {
            this.Grades = grades;
        }

        public override void PrintUser()
        {
            foreach (var grade in Grades)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{base.Id}. Student {base.Name} Grades: {grade.Key.Type} (Test - {grade.Key.Grade}) | (Practice - {grade.Value})");
                Console.ResetColor();
            }
        }
    }
}
