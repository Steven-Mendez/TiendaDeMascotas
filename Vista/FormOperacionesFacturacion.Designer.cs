
namespace Tienda_Mascota.Vista
{
    partial class FormOperacionesFacturacion
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
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblClienteID = new System.Windows.Forms.Label();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.gpCliente = new System.Windows.Forms.GroupBox();
            this.gbVendedor = new System.Windows.Forms.GroupBox();
            this.txtVendedorID = new System.Windows.Forms.TextBox();
            this.lblVendedorNombre = new System.Windows.Forms.Label();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.txtVendedorNombre = new System.Windows.Forms.TextBox();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.lblProductoCantidad = new System.Windows.Forms.Label();
            this.txtProductoCantidad = new System.Windows.Forms.TextBox();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.lblProductoPrecio = new System.Windows.Forms.Label();
            this.txtProductoID = new System.Windows.Forms.TextBox();
            this.lblProductoNombre = new System.Windows.Forms.Label();
            this.lblProductoID = new System.Windows.Forms.Label();
            this.txtProductoPrecio = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.dgFactura = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpCliente.SuspendLayout();
            this.gbVendedor.SuspendLayout();
            this.gbProducto.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Image = global::Tienda_Mascota.Iconos.package_search_40px;
            this.btnBuscarProducto.Location = new System.Drawing.Point(6, 67);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(45, 45);
            this.btnBuscarProducto.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnBuscarProducto, "Buscar Producto");
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Image = global::Tienda_Mascota.Iconos.return_purchase_40px;
            this.btnEliminarProducto.Location = new System.Drawing.Point(6, 157);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(45, 45);
            this.btnEliminarProducto.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnEliminarProducto, "Eliminar Producto");
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Image = global::Tienda_Mascota.Iconos.add_shopping_cart_40px;
            this.btnAgregarProducto.Location = new System.Drawing.Point(6, 112);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(45, 45);
            this.btnAgregarProducto.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnAgregarProducto, "Agregar Producto");
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Image = global::Tienda_Mascota.Iconos.search_client_40px;
            this.btnBuscarCliente.Location = new System.Drawing.Point(6, 22);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(45, 45);
            this.btnBuscarCliente.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnBuscarCliente, "Buscar Cliente");
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClienteID.ForeColor = System.Drawing.Color.White;
            this.lblClienteID.Location = new System.Drawing.Point(6, 40);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(34, 25);
            this.lblClienteID.TabIndex = 18;
            this.lblClienteID.Text = "ID:";
            // 
            // txtClienteID
            // 
            this.txtClienteID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienteID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClienteID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtClienteID.Location = new System.Drawing.Point(97, 36);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.ReadOnly = true;
            this.txtClienteID.Size = new System.Drawing.Size(187, 33);
            this.txtClienteID.TabIndex = 17;
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClienteNombre.ForeColor = System.Drawing.Color.White;
            this.lblClienteNombre.Location = new System.Drawing.Point(6, 89);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(85, 25);
            this.lblClienteNombre.TabIndex = 20;
            this.lblClienteNombre.Text = "Nombre:";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienteNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClienteNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtClienteNombre.Location = new System.Drawing.Point(97, 85);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.ReadOnly = true;
            this.txtClienteNombre.Size = new System.Drawing.Size(187, 33);
            this.txtClienteNombre.TabIndex = 19;
            // 
            // gpCliente
            // 
            this.gpCliente.Controls.Add(this.txtClienteID);
            this.gpCliente.Controls.Add(this.lblClienteNombre);
            this.gpCliente.Controls.Add(this.lblClienteID);
            this.gpCliente.Controls.Add(this.txtClienteNombre);
            this.gpCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpCliente.ForeColor = System.Drawing.Color.White;
            this.gpCliente.Location = new System.Drawing.Point(12, 13);
            this.gpCliente.Name = "gpCliente";
            this.gpCliente.Size = new System.Drawing.Size(294, 137);
            this.gpCliente.TabIndex = 21;
            this.gpCliente.TabStop = false;
            this.gpCliente.Text = "Cliente";
            // 
            // gbVendedor
            // 
            this.gbVendedor.Controls.Add(this.txtVendedorID);
            this.gbVendedor.Controls.Add(this.lblVendedorNombre);
            this.gbVendedor.Controls.Add(this.lblVendedorID);
            this.gbVendedor.Controls.Add(this.txtVendedorNombre);
            this.gbVendedor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbVendedor.ForeColor = System.Drawing.Color.White;
            this.gbVendedor.Location = new System.Drawing.Point(12, 156);
            this.gbVendedor.Name = "gbVendedor";
            this.gbVendedor.Size = new System.Drawing.Size(294, 137);
            this.gbVendedor.TabIndex = 22;
            this.gbVendedor.TabStop = false;
            this.gbVendedor.Text = "Vendedor";
            // 
            // txtVendedorID
            // 
            this.txtVendedorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendedorID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVendedorID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtVendedorID.Location = new System.Drawing.Point(97, 36);
            this.txtVendedorID.Name = "txtVendedorID";
            this.txtVendedorID.ReadOnly = true;
            this.txtVendedorID.Size = new System.Drawing.Size(187, 33);
            this.txtVendedorID.TabIndex = 17;
            this.txtVendedorID.Text = "0";
            // 
            // lblVendedorNombre
            // 
            this.lblVendedorNombre.AutoSize = true;
            this.lblVendedorNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVendedorNombre.ForeColor = System.Drawing.Color.White;
            this.lblVendedorNombre.Location = new System.Drawing.Point(6, 89);
            this.lblVendedorNombre.Name = "lblVendedorNombre";
            this.lblVendedorNombre.Size = new System.Drawing.Size(85, 25);
            this.lblVendedorNombre.TabIndex = 20;
            this.lblVendedorNombre.Text = "Nombre:";
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVendedorID.ForeColor = System.Drawing.Color.White;
            this.lblVendedorID.Location = new System.Drawing.Point(6, 40);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(34, 25);
            this.lblVendedorID.TabIndex = 18;
            this.lblVendedorID.Text = "ID:";
            // 
            // txtVendedorNombre
            // 
            this.txtVendedorNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVendedorNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVendedorNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtVendedorNombre.Location = new System.Drawing.Point(97, 85);
            this.txtVendedorNombre.Name = "txtVendedorNombre";
            this.txtVendedorNombre.ReadOnly = true;
            this.txtVendedorNombre.Size = new System.Drawing.Size(187, 33);
            this.txtVendedorNombre.TabIndex = 19;
            this.txtVendedorNombre.Text = "admin";
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.lblProductoCantidad);
            this.gbProducto.Controls.Add(this.txtProductoCantidad);
            this.gbProducto.Controls.Add(this.txtProductoNombre);
            this.gbProducto.Controls.Add(this.lblProductoPrecio);
            this.gbProducto.Controls.Add(this.txtProductoID);
            this.gbProducto.Controls.Add(this.lblProductoNombre);
            this.gbProducto.Controls.Add(this.lblProductoID);
            this.gbProducto.Controls.Add(this.txtProductoPrecio);
            this.gbProducto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbProducto.ForeColor = System.Drawing.Color.White;
            this.gbProducto.Location = new System.Drawing.Point(12, 299);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(357, 137);
            this.gbProducto.TabIndex = 23;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Producto";
            // 
            // lblProductoCantidad
            // 
            this.lblProductoCantidad.AutoSize = true;
            this.lblProductoCantidad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductoCantidad.ForeColor = System.Drawing.Color.White;
            this.lblProductoCantidad.Location = new System.Drawing.Point(208, 40);
            this.lblProductoCantidad.Name = "lblProductoCantidad";
            this.lblProductoCantidad.Size = new System.Drawing.Size(92, 25);
            this.lblProductoCantidad.TabIndex = 24;
            this.lblProductoCantidad.Text = "Cantidad:";
            // 
            // txtProductoCantidad
            // 
            this.txtProductoCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductoCantidad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductoCantidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProductoCantidad.Location = new System.Drawing.Point(300, 36);
            this.txtProductoCantidad.Name = "txtProductoCantidad";
            this.txtProductoCantidad.Size = new System.Drawing.Size(48, 33);
            this.txtProductoCantidad.TabIndex = 5;
            this.txtProductoCantidad.TabStop = false;
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductoNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductoNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProductoNombre.Location = new System.Drawing.Point(97, 85);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.ReadOnly = true;
            this.txtProductoNombre.Size = new System.Drawing.Size(252, 33);
            this.txtProductoNombre.TabIndex = 21;
            // 
            // lblProductoPrecio
            // 
            this.lblProductoPrecio.AutoSize = true;
            this.lblProductoPrecio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductoPrecio.ForeColor = System.Drawing.Color.White;
            this.lblProductoPrecio.Location = new System.Drawing.Point(83, 40);
            this.lblProductoPrecio.Name = "lblProductoPrecio";
            this.lblProductoPrecio.Size = new System.Drawing.Size(69, 25);
            this.lblProductoPrecio.TabIndex = 22;
            this.lblProductoPrecio.Text = "Precio:";
            // 
            // txtProductoID
            // 
            this.txtProductoID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductoID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductoID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProductoID.Location = new System.Drawing.Point(44, 36);
            this.txtProductoID.Name = "txtProductoID";
            this.txtProductoID.ReadOnly = true;
            this.txtProductoID.Size = new System.Drawing.Size(35, 33);
            this.txtProductoID.TabIndex = 17;
            // 
            // lblProductoNombre
            // 
            this.lblProductoNombre.AutoSize = true;
            this.lblProductoNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductoNombre.ForeColor = System.Drawing.Color.White;
            this.lblProductoNombre.Location = new System.Drawing.Point(6, 89);
            this.lblProductoNombre.Name = "lblProductoNombre";
            this.lblProductoNombre.Size = new System.Drawing.Size(85, 25);
            this.lblProductoNombre.TabIndex = 20;
            this.lblProductoNombre.Text = "Nombre:";
            // 
            // lblProductoID
            // 
            this.lblProductoID.AutoSize = true;
            this.lblProductoID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductoID.ForeColor = System.Drawing.Color.White;
            this.lblProductoID.Location = new System.Drawing.Point(6, 40);
            this.lblProductoID.Name = "lblProductoID";
            this.lblProductoID.Size = new System.Drawing.Size(34, 25);
            this.lblProductoID.TabIndex = 18;
            this.lblProductoID.Text = "ID:";
            // 
            // txtProductoPrecio
            // 
            this.txtProductoPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductoPrecio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductoPrecio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProductoPrecio.Location = new System.Drawing.Point(156, 36);
            this.txtProductoPrecio.Name = "txtProductoPrecio";
            this.txtProductoPrecio.ReadOnly = true;
            this.txtProductoPrecio.Size = new System.Drawing.Size(48, 33);
            this.txtProductoPrecio.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAgregarProducto);
            this.groupBox4.Controls.Add(this.btnBuscarCliente);
            this.groupBox4.Controls.Add(this.btnEliminarProducto);
            this.groupBox4.Controls.Add(this.btnBuscarProducto);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(312, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(57, 210);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFacturar.Location = new System.Drawing.Point(390, 374);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(122, 52);
            this.btnFacturar.TabIndex = 25;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // dgFactura
            // 
            this.dgFactura.AllowUserToAddRows = false;
            this.dgFactura.AllowUserToDeleteRows = false;
            this.dgFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dgFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.TotalParcial});
            this.dgFactura.EnableHeadersVisualStyles = false;
            this.dgFactura.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dgFactura.Location = new System.Drawing.Point(390, 23);
            this.dgFactura.Name = "dgFactura";
            this.dgFactura.ReadOnly = true;
            this.dgFactura.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgFactura.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgFactura.RowTemplate.Height = 25;
            this.dgFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFactura.Size = new System.Drawing.Size(521, 339);
            this.dgFactura.TabIndex = 26;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // TotalParcial
            // 
            this.TotalParcial.HeaderText = "TotalParcial";
            this.TotalParcial.Name = "TotalParcial";
            this.TotalParcial.ReadOnly = true;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.ForeColor = System.Drawing.Color.White;
            this.lblSubTotal.Location = new System.Drawing.Point(643, 370);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(84, 25);
            this.lblSubTotal.TabIndex = 28;
            this.lblSubTotal.Text = "SubTotal";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSubTotal.Location = new System.Drawing.Point(736, 368);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(177, 33);
            this.txtSubTotal.TabIndex = 27;
            this.txtSubTotal.Text = "0";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(671, 411);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotal.Location = new System.Drawing.Point(736, 407);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(177, 33);
            this.txtTotal.TabIndex = 29;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(518, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 52);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormOperacionesFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(924, 454);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.dgFactura);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.gbVendedor);
            this.Controls.Add(this.gpCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOperacionesFacturacion";
            this.Text = "FormOperacionesFacturacion";
            this.gpCliente.ResumeLayout(false);
            this.gpCliente.PerformLayout();
            this.gbVendedor.ResumeLayout(false);
            this.gbVendedor.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.GroupBox gpCliente;
        private System.Windows.Forms.GroupBox gbVendedor;
        private System.Windows.Forms.TextBox txtVendedorID;
        private System.Windows.Forms.Label lblVendedorNombre;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.TextBox txtVendedorNombre;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.Label lblProductoCantidad;
        private System.Windows.Forms.TextBox txtProductoCantidad;
        private System.Windows.Forms.TextBox txtProductoNombre;
        private System.Windows.Forms.Label lblProductoPrecio;
        private System.Windows.Forms.TextBox txtProductoID;
        private System.Windows.Forms.Label lblProductoNombre;
        private System.Windows.Forms.Label lblProductoID;
        private System.Windows.Forms.TextBox txtProductoPrecio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.DataGridView dgFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalParcial;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCancelar;
    }
}