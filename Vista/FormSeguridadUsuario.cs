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
    public partial class FormSeguridadUsuario : Form
    {
        public FormSeguridadUsuario()
        {
            InitializeComponent();
        }

        private void FormSeguridadUsuarios_Load(object sender, EventArgs e)
        {
            btnRefrescar.PerformClick();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            dgUsuario.DataSource = CUsuario.MostarUsuarios();
            dgUsuario.CurrentCell = null;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            var frm = new FormSeguridadUsuarioEmergente();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                btnRefrescar.PerformClick();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgUsuario.SelectedRows.Count == 1)
            {
                int id = int.Parse(dgUsuario.CurrentRow.Cells["ID"].Value.ToString());
                string usuario = dgUsuario.CurrentRow.Cells["Usuario"].Value.ToString();
                string rol = dgUsuario.CurrentRow.Cells["Rol"].Value.ToString();
                var frm = new FormSeguridadUsuarioEmergente(id, usuario, rol);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
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
            if (dgUsuario.SelectedRows.Count == 1)
            {
                int id = int.Parse(dgUsuario.CurrentRow.Cells["ID"].Value.ToString());
                int res = CUsuario.HabilitarUsuario(id);
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
            if (dgUsuario.SelectedRows.Count == 1)
            {
                int id = int.Parse(dgUsuario.CurrentRow.Cells["ID"].Value.ToString());
                int res = CUsuario.DeshabilitarUsuario(id);
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
            dgUsuario.DataSource = CUsuario.BuscarUsuarios(txtBusqueda.Text);
            dgUsuario.CurrentCell = null;
        }
    }
}
