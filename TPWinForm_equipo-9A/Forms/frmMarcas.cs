using System;
using System.Windows.Forms;
using TPWinForm_equipo_9A.Modelos;
using TPWinForm_equipo_9A.Utilidades;

namespace TPWinForm_equipo_9A
{
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            lstMarcas.DataSource = null;
            lstMarcas.DataSource = Datos.ObtenerMarcas();
            lstMarcas.DisplayMember = "Descripcion";
            txtDescripcion.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) return;
            try
            {
                Datos.AgregarMarca(new Marca { Descripcion = txtDescripcion.Text.Trim() });
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
            if (lstMarcas.SelectedItem == null || string.IsNullOrWhiteSpace(txtDescripcion.Text)) return;
            var marca = (Marca)lstMarcas.SelectedItem;
            marca.Descripcion = txtDescripcion.Text.Trim();
            try
            {
                Datos.ModificarMarca(marca);
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
            if (lstMarcas.SelectedItem == null) return;
            var marca = (Marca)lstMarcas.SelectedItem;
            var confirm = MessageBox.Show(
                "¿Eliminar la marca '" + marca.Descripcion + "'?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
            try
            {
                Datos.EliminarMarca(marca.Id);
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMarcas.SelectedItem == null) return;
            txtDescripcion.Text = ((Marca)lstMarcas.SelectedItem).Descripcion;
        }
    }
}
