using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    internal class Inmutable
    {
        public readonly int valor;
        public Inmutable(int valor)
        {
            this.valor = valor;
        }

        void cambiarValor()
        {
            //valor = 15; // No se puede modificar un readonly
        }
    }
}
