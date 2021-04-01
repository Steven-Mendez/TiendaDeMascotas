
namespace Tienda_Mascota.Vista
{
    partial class FormCatalogoClienteEmergente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbFoto);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNombre2);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(242, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 113);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nombre";
            // 
            // txtNombre2
            // 
            this.txtNombre2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNombre2.Location = new System.Drawing.Point(6, 71);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.PlaceholderText = "Segundo Nombre";
            this.txtNombre2.Size = new System.Drawing.Size(275, 27);
            this.txtNombre2.TabIndex = 1;
            this.txtNombre2.TextChanged += new System.EventHandler(this.txtNombre2_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNombre.Location = new System.Drawing.Point(6, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Primer Nombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 27);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtApellido2);
            this.groupBox3.Controls.Add(this.txtApellido);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox3.Location = new System.Drawing.Point(242, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 113);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Apellidos";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtApellido2.Location = new System.Drawing.Point(6, 71);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.PlaceholderText = "Segundo Apellido";
            this.txtApellido2.Size = new System.Drawing.Size(275, 27);
            this.txtApellido2.TabIndex = 1;
            this.txtApellido2.TextChanged += new System.EventHandler(this.txtApellido2_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtApellido.Location = new System.Drawing.Point(6, 32);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Primer Apellido";
            this.txtApellido.Size = new System.Drawing.Size(275, 27);
            this.txtApellido.TabIndex = 0;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCelular);
            this.groupBox4.Controls.Add(this.txtCorreo);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox4.Location = new System.Drawing.Point(132, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 113);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Personales";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCelular.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCelular.Location = new System.Drawing.Point(6, 71);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.PlaceholderText = "Celular / Teléfono";
            this.txtCelular.Size = new System.Drawing.Size(275, 27);
            this.txtCelular.TabIndex = 1;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCorreo.Location = new System.Drawing.Point(6, 32);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceholderText = "Correo";
            this.txtCorreo.Size = new System.Drawing.Size(275, 27);
            this.txtCorreo.TabIndex = 0;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
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
            this.btnGuardar.Location = new System.Drawing.Point(206, 369);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 50);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormCatalogoClienteEmergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(552, 431);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCatalogoClienteEmergente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Cliente";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnGuardar;
    }
}