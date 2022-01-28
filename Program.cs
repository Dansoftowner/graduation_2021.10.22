using System;

namespace LifeOrDeath11A
{
    class Program
    {
        static void Main(string[] args)
        {
            var lod = new LifeOrDeathSimulation(15, 10, m => {
                m[4, 6] = 1;
                m[5, 6] = 1;
                m[6, 6] = 1;
            });

           
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                lod.Run();
            }
            Console.ReadKey();
        }
    }
}
