using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        /*TODO: 
        Decidir tipo de Valor
        public int Valor { get; set; }
        public String Valor { get; set; }
        */

        private int Valor;

        public Disco(int n)
        {
            Valor = n;
        }
        public Disco()
        {
            Valor = 0;
        }
        public int get()
        {
            return Valor;
        }
        public void set(int n)
        {
            Valor = n;
        }
    }
}
