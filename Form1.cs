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
    public partial class frmShowMensagem : Form
    {
        public frmShowMensagem()
        {
            InitializeComponent();
        }

        private void frmShowMensagem_Load(object sender, EventArgs e)
        {

        }

        private void exibirMensagem(object sender, EventArgs e)
        {
            String msg = txtMensagem.Text;
            MessageBox.Show(msg);
        }

        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
