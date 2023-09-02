using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSabado
{
    public static class Temperatura
    {
        //celsius pra fahrenheit
        public static string Fahrenheit(double temperatura)
        {
            return (1.8 * temperatura + 32).ToString("N2");
        }

        //fahrenheit pra celsius
        public static string Celsius(double temperatura)
        {
            return ((temperatura - 32)/1.8).ToString("N2");
        }
    }
}
