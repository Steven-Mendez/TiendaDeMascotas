
namespace Tienda_Mascota.Vista
{
    partial class FormCatalogoProductoEmergente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtUnidadesVendidas = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbFoto = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbFechaIngreso = new System.Windows.Forms.GroupBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.gbFoto.SuspendLayout();
            this.gbFechaIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFoto
            // 
            this.pbFoto.Image = global::Tienda_Mascota.Imagenes.foto_objeto_por_defecto;
            this.pbFoto.Location = new System.Drawing.Point(16, 32);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(183, 185);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtUnidadesVendidas);
            this.gbDatos.Controls.Add(this.txtCosto);
            this.gbDatos.Controls.Add(this.txtPrecio);
            this.gbDatos.Controls.Add(this.txtInventario);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbDatos.ForeColor = System.Drawing.Color.LightGray;
            this.gbDatos.Location = new System.Drawing.Point(232, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(287, 232);
            this.gbDatos.TabIndex = 7;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // txtUnidadesVendidas
            // 
            this.txtUnidadesVendidas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnidadesVendidas.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtUnidadesVendidas.Location = new System.Drawing.Point(6, 197);
            this.txtUnidadesVendidas.Name = "txtUnidadesVendidas";
            this.txtUnidadesVendidas.PlaceholderText = "Unidades Vendidas";
            this.txtUnidadesVendidas.Size = new System.Drawing.Size(275, 27);
            this.txtUnidadesVendidas.TabIndex = 5;
            this.txtUnidadesVendidas.TextChanged += new System.EventHandler(this.txtUnidadesVendidas_TextChanged);
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCosto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCosto.Location = new System.Drawing.Point(6, 164);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.PlaceholderText = "Costo";
            this.txtCosto.Size = new System.Drawing.Size(275, 27);
            this.txtCosto.TabIndex = 4;
            this.txtCosto.TextChanged += new System.EventHandler(this.txtCosto_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPrecio.Location = new System.Drawing.Point(6, 131);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PlaceholderText = "Precio";
            this.txtPrecio.Size = new System.Drawing.Size(275, 27);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtInventario
            // 
            this.txtInventario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInventario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtInventario.Location = new System.Drawing.Point(6, 98);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.PlaceholderText = "Inventario";
            this.txtInventario.Size = new System.Drawing.Size(275, 27);
            this.txtInventario.TabIndex = 2;
            this.txtInventario.TextChanged += new System.EventHandler(this.txtInventario_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtDescripcion.Location = new System.Drawing.Point(6, 65);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PlaceholderText = "Descripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(275, 27);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNombre.Location = new System.Drawing.Point(6, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 27);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // gbFoto
            // 
            this.gbFoto.Controls.Add(this.pbFoto);
            this.gbFoto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbFoto.ForeColor = System.Drawing.Color.LightGray;
            this.gbFoto.Location = new System.Drawing.Point(12, 12);
            this.gbFoto.Name = "gbFoto";
            this.gbFoto.Size = new System.Drawing.Size(214, 232);
            this.gbFoto.TabIndex = 6;
            this.gbFoto.TabStop = false;
            this.gbFoto.Text = "Foto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Tienda_Mascota.Iconos.save_40px;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(197, 362);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 50);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbFechaIngreso
            // 
            this.gbFechaIngreso.Controls.Add(this.dtpFechaIngreso);
            this.gbFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbFechaIngreso.ForeColor = System.Drawing.Color.LightGray;
            this.gbFechaIngreso.Location = new System.Drawing.Point(122, 269);
            this.gbFechaIngreso.Name = "gbFechaIngreso";
            this.gbFechaIngreso.Size = new System.Drawing.Size(287, 76);
            this.gbFechaIngreso.TabIndex = 11;
            this.gbFechaIngreso.TabStop = false;
            this.gbFechaIngreso.Text = "Fecha Ingreso";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaIngreso.Location = new System.Drawing.Point(12, 32);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(269, 27);
            this.dtpFechaIngreso.TabIndex = 6;
            // 
            // FormCatalogoProductoEmergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(552, 431);
            this.Controls.Add(this.gbFechaIngreso);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbFoto);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCatalogoProductoEmergente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Producto";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbFoto.ResumeLayout(false);
            this.gbFechaIngreso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbFoto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtUnidadesVendidas;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.GroupBox gbFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
    }
}