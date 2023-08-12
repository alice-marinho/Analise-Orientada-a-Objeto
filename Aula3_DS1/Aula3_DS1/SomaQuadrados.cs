using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_DS1
{
    internal class SomaQuadrados
    {
        private double n1;
        private double n2;
        private double n3;

        //construtor

        public SomaQuadrados()
        {
            n1 = 0.00;
            n2 = 0.00;
            n3 = 0.00;
        }

        //propriedades
        
        public double N1
        {
            get { return n1; }
            set { n1 = value; }
        }

        public double N2
        {
            get { return n2; }
            set { n2 = value; }
        }

        public double N3
        {
            get { return n3; }
            set { n3 = value; }
        }

        //métodos

        public string CalcularSomaQuadrados()
        {
            double var;
            var = Math.Pow(n1, 2) + Math.Pow(n2, 2) + Math.Pow(n3, 2);
            return var.ToString("n1");

        }
    }
}
