using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        public Person(string name,int age)
        {
            Age = age;
            Name = name;
        }
        private int age;
        private string name;
        public string Name { get; set; }
        public int Age
        {
            get { return age; }
            set { if (age >= 0) { age = value; } }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}, Age: {Age}");

            return sb.ToString().TrimEnd();
        }

    }
}
