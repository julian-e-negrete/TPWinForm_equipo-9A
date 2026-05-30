using System;
using System.Windows.Forms;

namespace TPWinForm_equipo_9A
{
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) return;
            // TODO: Etapa 2 - persistir en DB
            lstMarcas.Items.Add(txtDescripcion.Text.Trim());
            txtDescripcion.Clear();
            txtDescripcion.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstMarcas.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtDescripcion.Text)) return;
            // TODO: Etapa 2 - actualizar en DB
            lstMarcas.Items[lstMarcas.SelectedIndex] = txtDescripcion.Text.Trim();
            txtDescripcion.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstMarcas.SelectedIndex == -1) return;
            // TODO: Etapa 2 - eliminar de DB (verificar que no tenga artículos asociados)
            lstMarcas.Items.RemoveAt(lstMarcas.SelectedIndex);
            txtDescripcion.Clear();
        }

        private void lstMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMarcas.SelectedIndex == -1) return;
            txtDescripcion.Text = lstMarcas.SelectedItem.ToString();
        }
    }
}
