//using System;
//namespace OOP_Concept
//{
/*class Program
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
        private string Bread { get; set; }

        public string P_bread 
        {
            get { return Bread; }
            set { Bread = value; }
        }
        public override void MakeSound() => Console.WriteLine($"{Name} the {Bread} says: Woof! Woof!");
    }
}
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evensquares = from n in numbers
                              where n % 2 != 0
                              orderby n descending
                              select n * n;
            Console.WriteLine("Squares of even numbers in descending order:");
            foreach(var items in evensquares)
            {
                Console.WriteLine(items);
            }
        }
    }
}*/
using System;
using System.Threading.Tasks;

namespace Concept5_Async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting download process...");

            // Start async task and keep moving
            Task<string> downloadTask = DownloadDataAsync();

            Console.WriteLine("Doing other work while downloading...");

            // Wait for the download to finish and get the result
            string result = await downloadTask;
            Console.WriteLine(result);
        }

        public static async Task<string> DownloadDataAsync()
        {
            // Simulate waiting 2 seconds for a web server response
            await Task.Delay(2000);
            return "Download complete: [Data payload received]";
        }
    }
}