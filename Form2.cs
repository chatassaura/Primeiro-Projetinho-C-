using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class frmCalcularIdade : Form
    {
        public frmCalcularIdade()
        {
            InitializeComponent();
        }

        private void calcularIdade(object sender, EventArgs e)
        {
            int anoNasc = Convert.ToInt32(txtNascimento.Text);
            int anoAtual = Convert.ToInt32(txtAno.Text);

            int idade = anoAtual - anoNasc;
            MessageBox.Show("Sua idade é " + idade + " anos");
        }

        private void frmCalcularIdade_Load(object sender, EventArgs e)
        {

        }
    }
}
