
namespace Tienda_Mascota.Vista
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblAcceda = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pbContraseña = new System.Windows.Forms.PictureBox();
            this.pbIconoUsuario = new System.Windows.Forms.PictureBox();
            this.pbIconoContraseña = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtUsuario.Location = new System.Drawing.Point(32, 239);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Admin";
            this.txtUsuario.Size = new System.Drawing.Size(235, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtContraseña.Location = new System.Drawing.Point(32, 297);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.PlaceholderText = "●●●●●●";
            this.txtContraseña.Size = new System.Drawing.Size(235, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // lblAcceda
            // 
            this.lblAcceda.AutoSize = true;
            this.lblAcceda.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAcceda.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAcceda.Location = new System.Drawing.Point(16, 156);
            this.lblAcceda.Name = "lblAcceda";
            this.lblAcceda.Size = new System.Drawing.Size(293, 45);
            this.lblAcceda.TabIndex = 2;
            this.lblAcceda.Text = "Acceda a su cuenta";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUsuario.Location = new System.Drawing.Point(22, 216);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblContraseña.Location = new System.Drawing.Point(22, 274);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(83, 20);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(18, 339);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(289, 43);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.TabStop = false;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pbLogin
            // 
            this.pbLogin.Image = global::Tienda_Mascota.FotosDePerfil.login;
            this.pbLogin.Location = new System.Drawing.Point(97, 20);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(130, 130);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogin.TabIndex = 6;
            this.pbLogin.TabStop = false;
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::Tienda_Mascota.Imagenes.txt_rojo;
            this.pbUsuario.Location = new System.Drawing.Point(22, 236);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(285, 27);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuario.TabIndex = 7;
            this.pbUsuario.TabStop = false;
            // 
            // pbContraseña
            // 
            this.pbContraseña.Image = global::Tienda_Mascota.Imagenes.txt_rojo;
            this.pbContraseña.Location = new System.Drawing.Point(22, 294);
            this.pbContraseña.Name = "pbContraseña";
            this.pbContraseña.Size = new System.Drawing.Size(285, 27);
            this.pbContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbContraseña.TabIndex = 8;
            this.pbContraseña.TabStop = false;
            // 
            // pbIconoUsuario
            // 
            this.pbIconoUsuario.Image = global::Tienda_Mascota.Iconos.high_priority_20px;
            this.pbIconoUsuario.Location = new System.Drawing.Point(273, 239);
            this.pbIconoUsuario.Name = "pbIconoUsuario";
            this.pbIconoUsuario.Size = new System.Drawing.Size(20, 20);
            this.pbIconoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconoUsuario.TabIndex = 9;
            this.pbIconoUsuario.TabStop = false;
            // 
            // pbIconoContraseña
            // 
            this.pbIconoContraseña.Image = global::Tienda_Mascota.Iconos.high_priority_20px;
            this.pbIconoContraseña.Location = new System.Drawing.Point(273, 297);
            this.pbIconoContraseña.Name = "pbIconoContraseña";
            this.pbIconoContraseña.Size = new System.Drawing.Size(20, 20);
            this.pbIconoContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconoContraseña.TabIndex = 9;
            this.pbIconoContraseña.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 398);
            this.Controls.Add(this.pbIconoContraseña);
            this.Controls.Add(this.pbIconoUsuario);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblAcceda);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.pbContraseña);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Para Mascotas";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblAcceda;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.PictureBox pbContraseña;
        private System.Windows.Forms.PictureBox pbIconoUsuario;
        private System.Windows.Forms.PictureBox pbIconoContraseña;
    }
}