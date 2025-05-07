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
    public partial class Area : Form
    {
        string[,] lados = { { "Lado", "Lado", "" }, { "Altura", "Base", "" }, { "Altura", "Base", "" }, { "Base Maior", "Base Menor", "Altura" }, { "Diagonal Maior", "Diagonal Menor", "" }, { "Raio", "", "" } };
        int qtdCampos;
        int formaEscolhida;

        public Area()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Abertura abertura = new Abertura();
            abertura.Show();
            Hide();
        }
        public void preencherForm(int forma, int campos)
        {

            limpar();
            qtdCampos = campos;
            formaEscolhida = forma;

            string imagemForma = "forma" + (forma + 1).ToString();
            var imagem = (Image)Properties.Resources.ResourceManager.GetObject(imagemForma);
            picFormas.Image = imagem;


            txtValor1.Visible = true;
            lblValor1.Visible = true;
            lblValor1.Text = lados[forma, 0];

            if (campos != 1)
            {
                txtValor2.Visible = true;
                lblValor2.Visible = true;
                lblValor2.Text = lados[forma, 1];
            }
            if (campos == 3)
            {
                txtValor3.Visible = true;
                lblValor3.Visible = true;
                lblValor3.Text = lados[forma, 2];
            }

        }

        public void limpar()
        {
            txtValor1.Visible = false;
            txtValor2.Visible = false;
            txtValor3.Visible = false;
            lblValor1.Visible = false;
            lblValor2.Visible = false;
            lblValor3.Visible = false;
            txtValor1.Text = "0";
            txtValor2.Text = "0";
            txtValor3.Text = "0";
            lblResultado.Text = "Área:";
        }

        private void radForma1_CheckedChanged(object sender, EventArgs e)
        {
            preencherForm(0, 1);
        }

        private void radForma2_CheckedChanged(object sender, EventArgs e)
        {
            preencherForm(1, 2);
        }

        private void radForma3_CheckedChanged(object sender, EventArgs e)
        {
            preencherForm(2, 2);
        }

        private void radForma4_CheckedChanged(object sender, EventArgs e)
        {
            preencherForm(3, 3);
        }
        private void radForma5_CheckedChanged(object sender, EventArgs e)
        {
            preencherForm(4, 2);
        }

        private void radForma6_CheckedChanged(object sender, EventArgs e)
        {
            preencherForm(5, 1);
        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);

            if (e.KeyChar == 13)
            {
                if (qtdCampos == 1)
                {
                    if (double.TryParse(txtValor1.Text, out double numero))
                    {
                        double area;
                        if (formaEscolhida == 0)
                        {
                            area = numero * numero;
                        }
                        else
                        {
                            area = 3.14 * (numero * numero);
                        }

                        lblResultado.Text = $"Área: {area}";
                    }
                    else
                    {
                        MessageBox.Show("Erro Número inválido");
                    }

                }
                else
                {
                    txtValor2.Focus();
                }
            }
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);

            if (e.KeyChar == 13)
            {
                if (qtdCampos == 2)
                {
                    double area;
                    if (double.TryParse(txtValor1.Text, out double numero1) && double.TryParse(txtValor2.Text, out double numero2))
                    {


                        if (formaEscolhida == 1 || formaEscolhida == 4)
                        {
                            area = (numero1 * numero2) / 2;

                            
                        }
                        else { 
                            area = numero1 * numero2;
                        
                        }
                        lblResultado.Text = $"Área: {area}";
                    }
                    else
                    {
                        MessageBox.Show("Erro Número inválido");
                    }
               
                   
                }
                else
                {
                    txtValor3.Focus();
                }
            }
        }

        private void txtValor3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((double.TryParse(txtValor1.Text, out double baseMaior)) && (double.TryParse(txtValor2.Text, out double baseMenor)) && (double.TryParse(txtValor3.Text, out double altura)))
            {
                double area = ((baseMaior + baseMenor) * altura) / 2;

                lblResultado.Text = $"Área: {area}";

            }
            else {
                MessageBox.Show("Erro Número inválido");

            }
                Program.IntNumber(e);
        }


    }
    
}
