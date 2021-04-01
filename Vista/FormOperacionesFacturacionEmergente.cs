using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_Mascota.Controlador;

namespace Tienda_Mascota.Vista
{
    public partial class FormOperacionesFacturacionEmergente : Form
    {
        private bool cliente = true;

        public FormOperacionesFacturacionEmergente()
        {
            InitializeComponent();
        }

        public FormOperacionesFacturacionEmergente(bool cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void FormOperacionesFacturacionEmergente_Load(object sender, EventArgs e)
        {
            if (cliente)
            {
                dgDatos.DataSource = CCliente.MostrarCliente();
            }
            else
            {
                dgDatos.DataSource = CProducto.MostrarProductos();
                Text = "Buscar Producto";
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (cliente)
            {
                dgDatos.DataSource = CCliente.BuscarCliente(txtBusqueda.Text);
            }
            else
            {
                dgDatos.DataSource = CProducto.BuscarProducto(txtBusqueda.Text);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgDatos.SelectedRows.Count == 1)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila de la tabla.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
