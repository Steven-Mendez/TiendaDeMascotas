
namespace Tienda_Mascota.Vista
{
    partial class FormSeguridadUsuarioEmergente
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.txtConfirmación = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.gbFoto = new System.Windows.Forms.GroupBox();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gbFoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cbRol);
            this.gbDatos.Controls.Add(this.txtConfirmación);
            this.gbDatos.Controls.Add(this.btnGuardar);
            this.gbDatos.Controls.Add(this.txtContraseña);
            this.gbDatos.Controls.Add(this.txtUsuario);
            this.gbDatos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbDatos.ForeColor = System.Drawing.Color.LightGray;
            this.gbDatos.Location = new System.Drawing.Point(243, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(287, 232);
            this.gbDatos.TabIndex = 7;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRol.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Vendedor",
            "Administrador"});
            this.cbRol.Location = new System.Drawing.Point(6, 131);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(275, 28);
            this.cbRol.TabIndex = 3;
            // 
            // txtConfirmación
            // 
            this.txtConfirmación.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmación.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtConfirmación.Location = new System.Drawing.Point(6, 98);
            this.txtConfirmación.Name = "txtConfirmación";
            this.txtConfirmación.PlaceholderText = "Confirmación";
            this.txtConfirmación.Size = new System.Drawing.Size(275, 27);
            this.txtConfirmación.TabIndex = 2;
            this.txtConfirmación.UseSystemPasswordChar = true;
            this.txtConfirmación.TextChanged += new System.EventHandler(this.txtConfirmación_TextChanged);
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
            this.btnGuardar.Location = new System.Drawing.Point(76, 169);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 50);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtContraseña.Location = new System.Drawing.Point(6, 65);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PlaceholderText = "Contraseña";
            this.txtContraseña.Size = new System.Drawing.Size(275, 27);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtUsuario.Location = new System.Drawing.Point(6, 32);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(275, 27);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // pbFoto
            // 
            this.pbFoto.Image = global::Tienda_Mascota.Imagenes.foto_persona_por_defecto;
            this.pbFoto.Location = new System.Drawing.Point(16, 32);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(183, 185);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // gbFoto
            // 
            this.gbFoto.Controls.Add(this.pbFoto);
            this.gbFoto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbFoto.ForeColor = System.Drawing.Color.LightGray;
            this.gbFoto.Location = new System.Drawing.Point(23, 12);
            this.gbFoto.Name = "gbFoto";
            this.gbFoto.Size = new System.Drawing.Size(214, 232);
            this.gbFoto.TabIndex = 6;
            this.gbFoto.TabStop = false;
            this.gbFoto.Text = "Foto";
            // 
            // FormSeguridadUsuarioEmergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(552, 262);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSeguridadUsuarioEmergente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario";
            this.TopMost = true;
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gbFoto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.TextBox txtConfirmación;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.GroupBox gbFoto;
    }
}