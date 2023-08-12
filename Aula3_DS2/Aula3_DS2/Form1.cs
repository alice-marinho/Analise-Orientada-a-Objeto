using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3_DS2
{
    
    public partial class Form1 : Form
    {   
        AntecessorSucessor numero1 = new AntecessorSucessor();
        public Form1()
        { 
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            numero1.Numero = Convert.ToInt32(textBoxNumero.Text);
            labelAntecessor.Text = Convert.ToString(numero1.CalcularAntecessor());
            labelSucessor.Text = Convert.ToString(numero1.CalcularSucessor());
        }
    }
}
