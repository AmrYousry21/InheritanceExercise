using System;

namespace Inheritance
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird();
            string input = "";
          
            Console.WriteLine("Enter a chirping sound for your bird: ");
            input = Console.ReadLine();
            bird.chirp = (input == "") ? "You entered an empty string" : input;
            Console.WriteLine();

            Console.WriteLine("How fast can this bird Fly? ");
            input = Console.ReadLine();
            bird.fly = (input == "") ? "You entered an empty string" : input;
            Console.WriteLine();

            Console.WriteLine("How good is the birds vision: ");
            input = Console.ReadLine();
            bird.vision = (input == "") ? "You entered an empty string" : input;
            Console.WriteLine();

            Console.WriteLine("How many hours of sleep does it get in a day? ");
            input = Console.ReadLine();
            bird.sleeps = (input == "") ? "You entered an empty string" : input;
            Console.WriteLine();


            Console.WriteLine(bird.chirp);
            Console.WriteLine(bird.fly);
            Console.WriteLine(bird.vision);
            Console.WriteLine(bird.sleeps);

            Console.WriteLine();
            Console.WriteLine();


            var reptile = new Reptile();
            input = "";

            Console.WriteLine("Does you reptile have scaly skin ?");
            input = Console.ReadLine();
            reptile.roughSkin = (input == "") ? "You entered an empty string" : input;
            Console.WriteLine();

            Console.WriteLine("Color of eyes ?");
            input = Console.ReadLine();
            reptile.yellowEyes = (input == "") ? "You entered an empty string" : input;
            Console.WriteLine();

            Console.WriteLine("Walks on Four ?");
            input = Console.ReadLine();
            reptile.walksOnFour = (input == "") ? "You entered an empty string" : input;
            Console.WriteLine();

            Console.WriteLine("does have a tail ? ");
            input = Console.ReadLine();
            reptile.tail = (input == "") ? "You entered an empty string" : input;
            Console.WriteLine();


            Console.WriteLine(reptile.roughSkin);
            Console.WriteLine(reptile.yellowEyes);
            Console.WriteLine(reptile.walksOnFour);
            Console.WriteLine(reptile.tail);





           
        }
    }
}
