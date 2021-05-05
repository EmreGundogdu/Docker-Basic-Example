using System;

namespace ConsoleDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<10000)
            {
                Console.WriteLine(i);
                i++;
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
