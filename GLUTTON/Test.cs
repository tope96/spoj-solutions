using System;

class Test
    {
        static void Main(string[] args)
        {
            int times = int.Parse(System.Console.ReadLine());
 
            for(int i = 0; i< times; i++)
            {
                double sum = 0;
 
                String input = Console.ReadLine();
                String[] tab = input.Split(null);
                int[] inputInt = Array.ConvertAll<String, int>(tab, int.Parse);
 
 
                for(int a = 0; a < inputInt[0]; a++)
                {
                    double secondsToOne = int.Parse(Console.ReadLine());
                    double numCookies = 86400 / secondsToOne;
                    numCookies = Math.Floor(numCookies);
                    sum = numCookies + sum;
                }
                System.Console.WriteLine(Math.Ceiling(sum/inputInt[1]));
            }
            Console.ReadLine();
        }
    }
