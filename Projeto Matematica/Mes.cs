using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Matematica
{
    public partial class Mes : Form
    {
        public Mes()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13) {

                for (int i = 1; i < 13; i++) {
                    Panel painelSelecionado = (Panel)this.Controls[$"panel{i}"];
                    painelSelecionado.Visible = false;

                }
                if (int.TryParse(textBox1.Text, out int val))
                {
                    if (val > 0 && val < 13)
                    {

                        Panel painelSelecionado = (Panel)this.Controls[$"panel{val}"];
                        painelSelecionado.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Digite um mês válido");
                    }
                }
                else {

                    MessageBox.Show("Digite um número válido");
                }


            }
            }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Abertura abertura = new Abertura();
            abertura.Show();
            Hide();
        }
    }
}
