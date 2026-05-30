using System;
using System.Windows.Forms;
using TPWinForm_equipo_9A.Modelos;
using TPWinForm_equipo_9A.Utilidades;

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
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            CargarComboBoxes();
            if (_articulo.Id != 0)
                CargarDatos();
        }

        private void CargarComboBoxes()
        {
            cboMarca.DataSource = Datos.ObtenerMarcas();
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.ValueMember = "Id";
            cboMarca.SelectedIndex = -1;

            cboCategoria.DataSource = Datos.ObtenerCategorias();
            cboCategoria.DisplayMember = "Descripcion";
            cboCategoria.ValueMember = "Id";
            cboCategoria.SelectedIndex = -1;
        }

        private void CargarDatos()
        {
            txtCodigo.Text = _articulo.Codigo;
            txtNombre.Text = _articulo.Nombre;
            txtDescripcion.Text = _articulo.Descripcion;
            txtPrecio.Text = _articulo.Precio.ToString();

            if (_articulo.Marca != null)
                cboMarca.SelectedValue = _articulo.Marca.Id;
            if (_articulo.Categoria != null)
                cboCategoria.SelectedValue = _articulo.Categoria.Id;

            foreach (var img in _articulo.Imagenes)
                lstImagenes.Items.Add(img.ImagenUrl);
        }

        private void lstImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstImagenes.SelectedItem == null) return;
            CargarImagen(lstImagenes.SelectedItem.ToString());
        }

        private void CargarImagen(string url)
        {
            try
            {
                picImagen.Image = null;
                picImagen.ImageLocation = url;
                picImagen.LoadAsync();
            }
            catch
            {
                picImagen.Image = null;
            }
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
            if (!Validar()) return;

            _articulo.Codigo      = txtCodigo.Text.Trim();
            _articulo.Nombre      = txtNombre.Text.Trim();
            _articulo.Descripcion = txtDescripcion.Text.Trim();
            _articulo.Precio      = decimal.Parse(txtPrecio.Text.Trim());
            _articulo.Marca       = (Marca)cboMarca.SelectedItem;
            _articulo.Categoria   = (Categoria)cboCategoria.SelectedItem;

            _articulo.Imagenes.Clear();
            foreach (string url in lstImagenes.Items)
                _articulo.Imagenes.Add(new Imagen { ImagenUrl = url });

            try
            {
                if (_articulo.Id == 0)
                {
                    int nuevoId = Datos.AgregarArticulo(_articulo);
                    foreach (var img in _articulo.Imagenes)
                        Datos.AgregarImagen(nuevoId, img.ImagenUrl);
                }
                else
                {
                    Datos.ModificarArticulo(_articulo);
                }

                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El código es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            if (!decimal.TryParse(txtPrecio.Text.Trim(), out _))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
