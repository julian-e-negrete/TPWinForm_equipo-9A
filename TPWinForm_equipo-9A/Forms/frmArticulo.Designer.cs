namespace TPWinForm_equipo_9A
{
    partial class frmArticulo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.grpImagenes = new System.Windows.Forms.GroupBox();
            this.lstImagenes = new System.Windows.Forms.ListBox();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.btnQuitarImagen = new System.Windows.Forms.Button();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grpImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // grpDatos
            this.grpDatos.Controls.Add(this.lblCodigo);
            this.grpDatos.Controls.Add(this.txtCodigo);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.lblDescripcion);
            this.grpDatos.Controls.Add(this.txtDescripcion);
            this.grpDatos.Controls.Add(this.lblMarca);
            this.grpDatos.Controls.Add(this.cboMarca);
            this.grpDatos.Controls.Add(this.lblCategoria);
            this.grpDatos.Controls.Add(this.cboCategoria);
            this.grpDatos.Controls.Add(this.lblPrecio);
            this.grpDatos.Controls.Add(this.txtPrecio);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(560, 235);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.Text = "Datos del Artículo";

            // lblCodigo
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 30);
            this.lblCodigo.Text = "Código:";

            // txtCodigo
            this.txtCodigo.Location = new System.Drawing.Point(120, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(130, 20);
            this.txtCodigo.TabIndex = 0;

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 60);
            this.lblNombre.Text = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(120, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(420, 20);
            this.txtNombre.TabIndex = 1;

            // lblDescripcion
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 90);
            this.lblDescripcion.Text = "Descripción:";

            // txtDescripcion
            this.txtDescripcion.Location = new System.Drawing.Point(120, 87);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(420, 55);
            this.txtDescripcion.TabIndex = 2;

            // lblMarca
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(15, 158);
            this.lblMarca.Text = "Marca:";

            // cboMarca
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Location = new System.Drawing.Point(120, 155);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(170, 21);
            this.cboMarca.TabIndex = 3;

            // lblCategoria
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(305, 158);
            this.lblCategoria.Text = "Categoría:";

            // cboCategoria
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Location = new System.Drawing.Point(375, 155);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(165, 21);
            this.cboCategoria.TabIndex = 4;

            // lblPrecio
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(15, 195);
            this.lblPrecio.Text = "Precio ($):";

            // txtPrecio
            this.txtPrecio.Location = new System.Drawing.Point(120, 192);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 20);
            this.txtPrecio.TabIndex = 5;

            // grpImagenes
            this.grpImagenes.Controls.Add(this.lstImagenes);
            this.grpImagenes.Controls.Add(this.picImagen);
            this.grpImagenes.Controls.Add(this.btnQuitarImagen);
            this.grpImagenes.Controls.Add(this.lblUrlImagen);
            this.grpImagenes.Controls.Add(this.txtImagenUrl);
            this.grpImagenes.Controls.Add(this.btnAgregarImagen);
            this.grpImagenes.Location = new System.Drawing.Point(12, 260);
            this.grpImagenes.Name = "grpImagenes";
            this.grpImagenes.Size = new System.Drawing.Size(560, 200);
            this.grpImagenes.TabIndex = 1;
            this.grpImagenes.Text = "Imágenes";

            // lstImagenes
            this.lstImagenes.Location = new System.Drawing.Point(15, 20);
            this.lstImagenes.Name = "lstImagenes";
            this.lstImagenes.Size = new System.Drawing.Size(210, 120);
            this.lstImagenes.TabIndex = 0;
            this.lstImagenes.SelectedIndexChanged += new System.EventHandler(this.lstImagenes_SelectedIndexChanged);

            // picImagen
            this.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagen.Location = new System.Drawing.Point(230, 20);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(320, 120);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // btnQuitarImagen
            this.btnQuitarImagen.Location = new System.Drawing.Point(15, 148);
            this.btnQuitarImagen.Name = "btnQuitarImagen";
            this.btnQuitarImagen.Size = new System.Drawing.Size(90, 23);
            this.btnQuitarImagen.Text = "Quitar sel.";
            this.btnQuitarImagen.TabIndex = 1;
            this.btnQuitarImagen.Click += new System.EventHandler(this.btnQuitarImagen_Click);

            // lblUrlImagen
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(115, 152);
            this.lblUrlImagen.Text = "URL:";

            // txtImagenUrl
            this.txtImagenUrl.Location = new System.Drawing.Point(148, 149);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(320, 20);
            this.txtImagenUrl.TabIndex = 2;

            // btnAgregarImagen
            this.btnAgregarImagen.Location = new System.Drawing.Point(473, 147);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(75, 25);
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.TabIndex = 3;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);

            // pnlButtons
            this.pnlButtons.Controls.Add(this.btnGuardar);
            this.pnlButtons.Controls.Add(this.btnCancelar);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Height = 45;
            this.pnlButtons.Name = "pnlButtons";

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(380, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 25);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(478, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 25);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // frmArticulo
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 515);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpImagenes);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            this.Name = "frmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Artículo";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.grpImagenes.ResumeLayout(false);
            this.grpImagenes.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox grpImagenes;
        private System.Windows.Forms.ListBox lstImagenes;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnQuitarImagen;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
