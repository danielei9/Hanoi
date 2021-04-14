using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            for(; ; ) { 
            Console.WriteLine("¿Cuantos Discos?");
            int n = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Selecciona... \n 1 -> Iterativo \n 2 -> Recursivo \n 3 -> Formula");
            int select = Convert.ToInt32(Console.ReadLine());
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();

            for (int i = 0; i < n; i++)
            {
                Disco d = new Disco();
                d.set(i);
                ini.push(d);
            }

            switch (select)
            {
                case 1:
                    Console.WriteLine("Iterativo M = " + Hanoi.Iterativo(n, ini, aux, fin));
                    break;
                case 2:
                    Console.WriteLine("Recursivo M = " + Hanoi.Recursivo(n, ini, aux, fin));
                    break;
                case 3:
                    int resolverNum = Convert.ToInt32(Math.Pow(2, n) - 1); // 2^n-1
                    Console.WriteLine("Formula M = " + resolverNum);
                    break;

             }
          Console.ReadLine();
           }
        }
    }
}
