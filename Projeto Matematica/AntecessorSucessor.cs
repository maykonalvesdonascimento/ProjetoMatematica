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
    public partial class AntecessorSucessor: Form
    {
        public AntecessorSucessor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abertura abertura = new Abertura();
            abertura.Show();
            Hide();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '-'))
			{
                e.Handled = true;
                MessageBox.Show("Só é Permitido Digitar Números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13) {
                if (int.TryParse(txtNumero.Text, out int numero))
                {
                    lblantecessor.Text = (numero-1).ToString();
                    lblsucessor.Text = (numero+1).ToString();   

                }
                else {


                    limpezaTXT(false);
                }
            
            }
        }

        private void btnAntecessor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumero.Text))
            {
                if (int.TryParse(txtNumero.Text, out int numero))
                {

                    SucessorOuAntecessor(numero, true);
                }
                else
                {


                    limpezaTXT(false);


                }
             
            }
            else {
                limpezaTXT(false);
            }
        }

        private void btnSucessor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumero.Text))
            {
                if (int.TryParse(txtNumero.Text, out int numero))
                {
                    SucessorOuAntecessor(numero, false);
                }
                else
                {

                    limpezaTXT(false);


                }
               
            }
            else
            {
                limpezaTXT(false);
            }
        }

        public void SucessorOuAntecessor(int numero , bool antecessor) {
            if (antecessor)
            {
                numero = numero - 1;
            }
            else {
                numero = numero + 1;
            }
            txtNumero.Text = numero.ToString();
            lblantecessor.Text = (numero - 1).ToString();
            lblsucessor.Text = (numero + 1).ToString();
        }

        public void limpezaTXT(bool botao) {
            if (!botao)
            {
                MessageBox.Show("Digite um número válido");
            }
            txtNumero.Clear();
            txtNumero.Focus();
            lblantecessor.Text = "?";
            lblsucessor.Text = "?";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            limpezaTXT(true);
        }
    }
}
