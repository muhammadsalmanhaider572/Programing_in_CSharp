using System;
namespace OOP_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog { Name = "Buddy", Bread = "Golden Retriever" };
            myDog.MakeSound();
        }
        class Animal
        {
            public string Name { get; set; }
            public virtual void MakeSound() => Console.WriteLine("Some animals makes generic sounds");
        }
        class Dog : Animal
        {
            public string Bread { get; set; }
            public override void MakeSound() => Console.WriteLine($"{Name} the {Bread} says: Woof! Woof!");
        }
    }
}

