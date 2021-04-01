
namespace Tienda_Mascota.Vista
{
    partial class FormOperacionesFacturacionEmergente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperacionesFacturacionEmergente));
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.pbBusqueda = new System.Windows.Forms.PictureBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pbCajaBusqueda = new System.Windows.Forms.PictureBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCajaBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dgDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.EnableHeadersVisualStyles = false;
            this.dgDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dgDatos.Location = new System.Drawing.Point(12, 70);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDatos.RowTemplate.Height = 25;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(776, 337);
            this.dgDatos.TabIndex = 1;
            // 
            // pbBusqueda
            // 
            this.pbBusqueda.BackColor = System.Drawing.Color.White;
            this.pbBusqueda.Image = global::Tienda_Mascota.Iconos.search_30px;
            this.pbBusqueda.Location = new System.Drawing.Point(199, 26);
            this.pbBusqueda.Name = "pbBusqueda";
            this.pbBusqueda.Size = new System.Drawing.Size(30, 30);
            this.pbBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBusqueda.TabIndex = 9;
            this.pbBusqueda.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBusqueda.Location = new System.Drawing.Point(235, 28);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PlaceholderText = "Buscar";
            this.txtBusqueda.Size = new System.Drawing.Size(362, 26);
            this.txtBusqueda.TabIndex = 8;
            this.txtBusqueda.TabStop = false;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // pbCajaBusqueda
            // 
            this.pbCajaBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("pbCajaBusqueda.Image")));
            this.pbCajaBusqueda.Location = new System.Drawing.Point(193, 16);
            this.pbCajaBusqueda.Name = "pbCajaBusqueda";
            this.pbCajaBusqueda.Size = new System.Drawing.Size(410, 50);
            this.pbCajaBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCajaBusqueda.TabIndex = 10;
            this.pbCajaBusqueda.TabStop = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeleccionar.Location = new System.Drawing.Point(325, 417);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(151, 37);
            this.btnSeleccionar.TabIndex = 11;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // FormOperacionesFacturacionEmergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.pbBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.pbCajaBusqueda);
            this.Controls.Add(this.dgDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOperacionesFacturacionEmergente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormOperacionesFacturacionEmergente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCajaBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.PictureBox pbCajaBusqueda;
        private System.Windows.Forms.Button btnSeleccionar;
        public System.Windows.Forms.DataGridView dgDatos;
    }
}