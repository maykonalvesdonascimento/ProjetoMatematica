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
    public partial class Eleicoes: Form
    {
        public Eleicoes()
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
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("Só é Permitido Digitar Números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (e.KeyChar == 13)
			{
				if (int.TryParse(txtNumero.Text, out int idade))
				{
					if (idade < 16)
					{
						MessageBox.Show("Não pode votar");

					}
					else if (idade >= 18 && idade <= 75)
					{
						MessageBox.Show("Pode votar");
					}
					else {
						MessageBox.Show("Voto facultativo");
					}
				}
				else
				{
					MessageBox.Show("Digite um número Válido");
				}

			}
		}
    }
}
