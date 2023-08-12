using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_DS2
{
    //atribuindo
    internal class AntecessorSucessor
    {
        private int numero;

        //construtor 

        public AntecessorSucessor()
        {
            numero = 0;
        }

        //propriedades

        public int Numero
        {
            get { return numero;  }
            set { numero = value;  }
        }

        //métodos

        public int CalcularAntecessor()
        {
            return numero - 1;
        }

        public int CalcularSucessor()
        {
            return numero + 1;
        }
    }
}
