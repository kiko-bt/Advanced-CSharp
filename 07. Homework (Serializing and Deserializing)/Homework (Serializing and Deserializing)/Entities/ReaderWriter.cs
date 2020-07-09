using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Homework__Serializing_and_Deserializing_.Entities
{
    public class ReaderWriter
    {
        public string ReadFile(string path)
        {
            string result = String.Empty;
            if (!File.Exists(path))
            {
                return "The file does not exist!";
            }
            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }
            Console.WriteLine("Successfully read a file!");
            return result;
        }

        public void WriteFile(string path, string data)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(data);
            }
            Console.WriteLine("Data successfully written in a file!");
        }
    }
}
