using System;
using System.Threading.Tasks;
using FishFish;

namespace Example
{
    public static class Program
    {
        public static async Task Main()
        {
            await Task.CompletedTask;
            FishFishClient fish = new();

            Console.WriteLine("Demo finished.");
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}