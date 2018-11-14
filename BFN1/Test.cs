using System;

class Test
    {
        
        int Palindrom(int liczba)
        {
          
            int left = liczba;
            int rev = 0, r = 0;
            while (left > 0)
            {
                r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;  //left = Math.floor(left / 10); 
            }

           
            return rev;
        }

        static void Main(string[] args)
        {
            int ileRazy = int.Parse(System.Console.ReadLine());
            

            if (ileRazy <= 80)
            {
                for (int i = 0; i < ileRazy; i++)
              
                {
                    int c = 0;
                    String input = System.Console.ReadLine();

                    try
                    {
                        int inputInt = int.Parse(input);
                        Test prog = new Test();
                        if (inputInt >= 1 && inputInt <= 80)
                        {
                            if (inputInt == prog.Palindrom(inputInt))
                            {
                                System.Console.WriteLine(inputInt + " " + 0);
                            }
                            else
                            {
                                while (inputInt != prog.Palindrom(inputInt))
                                {
                                    c++;
                                    inputInt = prog.Palindrom(inputInt) + inputInt;
                                }
                                System.Console.WriteLine(inputInt + " " + c);
                            }

                        }
                        else
                        {
                            Environment.Exit(666);
                        }
                    }
                    catch
                    {

                    }

                }
            }
            else
            {
                Environment.Exit(666);
            }
        }
    }
