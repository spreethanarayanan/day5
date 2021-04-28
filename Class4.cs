using System;
using System.Collections.Generic;
using System.Text;

namespace day5
{
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        ~Person()
        {
            Name = string.Empty;
        }
        public override string ToString()
        {
            return "Hi" + Name;
        }
        public static void Main()
        {
            int count = 3;
            Person[] person = new Person[count];
            for (int i = 0; i < count; i++)
            {
                person[i] = new Person(Console.ReadLine());
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(person[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
