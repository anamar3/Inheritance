using System;
namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string typeOfClass = Console.ReadLine();
            while (typeOfClass!= "Beast!")
            {

                string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Animal animal = null;

                if (typeOfClass == "Cat")
                {

                    animal = new Cat(info[0], int.Parse(info[1]), info[2]);
                }
                else if (typeOfClass == "Dog")
                {
                    animal = new Dog(info[0], int.Parse(info[1]), info[2]);
                }
                else if (typeOfClass == "Kitten")
                {
                    animal = new Kitten(info[0], int.Parse(info[1]), info[2]);
                }
                else if (typeOfClass == "Tomcat")
                {
                    animal = new Tomcat(info[0], int.Parse(info[1]), info[2]);
                }
                else if (typeOfClass == "Frog")
                {
                    animal = new Frog(info[0], int.Parse(info[1]), info[2]);
                }

                Console.WriteLine( animal.ToString());
               

                 typeOfClass = Console.ReadLine();
            }
        }
    }
}
