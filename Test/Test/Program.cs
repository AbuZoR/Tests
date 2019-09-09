using System;

namespace Test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog
            {
                Legs = 4,
                MakeNoise = "Woof"
            };

            Duck duck = new Duck
            {
                Legs = 2,
                MakeNoise = "Quack"
            };

            Console.WriteLine($"A {dog.GetType().Name} has {dog.legs} legs and says {dog.noise}");
            Console.WriteLine($"A {duck.GetType().Name} has {duck.legs} legs and says {duck.noise}");
            Console.WriteLine($"{dog.ToXML(dog)}");
            Console.WriteLine($"{duck.ToXML(duck)}");
            Console.ReadLine();
        }
    }
}