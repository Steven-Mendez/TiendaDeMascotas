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
    public partial class FormCatalogoCliente : Form
    {
        public FormCatalogoCliente()
        {
            InitializeComponent();
        }

        private void FormCatalogoCliente_Load(object sender, EventArgs e)
        {
            btnRefrescar.PerformClick();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            dgClientes.DataSource = CCliente.MostrarCliente();
            dgClientes.CurrentCell = null;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            var form = new FormCatalogoClienteEmergente();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                btnRefrescar.PerformClick();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count == 1)
            {
                int id = int.Parse(dgClientes.CurrentRow.Cells["ID"].Value.ToString());
                string pNombre = dgClientes.CurrentRow.Cells["Primer Nombre"].Value.ToString();
                string sNombre = dgClientes.CurrentRow.Cells["Segundo Nombre"].Value.ToString();
                string pApellido = dgClientes.CurrentRow.Cells["Primer Apellido"].Value.ToString();
                string sApellido = dgClientes.CurrentRow.Cells["Segundo Apellido"].Value.ToString();
                string correo = dgClientes.CurrentRow.Cells["Correo"].Value.ToString();
                string celular = dgClientes.CurrentRow.Cells["Celular"].Value.ToString();

                var form = new FormCatalogoClienteEmergente(id, pNombre, sNombre, pApellido, sApellido, correo, celular);
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
            if (dgClientes.SelectedRows.Count == 1)
            {
                int id = int.Parse(dgClientes.CurrentRow.Cells["ID"].Value.ToString());
                int res = CCliente.HabilitarCliente(id);
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
            if (dgClientes.SelectedRows.Count == 1)
            {
                int id = int.Parse(dgClientes.CurrentRow.Cells["ID"].Value.ToString());
                int res = CCliente.DeshabilitarCliente(id);
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
            dgClientes.DataSource = CCliente.BuscarCliente(txtBusqueda.Text);
            dgClientes.CurrentCell = null;
        }
    }
}
