using System;

namespace LifeOrDeath11A
{
    class Program
    {
        static void Main(string[] args)
        {
            var lod = new LifeOrDeathSimulation(12, 12);
            lod.Print();
            Console.ReadKey();
        }
    }
}
