using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // creating a class
    public class Person
    {
        // creating a variable inside a class
        public string Name;
        // creating a method inside a class
        public void Introduce(string to)
        {
            Console.WriteLine("Hi.. {0}, Please Introduce to Mr. {1}", Name, to);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // creating a object of Person class
            Person person = new Person();
            person.Name = "XYZ";
            person.Introduce("Shantanu");
        }
    }
}
