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
    public partial class FormCatalogoProducto : Form
    {
        public FormCatalogoProducto()
        {
            InitializeComponent();
        }

        private void FormCatalogoProducto_Load(object sender, EventArgs e)
        {
            btnRefrescar.PerformClick();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            dgProductos.DataSource = CProducto.MostrarProductos();
            dgProductos.CurrentCell = null;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            var form = new FormCatalogoProductoEmergente();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                btnRefrescar.PerformClick();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 1)
            {
                int id = int.Parse(dgProductos.CurrentRow.Cells["ID"].Value.ToString());
                string nombre = dgProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                string descripcion = dgProductos.CurrentRow.Cells["Descripción"].Value.ToString();
                string inventario = dgProductos.CurrentRow.Cells["Precio"].Value.ToString();
                string precio = dgProductos.CurrentRow.Cells["Inventario"].Value.ToString();
                string costo = dgProductos.CurrentRow.Cells["Costo"].Value.ToString();
                string unidadesVendidas = dgProductos.CurrentRow.Cells["Unidades Vendidas"].Value.ToString();
                DateTime fechaIngreso = DateTime.Parse(dgProductos.CurrentRow.Cells["Fecha Ingreso"].Value.ToString());

                var form = new FormCatalogoProductoEmergente(id, nombre, descripcion, inventario, precio, costo, unidadesVendidas, fechaIngreso);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    btnRefrescar.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 1)
            {
                int id = int.Parse(dgProductos.CurrentRow.Cells["ID"].Value.ToString());
                int res = CProducto.HabilitarProducto(id);
                if (res == 1)
                {
                    btnRefrescar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 1)
            {
                int id = int.Parse(dgProductos.CurrentRow.Cells["ID"].Value.ToString());
                int res = CProducto.DeshabilitarProducto(id);
                if (res == 1)
                {
                    btnRefrescar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila antes de modificar.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            dgProductos.DataSource = CProducto.BuscarProducto(txtBusqueda.Text);
            dgProductos.CurrentCell = null;
        }
    }
}
