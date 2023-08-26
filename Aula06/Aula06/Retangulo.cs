using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    internal class Retangulo : Forma
    {
        private double lado;
        private double altura;
        public double Lado
        {
            get
            { return lado; }
            set
            { lado = value; }
        }
        public double Altura
        {
            get
            { return altura; }
            set
            { altura = value; }
        }
        public override void CalcularArea()
        {
            this.Area = lado * altura;
        }
        public override void CalcularPerimetro()
        {
            this.Perimetro = 2 * lado + 2 * altura;
        }
    }
}
