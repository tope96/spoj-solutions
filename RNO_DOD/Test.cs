using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Test
    {
        static void Main(string[] args)
        {
            string liczbaPowtorzen;
            liczbaPowtorzen = System.Console.ReadLine();

            int liczbaP = int.Parse(liczbaPowtorzen);

            List<int> lista = new List<int>();

            for(int i = 0; i<=liczbaP-1; i++)
            {
                int suma = 0;
                System.Console.ReadLine();
                
                String liczby = System.Console.ReadLine();
                string[] tab = liczby.Split(null);

              for(int a = 0; a<=tab.Length-1; a++)
                {
                    int b = int.Parse(tab[a]);
                    suma += b ;
                }
                lista.Add(suma);
            }

            foreach(int suma in lista)
            {
                System.Console.WriteLine(suma);
            }
        
        }
    }
