using System;
using System.Threading;

namespace question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread (Mulitply);         
            thread.Start();                              
            thread.Join();
            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine(i + " X 15 = " + (i * 15));
            }

        }
 
        static void Mulitply()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + " X 10 = " + (i * 10));
            }
        }
    }
}