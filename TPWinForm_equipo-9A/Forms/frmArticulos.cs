using System;
using System.Windows.Forms;
using TPWinForm_equipo_9A.Modelos;
using TPWinForm_equipo_9A.Utilidades;

namespace TPWinForm_equipo_9A
{
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            try
            {
                dgvArticulos.DataSource = Datos.ObtenerArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    Cargar();
                    return;
                }
                dgvArticulos.DataSource = Datos.BuscarArticulos(cboCampo.Text, txtBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new frmArticulo().ShowDialog();
            Cargar();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count == 0) return;
            var articulo = (Articulo)dgvArticulos.SelectedRows[0].DataBoundItem;
            articulo.Imagenes = Datos.ObtenerImagenesPorArticulo(articulo.Id);
            new frmDetalle(articulo).ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count == 0) return;
            var articulo = (Articulo)dgvArticulos.SelectedRows[0].DataBoundItem;
            articulo.Imagenes = Datos.ObtenerImagenesPorArticulo(articulo.Id);
            new frmArticulo(articulo).ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count == 0) return;
           
        }
    }
}
