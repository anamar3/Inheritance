using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList: List<string>
    {
        private Random rnd;
        public RandomList()
        {
            Rnd = new Random();
        }
        public Random Rnd { get; set; }
       public string RemoveRandomElement()
        {
            int index = Rnd.Next(0,this.Count);
            string str = this[index];
            this.RemoveAt(index);
            return str;
        }
    }
}
