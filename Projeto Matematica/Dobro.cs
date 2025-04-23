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
    }
}
