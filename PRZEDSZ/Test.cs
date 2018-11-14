using System;
using System.Collections.Generic;
class Test
    {
        static void Main(string[] args)
        {
            int setCount = int.Parse(System.Console.ReadLine());

            List<int> lista = new List<int>();

            for(int i = 0; i < setCount; i++)
            {
                String input = System.Console.ReadLine();
                int najwieksza = 0;
                int najmniejsza = 0;
                String[] tab = input.Split(null);
                try
                {
                    int[] convert = Array.ConvertAll<String, int>(tab, int.Parse);
                    if(convert[1] == 0)
                    {

                        Environment.Exit(0);
                    }
                    int pierwsza = convert[0];
                    int druga = convert[1];
                    while (pierwsza != druga)
                    {
                        if (pierwsza >= druga)
                        {
                            pierwsza -= druga;
                        }
                        else
                        {
                            druga -= pierwsza;
                        }
                    }
              
                    lista.Add((convert[0] * convert[1]) / pierwsza);
        
               }
               catch
              {
                    
                }
               
            }

            foreach(int wynik in lista)
            {
                System.Console.WriteLine(wynik);
            }
            System.Console.ReadLine();
        }
    }
