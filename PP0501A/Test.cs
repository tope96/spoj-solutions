using System;

 class Test
    {
        public int nwd(int a, int b)
        {
                int first = a;
                int second = b;
                
                if (b == 0)
                {
                    Environment.Exit(0);
                }
                
                while (first != second)
                {
                    if (first >= second)
                    {
                        first -= second;
                    }
                    else
                    {
                        second -= first;
                    }
                }
                return first;
            }


    static void Main(string[] args)
    {
        int setCount = int.Parse(System.Console.ReadLine());

        for (int i = 0; i < setCount; i++)
        {
            String input = System.Console.ReadLine();
            String[] tab = input.Split(null);
            int[] convert = Array.ConvertAll<String, int>(tab, int.Parse);

            int a = convert[0];
            int b = convert[1];
               
            Test prog = new Test();
            System.Console.WriteLine(prog.nwd(a, b));

        }

    }
}
