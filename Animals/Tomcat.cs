using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat: Cat
    {
        private  const string gender = "Male";
        public Tomcat(string name, int age, string gender) : base(name, age, "")
        {

        }

        private int myVar;

        public override string Gender
        { get => gender; }
        

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
