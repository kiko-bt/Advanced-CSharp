using _01._Exercise__Abstract_Classes_and_Interfaces_.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Exercise__Abstract_Classes_and_Interfaces_.Models
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public long Password { get; set; }


        public User(int id, string name, string username, long password)
        {
            this.Id = id;
            this.Name = name;
            this.Username = username;
            this.Password = password;
        }

        public virtual void PrintUser()
        {
            Console.WriteLine($"{Id}. {Name} | {Username}");
        }
    }
}
