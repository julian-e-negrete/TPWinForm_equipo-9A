using System;
using System.Windows.Forms;
using TPWinForm_equipo_9A.Modelos;

namespace TPWinForm_equipo_9A
{
    public partial class frmDetalle : Form
    {
        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            CargarDatos(articulo);
        }

        private void CargarDatos(Articulo articulo)
        {
            lblCodigoVal.Text = articulo.Codigo;
            lblNombreVal.Text = articulo.Nombre;
            lblDescripcionVal.Text = articulo.Descripcion;
            lblMarcaVal.Text = articulo.Marca?.Descripcion ?? "-";
            lblCategoriaVal.Text = articulo.Categoria?.Descripcion ?? "-";
            lblPrecioVal.Text = articulo.Precio.ToString("C");

            foreach (var img in articulo.Imagenes)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
