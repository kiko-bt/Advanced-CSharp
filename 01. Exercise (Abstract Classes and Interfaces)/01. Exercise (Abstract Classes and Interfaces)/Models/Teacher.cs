using _01._Exercise__Abstract_Classes_and_Interfaces_.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Exercise__Abstract_Classes_and_Interfaces_.Models
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }

        public Teacher(int id, string name, string username, long password, string subject)
            : base (id, name, username, password)
        {
            this.Subject = subject;
        }


        public override void PrintUser()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{base.Id}. Teacher {base.Name} teach the subject - {this.Subject}");
            Console.ResetColor();
        }
    }
}
