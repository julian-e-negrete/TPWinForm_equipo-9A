using System;
using System.Windows.Forms;
using TPWinForm_equipo_9A.Modelos;

namespace TPWinForm_equipo_9A
{
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new frmArticulo().ShowDialog();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count == 0) return;
            var articulo = (Articulo)dgvArticulos.SelectedRows[0].DataBoundItem;
            new frmDetalle(articulo).ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count == 0) return;
            var articulo = (Articulo)dgvArticulos.SelectedRows[0].DataBoundItem;
            new frmArticulo(articulo).ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count == 0) return;
            // TODO: Etapa 2 - eliminar de DB con confirmación
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // TODO: Etapa 2 - buscar en DB
        }
    }
}
