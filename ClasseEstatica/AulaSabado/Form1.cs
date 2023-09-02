using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaSabado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcularQuadrado_Click(object sender, EventArgs e)
        {
            labelQuadradoResult.Text = "Quadrado: "+ Matematica.Quadrado(Convert.ToInt32(textBoxQuadrado.Text));
        }

        private void buttonCalcularPotencia_Click(object sender, EventArgs e)
        {
            labelPotencia.Text = "Potência: " + Matematica.Potencia(Convert.ToInt32(textBoxBase.Text), Convert.ToInt32(textBoxExpoente.Text));
        }

        private void buttonFahrenheit_Click(object sender, EventArgs e)
        {
            labelConvertido.Text = "Temperatura convertida: " + Temperatura.Fahrenheit(Convert.ToDouble(textBoxTemperatura.Text));
        }

        private void btCelsius_Click(object sender, EventArgs e)
        {
            labelConvertido.Text = "Temperatura convertida: " + Temperatura.Celsius(Convert.ToDouble(textBoxTemperatura.Text));
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "R: " + Calculo.Soma(Convert.ToInt32(textBoxValor1.Text), Convert.ToInt32(textBoxValor2.Text));
        }

        private void buttonSubstracao_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "R: " + Calculo.Subtracao(Convert.ToInt32(textBoxValor1.Text), Convert.ToInt32(textBoxValor2.Text));
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "R: " + Calculo.Multiplicacao(Convert.ToInt32(textBoxValor1.Text), Convert.ToInt32(textBoxValor2.Text));
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "R: " + Calculo.Divisao(Convert.ToInt32(textBoxValor1.Text), Convert.ToInt32(textBoxValor2.Text));
        }
    }
}
