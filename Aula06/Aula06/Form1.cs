using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula06
{
    public partial class Form1 : Form
    {
        Quadrado q = new Quadrado();
        Triangulo t = new Triangulo();
        Retangulo r = new Retangulo();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            q.Lado = Convert.ToInt32(textBoxLadoQuadrado.Text);
            q.CalcularArea();
            q.CalcularPerimetro();
            labelAreaQuadrado.Text = "A área do quadrado é " + q.Area + " metro(s) quadrado(s)";
            labelPerimetroQuadrado.Text = "O perímetro do quadrado é " + q.Perimetro + "metro(s)"; 
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonTriangulo_Click(object sender, EventArgs e)
        {
            t.Lado = Convert.ToInt32(textBoxLadoTriangulo.Text);
            t.Altura = Convert.ToInt32(textBoxAlturaTriangulo.Text);
            t.CalcularArea();
            t.CalcularPerimetro();
            labelAreaTriangulo.Text = "A área do triângulo é " + t.Area + " metro(s) quadrado(s)";
            labelPerimetroTriangulo.Text = "O perímetro do triângulo é " + t.Perimetro + "metro(s)";
        }

        private void textBoxLadoTriangulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRetangulo_Click(object sender, EventArgs e)
        {
            r.Lado = Convert.ToInt32(textBoxLadoRetangulo.Text);
            r.Altura = Convert.ToInt32(textBoxAlturaRetangulo.Text);
            r.CalcularArea();
            r.CalcularPerimetro();
            labelAreaRetangulo.Text = "A área do retângulo é " + r.Area + " metro(s) quadrado(s)";
            labelPerimetroRetangulo.Text = "O perímetro do retângulo é " + r.Perimetro + "metro(s)";
        }
    }
}
