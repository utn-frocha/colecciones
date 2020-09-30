using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaSimple
{
    class Nodo
    {
        private Nodo siguiente;
        private int dato;

         public int Dato 
        { 
            get { return this.dato; }
            set { dato = value; }
        }

        public Nodo Siguiente
        {
            get { return this.siguiente; }
            set { this.siguiente = value; }
        }


    }
}
