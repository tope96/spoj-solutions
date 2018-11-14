using System;

class Test
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
 
            for(int i = 0; i<times; i++)
            {
                String word = Console.ReadLine();
 
                var characters = word.ToCharArray();
 
                for(int a = 0; a<=(characters.Length/2)-1; a++)
                {
                    Console.Write(characters[a]);
                }
                Console.WriteLine();
 
            }
        }
    }
