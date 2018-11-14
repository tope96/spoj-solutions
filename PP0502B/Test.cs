using System;

class Test
    {
        static void Main(string[] args)
        {
            int ileRazy = int.Parse(System.Console.ReadLine());
 
            for(int i = 0; i<ileRazy; i++)
            {
                String input = System.Console.ReadLine();
                String[] inputS = input.Split(null);
                int[] inputInt = Array.ConvertAll<String, int>(inputS, int.Parse);
 
 
                int zmienna = inputInt[0];
 
                while(zmienna != 0)
                {
                    if (zmienna == 1)
                    {
                        System.Console.Write(inputInt[zmienna]);
                        System.Console.WriteLine();
                        zmienna = zmienna - 1;
                    }
                    else
                    {
                        System.Console.Write(inputInt[zmienna] + " ");
                        zmienna = zmienna - 1;
                    }
                }
 
            }
 
        }
    }
