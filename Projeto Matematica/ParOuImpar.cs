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
    public partial class ParOuImpar: Form
    {
        public ParOuImpar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abertura abertura = new Abertura();
            abertura.Show();
            this.Close();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)

        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Só é Permitido Digitar Números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13)
            {
                if (int.TryParse(txtNumero.Text, out int numero))
                {
                    if (numero % 2 == 0)
                    {
                        MessageBox.Show($"Número {txtNumero.Text} é Par");
                   
                    }
                    else
                    {
                        MessageBox.Show($"Número {txtNumero.Text} é Impar");
                     
                    }
                    txtNumero.Clear();
                    txtNumero.Focus();
                }
                else
                {
                    MessageBox.Show("Digite um número Válido");
                }

            }
            
        }
    }
}
