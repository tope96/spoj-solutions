using System;

 class Test
    {
        static void Main(string[] args)
        {
            int ileRazy = int.Parse(Console.ReadLine());

            for(int i = 0; i < ileRazy; i++)
            {
                String input = Console.ReadLine();
                String[] tab = input.Split(null);
                int it = 0;

                for(int a = 2; a<=tab.Length-1; a++)
                {
                    Console.Write(tab[a] + " ");
                }
                Console.Write(tab[1] + " ");
            }
        }
    }
