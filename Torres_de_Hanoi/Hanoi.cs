using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public static int m = 0;

        public static void mover_disco(Pila a, Pila b)
        {
            // Si no estan vacias las dos mover el mas pequeño encima de uno superior
           
            if (!a.isEmpty() || !b.isEmpty())
            {
                if (a.TopCheck(b))
                {
                    a.push(b.pop());
                }
               
                else
                {
                    b.push(a.pop());
                }
            }
        }

        public static int Iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            bool state = true;
            int m = 0;
        
            while (state)
            {

                if (n % 2 == 0)
                {                    
                    mover_disco(ini, aux);
                    m++;
                    state = ini.OrderCheck(n);
                    state = aux.OrderCheck(n);
                    if (state)
                    {
                        mover_disco(ini, fin);
                        m++;
                        state = fin.OrderCheck(n);
                    }
                    if (state)
                    {
                        mover_disco(aux, fin);
                        m++;
                        state = fin.OrderCheck(n);
                    }
                }
                else
                {
                    mover_disco(ini, fin);
                    m++;

                    state = fin.OrderCheck(n);
                    if (state)
                    {
                        mover_disco(ini, aux);
                        m++;

                        state = aux.OrderCheck(n);
                    }
                    if (state)
                    {
                        mover_disco(aux, fin);
                        m++;

                        state = fin.OrderCheck(n);
                    }
                }
            }
          
            return m;
        }

        public static int Recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
          
            if (n == 1) // Solo hay uno XD
            {
                m++;
                mover_disco(ini, fin);
            }
            else
            {
                Recursivo(n-1, ini, aux, fin);
                m++;
                mover_disco(ini, fin);
                Recursivo(n-1, aux, fin, ini);
            }
            
            return m;
        }

        
    }
}
