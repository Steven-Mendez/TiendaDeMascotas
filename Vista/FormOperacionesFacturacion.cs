using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_Mascota.Controlador;

namespace Tienda_Mascota.Vista
{
    public partial class FormOperacionesFacturacion : Form
    {
        private double total = 0;

        public FormOperacionesFacturacion(int id, string nombre)
        {
            InitializeComponent();
            txtVendedorID.Text = id.ToString();
            txtVendedorNombre.Text = nombre;
            txtSubTotal.Text = txtTotal.Text = $"{0:C2}";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            var frm = new FormOperacionesFacturacionEmergente();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                int i = frm.dgDatos.CurrentRow.Index;
                txtClienteID.Text = frm.dgDatos.Rows[i].Cells["ID"].Value.ToString();
                string nombre = frm.dgDatos.Rows[i].Cells["Primer Nombre"].Value.ToString();
                string apellido = frm.dgDatos.Rows[i].Cells["Primer Apellido"].Value.ToString();
                txtClienteNombre.Text = $"{nombre} {apellido}";
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            var frm = new FormOperacionesFacturacionEmergente(false);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                int i = frm.dgDatos.CurrentRow.Index;
                txtProductoID.Text = frm.dgDatos.Rows[i].Cells["ID"].Value.ToString();
                txtProductoNombre.Text = frm.dgDatos.Rows[i].Cells["Nombre"].Value.ToString();
                txtProductoPrecio.Text = frm.dgDatos.Rows[i].Cells["Precio"].Value.ToString();
                txtProductoCantidad.Clear();
                txtProductoCantidad.Focus();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductoID.Text))
            {
                MessageBox.Show("Ingrese un producto.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(txtProductoCantidad.Text, out int aux))
            {
                MessageBox.Show("Campo cantidad erroneo.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (aux <= 0)
            {
                MessageBox.Show("Cantidad debe ser mayor a 0.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool existe = false;
                int i = 0;
                foreach (DataGridViewRow fila in dgFactura.Rows)
                {
                    if (fila.Cells["ID"].Value.ToString() == txtProductoID.Text)
                    {
                        existe = true;
                        i = fila.Index;
                        break;
                    }
                }
                if (existe)
                {
                    var cantidad = int.Parse(txtProductoCantidad.Text)
                                   + Convert.ToInt32(dgFactura.Rows[i].Cells["Cantidad"].Value);
                    var precio = double.Parse(txtProductoPrecio.Text);

                    dgFactura.Rows[i].Cells["Cantidad"].Value = cantidad;
                    dgFactura.Rows[i].Cells["TotalParcial"].Value = precio * cantidad;
                }
                else
                {
                    dgFactura.Rows.Add(txtProductoID.Text, txtProductoNombre.Text, txtProductoPrecio.Text,
                                       txtProductoCantidad.Text);

                    var cantidad = int.Parse(txtProductoCantidad.Text);
                    var precio = double.Parse(txtProductoPrecio.Text);

                    dgFactura.Rows[dgFactura.Rows.Count - 1].Cells["TotalParcial"].Value = cantidad * precio;
                }
            }
            total = 0;
            foreach (DataGridViewRow Fila in dgFactura.Rows)
            {
                total += Convert.ToDouble(Fila.Cells["TotalParcial"].Value);
            }
            txtSubTotal.Text = $"{total:C2}";
            txtTotal.Text = $"{total * 1.15:C2}";
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgFactura.SelectedRows.Count == 1)
            {
                total -= Convert.ToDouble(dgFactura.Rows[dgFactura.CurrentRow.Index].Cells["TotalParcial"].Value);
                txtSubTotal.Text = $"{total:C2}";
                txtTotal.Text = $"{total * 1.15:C2}";
                dgFactura.Rows.RemoveAt(dgFactura.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClienteID.Text))
            {
                MessageBox.Show("No se ha asociado un cliente.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dgFactura.Rows.Count <= 0)
            {
                MessageBox.Show("No hay productos a facturar.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable factura = CFactura.InsertarFactura(int.Parse(txtClienteID.Text), txtVendedorNombre.Text);
                if (factura is not null)
                {
                    int res = 0;
                    int idFactura = int.Parse(factura.Rows[0]["IDFactura"].ToString());
                    foreach (DataGridViewRow fila in dgFactura.Rows)
                    {
                        fila.Cells["TotalParcial"].Value.ToString();
                        int idProducto = int.Parse(fila.Cells["ID"].Value.ToString());
                        double precio = double.Parse(fila.Cells["Precio"].Value.ToString());
                        int cantidad = int.Parse(fila.Cells["Cantidad"].Value.ToString());
                        res = CFactura.InsertarDetalleFactura(idFactura, idProducto, precio, cantidad);
                    }
                    if (res > 0)
                    {
                        MessageBox.Show("Datos ingresados con exito.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCancelar.PerformClick();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtClienteID.Text = txtClienteNombre.Text = string.Empty;
            txtProductoID.Text = txtProductoPrecio.Text = txtProductoCantidad.Text = string.Empty;
            txtProductoNombre.Text = string.Empty;
            dgFactura.Rows.Clear();
            total = 0;
            txtSubTotal.Text = txtTotal.Text = $"{total:C2}";
        }
    }
}
