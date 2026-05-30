using System;
using System.Windows.Forms;
using TPWinForm_equipo_9A.Modelos;

namespace TPWinForm_equipo_9A
{
    public partial class frmArticulo : Form
    {
        private Articulo _articulo;

        public frmArticulo()
        {
            InitializeComponent();
            _articulo = new Articulo();
            Text = "Nuevo Artículo";
        }

        public frmArticulo(Articulo articulo)
        {
            InitializeComponent();
            _articulo = articulo;
            Text = "Modificar Artículo";
            CargarDatos();
        }

        private void CargarDatos()
        {
            txtCodigo.Text = _articulo.Codigo;
            txtNombre.Text = _articulo.Nombre;
            txtDescripcion.Text = _articulo.Descripcion;
            txtPrecio.Text = _articulo.Precio.ToString();
            foreach (var img in _articulo.Imagenes)
                lstImagenes.Items.Add(img.ImagenUrl);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImagenUrl.Text)) return;
            lstImagenes.Items.Add(txtImagenUrl.Text.Trim());
            txtImagenUrl.Clear();
            txtImagenUrl.Focus();
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            if (lstImagenes.SelectedIndex == -1) return;
            lstImagenes.Items.RemoveAt(lstImagenes.SelectedIndex);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
