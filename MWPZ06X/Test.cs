using System;

class Test
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
 
            for(int i = 0; i<times; i++)
            {
                int side = int.Parse(Console.ReadLine());
                Console.WriteLine(side * side);
            }
        }
    }
