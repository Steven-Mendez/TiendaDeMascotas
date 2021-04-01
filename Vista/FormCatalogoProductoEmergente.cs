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
    public partial class FormCatalogoProductoEmergente : Form
    {
        public bool añadir = true;

        private int id;

        public FormCatalogoProductoEmergente()
        {
            InitializeComponent();
        }

        public FormCatalogoProductoEmergente(int idProducto, string nombre, string descripcion, string inventario, string precio, string costo, string unidadesVendidas, DateTime fechaIngreso)
        {
            InitializeComponent();
            id = idProducto;
            añadir = false;
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtInventario.Text = inventario;
            txtPrecio.Text = precio;
            txtCosto.Text = costo;
            txtUnidadesVendidas.Text = unidadesVendidas;
            dtpFechaIngreso.Value = fechaIngreso;
            Text = "Modificar Producto";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (añadir)
                {
                    Añadir();
                }
                else
                {
                    Editar();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Algunos campos son incorrectos, verifica que los nombres y/o apellidos comiencen por mayuscula, utiliza un correo valido con todos los caracteres en minúsculas y escribe tu numero de telefono con 8 digitios consecutivos, recuerda que tampoco puede empezar por 0.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Añadir()
        {
            int res = CProducto.NuevoProducto(txtNombre.Text, txtDescripcion.Text, int.Parse(txtInventario.Text), float.Parse(txtPrecio.Text), float.Parse(txtCosto.Text), int.Parse(txtUnidadesVendidas.Text), dtpFechaIngreso.Value);
            if (res == 1)
            {
                MessageBox.Show("Producto Ingresado Correctamente.", "Tienda Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ocurrió un error, verifica y vuelvelo a intentar.", "Tienda Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editar()
        {
            int res = CProducto.ModificarProducto(id, txtNombre.Text, txtDescripcion.Text, int.Parse(txtInventario.Text), float.Parse(txtPrecio.Text), float.Parse(txtPrecio.Text), int.Parse(txtUnidadesVendidas.Text), dtpFechaIngreso.Value);
            if (res == 1)
            {
                MessageBox.Show("Producto Modificado Correctamente.", "Tienda Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ocurrió un error, verifica y vuelvelo a intentar.", "Tienda Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (!string.IsNullOrEmpty(txt.Text) && txt.Text.Length <= 50)
            {
                txt.ForeColor = Color.Green;
            }
            else
            {
                txt.ForeColor = Color.Red;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (!string.IsNullOrEmpty(txt.Text) && txt.Text.Length <= 100)
            {
                txt.ForeColor = Color.Green;
            }
            else
            {
                txt.ForeColor = Color.Red;
            }
        }

        private void txtInventario_TextChanged(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (int.TryParse(txt.Text, out _))
                txt.ForeColor = Color.Green;
            else
                txt.ForeColor = Color.Red;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (float.TryParse(txt.Text, out _))
                txt.ForeColor = Color.Green;
            else
                txt.ForeColor = Color.Red;
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (float.TryParse(txt.Text, out _))
                txt.ForeColor = Color.Green;
            else
                txt.ForeColor = Color.Red;
        }

        private void txtUnidadesVendidas_TextChanged(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (int.TryParse(txt.Text, out _))
                txt.ForeColor = Color.Green;
            else
                txt.ForeColor = Color.Red;
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtNombre.Text) && (int.TryParse(txtInventario.Text, out _)) &&
                float.TryParse(txtPrecio.Text, out _) && float.TryParse(txtCosto.Text, out _) && (int.TryParse(txtUnidadesVendidas.Text, out _)) &&
                txtNombre.Text.Length <= 50 && txtDescripcion.Text.Length <= 100;
        }
    }
}
