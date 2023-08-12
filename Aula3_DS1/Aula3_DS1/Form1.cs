using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula3_DS1
{
    public partial class Form1 : Form
    {   
        SomaQuadrados soma1 = new SomaQuadrados();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            soma1.N1 = Convert.ToDouble(textBoxN1.Text);
            soma1.N2 = Convert.ToDouble(textBoxN2.Text);
            soma1.N3 = Convert.ToDouble(textBoxN3.Text);
            labelResultado.Text = soma1.CalcularSomaQuadrados();
        }
    }
}
