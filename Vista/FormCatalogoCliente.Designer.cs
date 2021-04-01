
namespace Tienda_Mascota.Vista
{
    partial class FormCatalogoCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalogoCliente));
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pbBusqueda = new System.Windows.Forms.PictureBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.pbCajaBusqueda = new System.Windows.Forms.PictureBox();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCajaBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.EnableHeadersVisualStyles = false;
            this.dgClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dgClientes.Location = new System.Drawing.Point(12, 64);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgClientes.RowTemplate.Height = 25;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(900, 380);
            this.dgClientes.TabIndex = 0;
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
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TabStop = false;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // pbBusqueda
            // 
            this.pbBusqueda.BackColor = System.Drawing.Color.White;
            this.pbBusqueda.Image = global::Tienda_Mascota.Iconos.search_30px;
            this.pbBusqueda.Location = new System.Drawing.Point(508, 21);
            this.pbBusqueda.Name = "pbBusqueda";
            this.pbBusqueda.Size = new System.Drawing.Size(30, 30);
            this.pbBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBusqueda.TabIndex = 2;
            this.pbBusqueda.TabStop = false;
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
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.TabStop = false;
            this.toolTip.SetToolTip(this.btnRefrescar, "Refrescar");
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Image = global::Tienda_Mascota.Iconos.add_user_male_40px;
            this.btnAñadir.Location = new System.Drawing.Point(57, 12);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(45, 45);
            this.btnAñadir.TabIndex = 4;
            this.btnAñadir.TabStop = false;
            this.toolTip.SetToolTip(this.btnAñadir, "Añadir Cliente");
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::Tienda_Mascota.Iconos.edit_profile_skin_type_7_40px;
            this.btnEditar.Location = new System.Drawing.Point(102, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(45, 45);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.TabStop = false;
            this.toolTip.SetToolTip(this.btnEditar, "Editar Cliente");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnActivar.TabIndex = 6;
            this.btnActivar.TabStop = false;
            this.toolTip.SetToolTip(this.btnActivar, "Habilitar Cliente");
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // pbCajaBusqueda
            // 
            this.pbCajaBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("pbCajaBusqueda.Image")));
            this.pbCajaBusqueda.Location = new System.Drawing.Point(502, 11);
            this.pbCajaBusqueda.Name = "pbCajaBusqueda";
            this.pbCajaBusqueda.Size = new System.Drawing.Size(410, 50);
            this.pbCajaBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCajaBusqueda.TabIndex = 7;
            this.pbCajaBusqueda.TabStop = false;
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
            this.btnDesactivar.TabIndex = 6;
            this.btnDesactivar.TabStop = false;
            this.toolTip.SetToolTip(this.btnDesactivar, "Deshabilitar Cliente");
            this.btnDesactivar.UseVisualStyleBackColor = false;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // FormCatalogoCliente
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
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.pbCajaBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCatalogoCliente";
            this.Text = "FormCatalogoCliente";
            this.Load += new System.EventHandler(this.FormCatalogoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCajaBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.PictureBox pbBusqueda;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.PictureBox pbCajaBusqueda;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.ToolTip toolTip;
    }
}