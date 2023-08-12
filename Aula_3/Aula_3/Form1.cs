using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_3
{
    public partial class Form1 : Form
    {
        Aluno aluno1 = new Aluno();
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculaMedia_Click(object sender, EventArgs e)
        {
            aluno1.Nome = txtNome.Text;
            aluno1.Nota1 = Convert.ToDouble(txtNota1.Text);
            aluno1.Nota2 = Convert.ToDouble(txtNota2.Text);
            labelVeja.Text = aluno1.CalcularMedia();
        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
