using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {      
        public int Size { get; set; }
        public int Top { get; set; }
        public List<Disco> Elementos { get; set; }

        public Pila()
        {
            this.Elementos = new List<Disco>();
            this.Size = 0;
        }

        //Añade un disco a una pila
        public void push(Disco d)
        {
            this.Elementos.Add(d);
            this.Size++;
            this.Top = d.get();
        }

        //Quitar un disco de una pila
        public Disco pop()
        {
            this.Size--;
            Disco d = this.Elementos[(this.Elementos.Count - 1)];
            if ((this.Elementos.Count - 1) > 0) this.Top = this.Elementos[(this.Elementos.Count - 2)].get(); // YA que quitas 1 y es el siguiente
            this.Elementos.RemoveAt(this.Elementos.Count - 1);
            return d;
        }

        public bool isEmpty()
        {
            if (this.Elementos.Count == 0) return true;
            return false;
        }

        public bool TopCheck(Pila b)
        {
            if (this.isEmpty() && !b.isEmpty()) return true;
            else if (!this.isEmpty() && b.isEmpty()) return false;
            else if (this.Top < b.Top) return true;
            else return false;
            
        }

        public bool OrderCheck(int total)
        {
            int bigger = total - 1;
            int order = 0;
          
            for (int i = this.Elementos.Count - 1; i >= 0; i--)
            {
                if (this.Elementos[i].get() == bigger)
                {
                    order++;
                    bigger--;
                }
            }
            // si estan todos ordenados ....
            if (order == total)
            {
                return false;
            }
            // no estan todos ordenados
            return true;
        }
    }
}
