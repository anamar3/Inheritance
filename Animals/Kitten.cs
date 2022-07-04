using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public class Kitten: Cat
    {
        public const string gender = "Female";
        public Kitten(string name,int age,string gender):base(name,age,"")
        {

        }
        public override string ProduceSound()
        {
            return "Meow";
        }
        public override string Gender { get=>gender; }
    }
}
