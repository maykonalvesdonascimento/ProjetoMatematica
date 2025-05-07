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
        public double numero2;
        public double resultado;
        public bool vazio = true;
        public string op = "";
        public bool naoRepetido = true;
        public int cont = 0;
        public int virgula = 0;

       
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

        private void btn0_Click(object sender, EventArgs e)
        {
            pressionarBotoes("0");
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            pressionarBotoes("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pressionarBotoes("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pressionarBotoes("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pressionarBotoes("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pressionarBotoes("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pressionarBotoes("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pressionarBotoes("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pressionarBotoes("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pressionarBotoes("9");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text="0";
            vazio = true;
            numero1 = 0;
            resultado = 0;
            virgula= 0;

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {

            operacoes("+");

        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            operacoes("-");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            operacoes("*");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operacoes("/");
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (op == "+")
            {
                operacoes("+");
            }
            else if (op == "-")
            {
                operacoes("-");
            }
            else if (op == "*")
            {
                operacoes("*");
            }
            else if (op == "/")
            {
                operacoes("/");
            }

        }

        public void operacoes(string operacao)
        {
            if (double.TryParse(txtResultado.Text, out double numero))
            {
                if (op != operacao)
                {
                    op = operacao;
                    numero1 = numero;
                    resultado = 0;
                    naoRepetido = true;
                    virgula = 0;

                }
                else if (op == operacao && txtResultado.Text == "0")
                {

                    if (operacao == "+")
                    {
                        resultado = resultado + numero1;
                    }
                    else if (operacao == "-")
                    {
                        resultado = resultado - numero1;
                    }
                    else if (operacao == "*")
                    {
                        resultado = resultado * numero1;
                    }
                    else if (operacao == "/")
                    {
                        if (numero1 == 0)
                        {

                        }
                        else { 

                            resultado = resultado / numero1;
                        }
                    }
                }
                else
                {
                    if (naoRepetido)
                    {
                        if (cont == 0)
                        {
                            numero2 = numero;
                            resultado = numero1;
                            numero1 = numero2;
                        
                            cont++;
                        }
                        numero1 = numero;
                        naoRepetido = false;


                  
                    }

                    if (operacao == "+")
                    {
                        numero2 = numero;
                        resultado = resultado + numero1;
                    }
                    else if (operacao == "-")
                    {

                        resultado = resultado - numero1;
                    }
                    else if (operacao == "*")
                    {
                        resultado = resultado * numero1;
                    }
                    else if (operacao == "/") {
                        resultado = resultado/ numero1;
                    }

                


                   
                }
                vazio = true;
                txtResultado.Text = resultado.ToString();

            }
            else
            {

                MessageBox.Show("Numero inválido");
            }
        }



        public void pressionarBotoes(string num) {

            if (vazio)
            {
                if (txtResultado.Text == "0,")
                {
                    txtResultado.Text = txtResultado.Text + num;
                }
                txtResultado.Text = num;
                vazio = false;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + num;
            }
            naoRepetido = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(virgula == 0)
            {

                txtResultado.Text = txtResultado.Text + ",";
                virgula++;

                if (txtResultado.Text == "0") {
                    vazio = false;
                }
            }
        }

        private void btnponto_Click(object sender, EventArgs e)
        {
            if (virgula == 0)
            {

                txtResultado.Text = txtResultado.Text + ",";

                virgula++;

            }
        }
    }
}
