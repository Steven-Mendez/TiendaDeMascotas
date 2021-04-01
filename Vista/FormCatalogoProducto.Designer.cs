
namespace Tienda_Mascota.Vista
{
    partial class FormCatalogoProducto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalogoProducto));
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.pbBusqueda = new System.Windows.Forms.PictureBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.pbCajaBusqueda = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCajaBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDesactivar.FlatAppearance.BorderSize = 0;
            this.btnDesactivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivar.Image = global::Tienda_Mascota.Iconos.quick_mode_off_40px;
            this.btnDesactivar.Location = new System.Drawing.Point(192, 12);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(45, 45);
            this.btnDesactivar.TabIndex = 14;
            this.btnDesactivar.TabStop = false;
            this.toolTip.SetToolTip(this.btnDesactivar, "Deshabilitar Producto");
            this.btnDesactivar.UseVisualStyleBackColor = false;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnActivar.FlatAppearance.BorderSize = 0;
            this.btnActivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivar.Image = global::Tienda_Mascota.Iconos.quick_mode_on_40px;
            this.btnActivar.Location = new System.Drawing.Point(147, 12);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(45, 45);
            this.btnActivar.TabIndex = 15;
            this.btnActivar.TabStop = false;
            this.toolTip.SetToolTip(this.btnActivar, "Habilitar Producto");
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Tienda_Mascota.Iconos.edit_file_40px;
            this.btnEditar.Location = new System.Drawing.Point(102, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(45, 45);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.TabStop = false;
            this.toolTip.SetToolTip(this.btnEditar, "Editar Producto");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Image = global::Tienda_Mascota.Iconos.check_file_40px;
            this.btnAñadir.Location = new System.Drawing.Point(57, 12);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(45, 45);
            this.btnAñadir.TabIndex = 12;
            this.btnAñadir.TabStop = false;
            this.toolTip.SetToolTip(this.btnAñadir, "Añadir Producto");
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Image = global::Tienda_Mascota.Iconos.reset_40px;
            this.btnRefrescar.Location = new System.Drawing.Point(12, 12);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(45, 45);
            this.btnRefrescar.TabIndex = 11;
            this.btnRefrescar.TabStop = false;
            this.toolTip.SetToolTip(this.btnRefrescar, "Refrescar");
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // pbBusqueda
            // 
            this.pbBusqueda.BackColor = System.Drawing.Color.White;
            this.pbBusqueda.Image = global::Tienda_Mascota.Iconos.search_30px;
            this.pbBusqueda.Location = new System.Drawing.Point(508, 21);
            this.pbBusqueda.Name = "pbBusqueda";
            this.pbBusqueda.Size = new System.Drawing.Size(30, 30);
            this.pbBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBusqueda.TabIndex = 10;
            this.pbBusqueda.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBusqueda.Location = new System.Drawing.Point(544, 23);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PlaceholderText = "Busqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(362, 26);
            this.txtBusqueda.TabIndex = 9;
            this.txtBusqueda.TabStop = false;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AllowUserToDeleteRows = false;
            this.dgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dgProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.EnableHeadersVisualStyles = false;
            this.dgProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dgProductos.Location = new System.Drawing.Point(12, 64);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.ReadOnly = true;
            this.dgProductos.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dgProductos.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgProductos.RowTemplate.Height = 25;
            this.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductos.Size = new System.Drawing.Size(900, 380);
            this.dgProductos.TabIndex = 8;
            // 
            // pbCajaBusqueda
            // 
            this.pbCajaBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("pbCajaBusqueda.Image")));
            this.pbCajaBusqueda.Location = new System.Drawing.Point(502, 11);
            this.pbCajaBusqueda.Name = "pbCajaBusqueda";
            this.pbCajaBusqueda.Size = new System.Drawing.Size(410, 50);
            this.pbCajaBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCajaBusqueda.TabIndex = 16;
            this.pbCajaBusqueda.TabStop = false;
            // 
            // FormCatalogoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(924, 454);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.pbBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.pbCajaBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCatalogoProducto";
            this.Text = "FormCatalogoProducto";
            this.Load += new System.EventHandler(this.FormCatalogoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCajaBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.PictureBox pbBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.PictureBox pbCajaBusqueda;
    }
}