using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Matematica
{
    public partial class Abertura: Form
    {
        public Abertura()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radDobro_CheckedChanged(object sender, EventArgs e)
        {
            Dobro dobro = new Dobro();
            dobro.Show();
            Hide();

        }

        private void radParImpar_CheckedChanged(object sender, EventArgs e)
        {
            ParOuImpar parImpar = new ParOuImpar();
            parImpar.Show();
            Hide();
        }

        private void radPositivoNegativo_CheckedChanged(object sender, EventArgs e)
        {
            PositivoNegativo positivonegatovo = new PositivoNegativo();
            positivonegatovo.Show();
            Hide();
        }

        private void radAntecessorSucessor_CheckedChanged(object sender, EventArgs e)
        {
			AntecessorSucessor antecessorSucessor = new AntecessorSucessor();
			antecessorSucessor.Show();
			Hide();
		}

        private void radCalculadora_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.Show();
            Hide();
        }
    }
}
