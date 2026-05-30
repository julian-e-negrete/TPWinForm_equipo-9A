using System;
using System.Windows.Forms;
using TPWinForm_equipo_9A.Modelos;
using TPWinForm_equipo_9A.Utilidades;

namespace TPWinForm_equipo_9A
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            lstCategorias.DataSource = null;
            lstCategorias.DataSource = Datos.ObtenerCategorias();
            lstCategorias.DisplayMember = "Descripcion";
            txtDescripcion.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) return;
            try
            {
                Datos.AgregarCategoria(new Categoria { Descripcion = txtDescripcion.Text.Trim() });
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstCategorias.SelectedItem == null || string.IsNullOrWhiteSpace(txtDescripcion.Text)) return;
            var categoria = (Categoria)lstCategorias.SelectedItem;
            categoria.Descripcion = txtDescripcion.Text.Trim();
            try
            {
                Datos.ModificarCategoria(categoria);
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCategorias.SelectedItem == null) return;
            var categoria = (Categoria)lstCategorias.SelectedItem;
            var confirm = MessageBox.Show(
                "¿Eliminar la categoría '" + categoria.Descripcion + "'?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
            try
            {
                Datos.EliminarCategoria(categoria.Id);
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCategorias.SelectedItem == null) return;
            txtDescripcion.Text = ((Categoria)lstCategorias.SelectedItem).Descripcion;
        }
    }
}
