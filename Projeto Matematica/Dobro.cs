﻿using System;
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
    public partial class Dobro: Form
    {
        public Dobro()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {

            Abertura abertura = new Abertura();
            abertura.Show();
            this.Close();


        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '-'))
			{
                e.Handled = true;
                MessageBox.Show("Só é Permitido Digitar Números!!!", "Aviso",MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
           
			if (e.KeyChar == 13)
				{

					if (int.TryParse(txtNumero.Text, out int numero))
					{
						int dobro = numero * 2;
						MessageBox.Show($"Dobro de {txtNumero.Text} é {dobro}");
						txtNumero.Clear();
						txtNumero.Focus();
					}
					else
					{
						MessageBox.Show("Digite um Número Válido");

					}


			}
			
        }
        }
    }
