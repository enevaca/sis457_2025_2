using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    internal class Generico<T, U, V>
    {
        public T campo1;
        public U campo2;
        public V campo3;

        public T imprimir(T campo)
        {
            Console.WriteLine($"Método genérico {campo}");
            return campo;
        }
    }
}
