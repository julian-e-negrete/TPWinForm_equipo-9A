namespace TPWinForm_equipo_9A
{
    partial class frmDetalle
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodigoVal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreVal = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDescripcionVal = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblMarcaVal = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCategoriaVal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPrecioVal = new System.Windows.Forms.Label();
            this.grpImagenes = new System.Windows.Forms.GroupBox();
            this.lstImagenes = new System.Windows.Forms.ListBox();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpInfo.SuspendLayout();
            this.grpImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();

            // grpInfo
            this.grpInfo.Controls.Add(this.lblCodigo);
            this.grpInfo.Controls.Add(this.lblCodigoVal);
            this.grpInfo.Controls.Add(this.lblNombre);
            this.grpInfo.Controls.Add(this.lblNombreVal);
            this.grpInfo.Controls.Add(this.lblDescripcion);
            this.grpInfo.Controls.Add(this.lblDescripcionVal);
            this.grpInfo.Controls.Add(this.lblMarca);
            this.grpInfo.Controls.Add(this.lblMarcaVal);
            this.grpInfo.Controls.Add(this.lblCategoria);
            this.grpInfo.Controls.Add(this.lblCategoriaVal);
            this.grpInfo.Controls.Add(this.lblPrecio);
            this.grpInfo.Controls.Add(this.lblPrecioVal);
            this.grpInfo.Location = new System.Drawing.Point(12, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(740, 230);
            this.grpInfo.Text = "Información del Artículo";

            // lblCodigo
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Location = new System.Drawing.Point(15, 28);
            this.lblCodigo.Text = "Código:";

            // lblCodigoVal
            this.lblCodigoVal.AutoSize = true;
            this.lblCodigoVal.Location = new System.Drawing.Point(120, 28);
            this.lblCodigoVal.Name = "lblCodigoVal";
            this.lblCodigoVal.Text = "-";

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(15, 58);
            this.lblNombre.Text = "Nombre:";

            // lblNombreVal
            this.lblNombreVal.AutoSize = true;
            this.lblNombreVal.Location = new System.Drawing.Point(120, 58);
            this.lblNombreVal.Name = "lblNombreVal";
            this.lblNombreVal.Text = "-";

            // lblDescripcion
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(15, 88);
            this.lblDescripcion.Text = "Descripción:";

            // lblDescripcionVal
            this.lblDescripcionVal.AutoSize = false;
            this.lblDescripcionVal.Location = new System.Drawing.Point(120, 88);
            this.lblDescripcionVal.Name = "lblDescripcionVal";
            this.lblDescripcionVal.Size = new System.Drawing.Size(600, 40);
            this.lblDescripcionVal.Text = "-";

            // lblMarca
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMarca.Location = new System.Drawing.Point(15, 140);
            this.lblMarca.Text = "Marca:";

            // lblMarcaVal
            this.lblMarcaVal.AutoSize = true;
            this.lblMarcaVal.Location = new System.Drawing.Point(120, 140);
            this.lblMarcaVal.Name = "lblMarcaVal";
            this.lblMarcaVal.Text = "-";

            // lblCategoria
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(15, 170);
            this.lblCategoria.Text = "Categoría:";

            // lblCategoriaVal
            this.lblCategoriaVal.AutoSize = true;
            this.lblCategoriaVal.Location = new System.Drawing.Point(120, 170);
            this.lblCategoriaVal.Name = "lblCategoriaVal";
            this.lblCategoriaVal.Text = "-";

            // lblPrecio
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(15, 200);
            this.lblPrecio.Text = "Precio:";

            // lblPrecioVal
            this.lblPrecioVal.AutoSize = true;
            this.lblPrecioVal.Location = new System.Drawing.Point(120, 200);
            this.lblPrecioVal.Name = "lblPrecioVal";
            this.lblPrecioVal.Text = "-";

            // grpImagenes
            this.grpImagenes.Controls.Add(this.lstImagenes);
            this.grpImagenes.Controls.Add(this.picImagen);
            this.grpImagenes.Location = new System.Drawing.Point(12, 255);
            this.grpImagenes.Name = "grpImagenes";
            this.grpImagenes.Size = new System.Drawing.Size(740, 220);
            this.grpImagenes.Text = "Imágenes (seleccioná una URL para visualizarla)";

            // lstImagenes
            this.lstImagenes.Location = new System.Drawing.Point(10, 20);
            this.lstImagenes.Name = "lstImagenes";
            this.lstImagenes.Size = new System.Drawing.Size(220, 186);
            this.lstImagenes.SelectedIndexChanged += new System.EventHandler(this.lstImagenes_SelectedIndexChanged);

            // picImagen
            this.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagen.Location = new System.Drawing.Point(240, 20);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(488, 186);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // pnlBottom
            this.pnlBottom.Controls.Add(this.btnCerrar);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Height = 45;
            this.pnlBottom.Name = "pnlBottom";

            // btnCerrar
            this.btnCerrar.Location = new System.Drawing.Point(660, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 25);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // frmDetalle
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 530);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpImagenes);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle del Artículo";
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.grpImagenes.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodigoVal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreVal;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDescripcionVal;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblMarcaVal;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCategoriaVal;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPrecioVal;
        private System.Windows.Forms.GroupBox grpImagenes;
        private System.Windows.Forms.ListBox lstImagenes;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnCerrar;
    }
}
