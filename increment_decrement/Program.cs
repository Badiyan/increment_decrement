using System;
using System.Diagnostics;

namespace increment_decrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var timer1 = new Stopwatch();
            var timer2 = new Stopwatch();
            var timer3 = new Stopwatch();
            var timer4 = new Stopwatch();
            var timer5 = new Stopwatch();

            timer1.Start();
            int postfix = 1;

            for (int i = 0; i < 1000000000; i++)
            {
                postfix++;
            }

            timer1.Stop();

            TimeSpan timeTaken1 = timer1.Elapsed;

            timer2.Start();
            int prefix = 1;

            for (int j = 0; j < 1000000000; j++)
            {
                ++prefix;
            }

            timer2.Stop();

            TimeSpan timeTaken2 = timer2.Elapsed;

            timer3.Start();
            int increment = 1;

            for (int x = 0; x < 1000000000; x++)
            {
                increment += 1;
            }

            timer3.Stop();

            TimeSpan timeTaken3 = timer3.Elapsed;

            timer4.Start();
            int decrement = 1000000001;

            for (int y = 0; y < 1000000000; y++)
            {
                decrement -= 1;
            }

            timer4.Stop();

            TimeSpan timeTaken4 = timer4.Elapsed;

            timer5.Start();
            int increment2 = 1;

            for (int z = 0; z < 1000000000; z++)
            {
                increment2 = increment2 + 1;
            }

            timer5.Stop();

            TimeSpan timeTaken5 = timer5.Elapsed;

            Console.WriteLine("Postfix n++ time taken:" + timeTaken1.ToString(@"m\:ss\.fff"));
            Console.WriteLine("Prefix ++n time taken:" + timeTaken2.ToString(@"m\:ss\.fff"));
            Console.WriteLine("Increment += time taken:" + timeTaken3.ToString(@"m\:ss\.fff"));
            Console.WriteLine("Increment n = n + 1 time taken:" + timeTaken5.ToString(@"m\:ss\.fff"));
            Console.WriteLine("Decrement -= time taken:" + timeTaken4.ToString(@"m\:ss\.fff"));
            Console.ReadKey();


        }
    }
}
