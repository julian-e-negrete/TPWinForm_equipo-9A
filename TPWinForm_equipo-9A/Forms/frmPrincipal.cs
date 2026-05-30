using System;
using System.Windows.Forms;

namespace TPWinForm_equipo_9A
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmArticulos().ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMarcas().ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCategorias().ShowDialog();
        }
    }
}
