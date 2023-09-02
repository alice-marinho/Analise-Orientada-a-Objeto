using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSabado
{
    public static class Matematica
    {
        public static string Quadrado (int numero)
        {
            int quadrado = (numero * numero);
            return quadrado.ToString();
        }

        public static string Potencia( int b, int e)
        {
            int numero = b;
            int potencia = 1;

            for (int i = 1; i <= numero; i++)
            {
                potencia *= numero;
            }
            return potencia.ToString();
        }
    }
}
