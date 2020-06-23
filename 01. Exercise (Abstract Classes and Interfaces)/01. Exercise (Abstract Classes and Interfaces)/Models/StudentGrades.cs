using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Exercise__Abstract_Classes_and_Interfaces_.Models
{
    public class StudentGrades
    {
        public string Type { get; set; }
        public int Grade { get; set; }

        public StudentGrades(string type, int grade)
        {
            this.Type = type;
            this.Grade = grade;
        }
    }
}
