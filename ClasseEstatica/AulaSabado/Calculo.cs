using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSabado
{
    public static class Calculo
    {
        public static string Soma(int a, int b)
        {
            return (a + b).ToString();
        }

        public static string Subtracao(int a, int b)
        {
            return (a - b).ToString();
        }

        public static string Multiplicacao(int a, int b)
        {
            return (a * b).ToString();
        }

        public static string Divisao(int a, int b)
        {
            return (a / b).ToString();
        }
    }
}
