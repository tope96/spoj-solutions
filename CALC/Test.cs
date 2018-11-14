using System;

 class Test
    {
        static void Main(string[] args)
        {

            for (; ; ) { 
                String input = Console.ReadLine();
                if (input == null || input.Length < 1)
                {
                    break;
                }
                else
                {
                    String[] inputTab = input.Split(null);

                    if (inputTab[0] == "+")
                    {
                        Console.WriteLine(int.Parse(inputTab[1]) + int.Parse(inputTab[2]));

                    }
                    else if (inputTab[0] == "*")
                    {
                        Console.WriteLine(int.Parse(inputTab[1]) * int.Parse(inputTab[2]));
                    }
                    else if (inputTab[0] == "/")
                    {
                        Console.WriteLine(int.Parse(inputTab[1]) / int.Parse(inputTab[2]));
                    }
                    else if (inputTab[0] == "-")
                    {
                        Console.WriteLine(int.Parse(inputTab[1]) - int.Parse(inputTab[2]));
                    }
                    else if (inputTab[0] == "%")
                    {
                        Console.WriteLine(int.Parse(inputTab[1]) % int.Parse(inputTab[2]));
                    }
                }
            }
        }
    }
