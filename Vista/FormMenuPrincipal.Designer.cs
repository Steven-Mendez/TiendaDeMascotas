
using System.Drawing;

namespace Tienda_Mascota.Vista
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.pSeparadorBannerArriba = new System.Windows.Forms.Panel();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.pBanner = new System.Windows.Forms.Panel();
            this.pSeparadorMenu = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnRecaudaciones = new System.Windows.Forms.Button();
            this.pSeparadorOperaciones = new System.Windows.Forms.Panel();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.pSeparadorSeguridad = new System.Windows.Forms.Panel();
            this.pSeparadorReportes = new System.Windows.Forms.Panel();
            this.lblSeguridad = new System.Windows.Forms.Label();
            this.lblReportes = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pSeparadorCatalogos = new System.Windows.Forms.Panel();
            this.lblCatalogos = new System.Windows.Forms.Label();
            this.lblNombreCargo = new System.Windows.Forms.Label();
            this.pbFotoDePerfil = new System.Windows.Forms.PictureBox();
            this.pSeparadorBannerAbajo = new System.Windows.Forms.Panel();
            this.pContenidoPrincipal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.pBanner.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoDePerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pSeparadorBannerArriba
            // 
            this.pSeparadorBannerArriba.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pSeparadorBannerArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeparadorBannerArriba.Location = new System.Drawing.Point(201, 0);
            this.pSeparadorBannerArriba.Name = "pSeparadorBannerArriba";
            this.pSeparadorBannerArriba.Size = new System.Drawing.Size(924, 1);
            this.pSeparadorBannerArriba.TabIndex = 3;
            // 
            // pbBanner
            // 
            this.pbBanner.BackColor = System.Drawing.Color.White;
            this.pbBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBanner.Image = global::Tienda_Mascota.Banners.banner_mascota;
            this.pbBanner.Location = new System.Drawing.Point(0, 0);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(924, 205);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBanner.TabIndex = 0;
            this.pbBanner.TabStop = false;
            // 
            // pBanner
            // 
            this.pBanner.BackColor = System.Drawing.Color.White;
            this.pBanner.Controls.Add(this.pbBanner);
            this.pBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBanner.Location = new System.Drawing.Point(201, 1);
            this.pBanner.Name = "pBanner";
            this.pBanner.Size = new System.Drawing.Size(924, 205);
            this.pBanner.TabIndex = 4;
            // 
            // pSeparadorMenu
            // 
            this.pSeparadorMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pSeparadorMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSeparadorMenu.Location = new System.Drawing.Point(200, 0);
            this.pSeparadorMenu.Name = "pSeparadorMenu";
            this.pSeparadorMenu.Size = new System.Drawing.Size(1, 661);
            this.pSeparadorMenu.TabIndex = 1;
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pMenu.Controls.Add(this.btnUsuarios);
            this.pMenu.Controls.Add(this.btnRecaudaciones);
            this.pMenu.Controls.Add(this.pSeparadorOperaciones);
            this.pMenu.Controls.Add(this.lblOperaciones);
            this.pMenu.Controls.Add(this.btnFacturacion);
            this.pMenu.Controls.Add(this.pSeparadorSeguridad);
            this.pMenu.Controls.Add(this.pSeparadorReportes);
            this.pMenu.Controls.Add(this.lblSeguridad);
            this.pMenu.Controls.Add(this.lblReportes);
            this.pMenu.Controls.Add(this.btnProducto);
            this.pMenu.Controls.Add(this.btnCliente);
            this.pMenu.Controls.Add(this.pSeparadorCatalogos);
            this.pMenu.Controls.Add(this.lblCatalogos);
            this.pMenu.Controls.Add(this.lblNombreCargo);
            this.pMenu.Controls.Add(this.pbFotoDePerfil);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(200, 661);
            this.pMenu.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(51)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.Image = global::Tienda_Mascota.Iconos.user_shield_32px;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 560);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 51);
            this.btnUsuarios.TabIndex = 19;
            this.btnUsuarios.TabStop = false;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnRecaudaciones
            // 
            this.btnRecaudaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnRecaudaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.btnRecaudaciones.FlatAppearance.BorderSize = 0;
            this.btnRecaudaciones.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnRecaudaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnRecaudaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(51)))));
            this.btnRecaudaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecaudaciones.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRecaudaciones.Image = global::Tienda_Mascota.Iconos.duration_finance_32px;
            this.btnRecaudaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecaudaciones.Location = new System.Drawing.Point(0, 471);
            this.btnRecaudaciones.Name = "btnRecaudaciones";
            this.btnRecaudaciones.Size = new System.Drawing.Size(200, 51);
            this.btnRecaudaciones.TabIndex = 18;
            this.btnRecaudaciones.TabStop = false;
            this.btnRecaudaciones.Text = "Recaudaciones";
            this.btnRecaudaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecaudaciones.UseVisualStyleBackColor = false;
            this.btnRecaudaciones.Click += new System.EventHandler(this.btnRecaudaciones_Click);
            // 
            // pSeparadorOperaciones
            // 
            this.pSeparadorOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pSeparadorOperaciones.ForeColor = System.Drawing.Color.White;
            this.pSeparadorOperaciones.Location = new System.Drawing.Point(19, 374);
            this.pSeparadorOperaciones.Name = "pSeparadorOperaciones";
            this.pSeparadorOperaciones.Size = new System.Drawing.Size(183, 2);
            this.pSeparadorOperaciones.TabIndex = 17;
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOperaciones.ForeColor = System.Drawing.Color.White;
            this.lblOperaciones.Location = new System.Drawing.Point(14, 347);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(118, 25);
            this.lblOperaciones.TabIndex = 16;
            this.lblOperaciones.Text = "Operaciones";
            this.lblOperaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnFacturacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnFacturacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(51)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFacturacion.Image = global::Tienda_Mascota.Iconos.receipt_32px;
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 382);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(200, 51);
            this.btnFacturacion.TabIndex = 15;
            this.btnFacturacion.TabStop = false;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturacion.UseVisualStyleBackColor = false;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // pSeparadorSeguridad
            // 
            this.pSeparadorSeguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pSeparadorSeguridad.Location = new System.Drawing.Point(24, 552);
            this.pSeparadorSeguridad.Name = "pSeparadorSeguridad";
            this.pSeparadorSeguridad.Size = new System.Drawing.Size(183, 2);
            this.pSeparadorSeguridad.TabIndex = 14;
            // 
            // pSeparadorReportes
            // 
            this.pSeparadorReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pSeparadorReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.pSeparadorReportes.Location = new System.Drawing.Point(20, 463);
            this.pSeparadorReportes.Name = "pSeparadorReportes";
            this.pSeparadorReportes.Size = new System.Drawing.Size(183, 2);
            this.pSeparadorReportes.TabIndex = 14;
            // 
            // lblSeguridad
            // 
            this.lblSeguridad.AutoSize = true;
            this.lblSeguridad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeguridad.ForeColor = System.Drawing.Color.White;
            this.lblSeguridad.Location = new System.Drawing.Point(19, 525);
            this.lblSeguridad.Name = "lblSeguridad";
            this.lblSeguridad.Size = new System.Drawing.Size(98, 25);
            this.lblSeguridad.TabIndex = 13;
            this.lblSeguridad.Text = "Seguridad";
            this.lblSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReportes.ForeColor = System.Drawing.Color.White;
            this.lblReportes.Location = new System.Drawing.Point(15, 436);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(85, 25);
            this.lblReportes.TabIndex = 13;
            this.lblReportes.Text = "Reportes";
            this.lblReportes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(51)))));
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProducto.Image = global::Tienda_Mascota.Iconos.dog_bowl_32px;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(0, 293);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(200, 51);
            this.btnProducto.TabIndex = 12;
            this.btnProducto.TabStop = false;
            this.btnProducto.Text = "Productos";
            this.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(51)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCliente.Image = global::Tienda_Mascota.Iconos.animal_folder_32px;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 242);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(200, 51);
            this.btnCliente.TabIndex = 11;
            this.btnCliente.TabStop = false;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pSeparadorCatalogos
            // 
            this.pSeparadorCatalogos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pSeparadorCatalogos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.pSeparadorCatalogos.Location = new System.Drawing.Point(15, 234);
            this.pSeparadorCatalogos.Name = "pSeparadorCatalogos";
            this.pSeparadorCatalogos.Size = new System.Drawing.Size(183, 2);
            this.pSeparadorCatalogos.TabIndex = 10;
            // 
            // lblCatalogos
            // 
            this.lblCatalogos.AutoSize = true;
            this.lblCatalogos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCatalogos.ForeColor = System.Drawing.Color.White;
            this.lblCatalogos.Location = new System.Drawing.Point(10, 207);
            this.lblCatalogos.Name = "lblCatalogos";
            this.lblCatalogos.Size = new System.Drawing.Size(96, 25);
            this.lblCatalogos.TabIndex = 9;
            this.lblCatalogos.Text = "Catálogos";
            this.lblCatalogos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreCargo
            // 
            this.lblNombreCargo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCargo.ForeColor = System.Drawing.Color.White;
            this.lblNombreCargo.Location = new System.Drawing.Point(0, 114);
            this.lblNombreCargo.Name = "lblNombreCargo";
            this.lblNombreCargo.Size = new System.Drawing.Size(201, 71);
            this.lblNombreCargo.TabIndex = 7;
            this.lblNombreCargo.Text = "admin\r\nAdministrador";
            this.lblNombreCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFotoDePerfil
            // 
            this.pbFotoDePerfil.Image = global::Tienda_Mascota.FotosDePerfil.fox_512px;
            this.pbFotoDePerfil.Location = new System.Drawing.Point(0, 7);
            this.pbFotoDePerfil.Name = "pbFotoDePerfil";
            this.pbFotoDePerfil.Size = new System.Drawing.Size(201, 104);
            this.pbFotoDePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoDePerfil.TabIndex = 6;
            this.pbFotoDePerfil.TabStop = false;
            // 
            // pSeparadorBannerAbajo
            // 
            this.pSeparadorBannerAbajo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pSeparadorBannerAbajo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSeparadorBannerAbajo.Location = new System.Drawing.Point(201, 206);
            this.pSeparadorBannerAbajo.Name = "pSeparadorBannerAbajo";
            this.pSeparadorBannerAbajo.Size = new System.Drawing.Size(924, 1);
            this.pSeparadorBannerAbajo.TabIndex = 5;
            // 
            // pContenidoPrincipal
            // 
            this.pContenidoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenidoPrincipal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pContenidoPrincipal.Location = new System.Drawing.Point(201, 207);
            this.pContenidoPrincipal.Name = "pContenidoPrincipal";
            this.pContenidoPrincipal.Size = new System.Drawing.Size(924, 454);
            this.pContenidoPrincipal.TabIndex = 6;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1125, 661);
            this.Controls.Add(this.pContenidoPrincipal);
            this.Controls.Add(this.pSeparadorBannerAbajo);
            this.Controls.Add(this.pBanner);
            this.Controls.Add(this.pSeparadorBannerArriba);
            this.Controls.Add(this.pSeparadorMenu);
            this.Controls.Add(this.pMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Para Mascotas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenuPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.pBanner.ResumeLayout(false);
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoDePerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pSeparadorBannerArriba;
        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.Panel pBanner;
        private System.Windows.Forms.Panel pSeparadorMenu;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pSeparadorBannerAbajo;
        private System.Windows.Forms.Panel pSeparadorCatalogos;
        private System.Windows.Forms.Label lblCatalogos;
        private System.Windows.Forms.Label lblNombreCargo;
        private System.Windows.Forms.PictureBox pbFotoDePerfil;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnRecaudaciones;
        private System.Windows.Forms.Panel pSeparadorOperaciones;
        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Panel pSeparadorSeguridad;
        private System.Windows.Forms.Panel pSeparadorReportes;
        private System.Windows.Forms.Label lblSeguridad;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel pContenidoPrincipal;
    }
}