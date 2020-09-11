using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoClipper
{
    class Matematica
    {
        public static int Fatorial(int numero) {
            int controlador = numero;
            int numero2 = numero;
            for (int i = 1; i <= controlador; i++) {
                numero = numero * numero2;
                numero2--;
            }
            return numero;
        }
    }
}
