namespace TPWinForm_equipo_9A
{
    partial class frmMarcas
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
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.lstMarcas = new System.Windows.Forms.ListBox();
            this.grpEdicion = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grpLista.SuspendLayout();
            this.grpEdicion.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // grpLista
            this.grpLista.Controls.Add(this.lstMarcas);
            this.grpLista.Location = new System.Drawing.Point(12, 12);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(360, 220);
            this.grpLista.Text = "Marcas";

            // lstMarcas
            this.lstMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMarcas.Name = "lstMarcas";
            this.lstMarcas.TabIndex = 0;
            this.lstMarcas.SelectedIndexChanged += new System.EventHandler(this.lstMarcas_SelectedIndexChanged);

            // grpEdicion
            this.grpEdicion.Controls.Add(this.lblDescripcion);
            this.grpEdicion.Controls.Add(this.txtDescripcion);
            this.grpEdicion.Location = new System.Drawing.Point(12, 245);
            this.grpEdicion.Name = "grpEdicion";
            this.grpEdicion.Size = new System.Drawing.Size(360, 65);
            this.grpEdicion.Text = "Descripción";

            // lblDescripcion
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 28);
            this.lblDescripcion.Text = "Nombre:";

            // txtDescripcion
            this.txtDescripcion.Location = new System.Drawing.Point(75, 25);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(265, 20);
            this.txtDescripcion.TabIndex = 0;

            // pnlButtons
            this.pnlButtons.Controls.Add(this.btnAgregar);
            this.pnlButtons.Controls.Add(this.btnModificar);
            this.pnlButtons.Controls.Add(this.btnEliminar);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Height = 45;
            this.pnlButtons.Name = "pnlButtons";

            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(10, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 25);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // btnModificar
            this.btnModificar.Location = new System.Drawing.Point(110, 10);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 25);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);

            // btnEliminar
            this.btnEliminar.Location = new System.Drawing.Point(210, 10);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 25);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // frmMarcas
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 370);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.grpEdicion);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Marcas";
            this.grpLista.ResumeLayout(false);
            this.grpEdicion.ResumeLayout(false);
            this.grpEdicion.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.ListBox lstMarcas;
        private System.Windows.Forms.GroupBox grpEdicion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
