using System;

class Test
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
 
            if (first > 200 && second > 200)
            {
                Environment.Exit(200);
            }
            else
            {
                Console.WriteLine(first + second);
            }
            }
    }
