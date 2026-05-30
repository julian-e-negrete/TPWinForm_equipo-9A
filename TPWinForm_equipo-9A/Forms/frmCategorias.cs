using System;
using System.Windows.Forms;

namespace TPWinForm_equipo_9A
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) return;
            // TODO: Etapa 2 - persistir en DB
            lstCategorias.Items.Add(txtDescripcion.Text.Trim());
            txtDescripcion.Clear();
            txtDescripcion.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstCategorias.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtDescripcion.Text)) return;
            // TODO: Etapa 2 - actualizar en DB
            lstCategorias.Items[lstCategorias.SelectedIndex] = txtDescripcion.Text.Trim();
            txtDescripcion.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCategorias.SelectedIndex == -1) return;
            // TODO: Etapa 2 - eliminar de DB (verificar que no tenga artículos asociados)
            lstCategorias.Items.RemoveAt(lstCategorias.SelectedIndex);
            txtDescripcion.Clear();
        }

        private void lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategorias.SelectedIndex == -1) return;
            txtDescripcion.Text = lstCategorias.SelectedItem.ToString();
        }
    }
}
