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
    public partial class Calculadora: Form
    {

        public double numero1;
        public double resultado;
        public bool vazio = true;
        public string op = "";
       
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Abertura abertura = new Abertura();
            abertura.Show();
            Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (vazio)
            {
                txtResultado.Text = "1";
                vazio = false;
            }
            else {
                txtResultado.Text = txtResultado.Text + "1";
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (vazio)
            {
                txtResultado.Text = "2";
                vazio = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (vazio)
            {
                txtResultado.Text = "3";
                vazio = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (vazio)
            {
                txtResultado.Text = "4";
                vazio = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (vazio)
            {
                txtResultado.Text = "5";
                vazio = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (vazio)
            {
                txtResultado.Text = "6";
                vazio = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (vazio)
            {
                txtResultado.Text = "7";
                vazio = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (vazio)
            {
                txtResultado.Text = "8";
                vazio = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (vazio)
            {
                txtResultado.Text = "9";
                vazio = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "9";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            vazio = true;
            numero1 = 0;
            resultado = 0;

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtResultado.Text, out double numero))
            {
                if (op == "")
                {
                    op = "+";
                    numero1 = numero;
                    txtResultado.Text = "0";

                }
                else if (op == "+")
                {
                    resultado = resultado + numero1;
                    txtResultado.Text = resultado.ToString();
                }

            }
            else { 

                MessageBox.Show("Numero inválido"); 
            }
             
   

            

        }
    }
}
