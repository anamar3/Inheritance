using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        private int age;
        public Child(string name,int age):base(name,age)
        {
            Age = age;
        }
        public int MyProperty
        {
            get { return age; }
            set { if (age <= 15) { age = value; } }
        }

    }
}
