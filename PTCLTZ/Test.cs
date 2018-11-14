using System;

class Test
    {
        int Even(int s)
        {
            return s/2;
        }
 
        int NotEven(int s)
        {
            return 3*s+1;
        }
 
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
 
            for (int i = 0; i < times; i++)
            {
                int s = int.Parse(Console.ReadLine());
                int n = 0;
                Test prog = new Test();
 
                while (s != 1)
                {
                    if(s%2 == 0)
                    {
                        n++;
                        s = prog.Even(s);
                    }else if(s%2 != 0)
                    {
                        n++;
                        s = prog.NotEven(s);
                    }
                }
                Console.WriteLine(n);
            }
        }
    }
