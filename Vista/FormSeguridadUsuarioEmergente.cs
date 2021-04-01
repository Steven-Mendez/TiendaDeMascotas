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
    public partial class FormSeguridadUsuarioEmergente : Form
    {
        private bool nuevo = true;
        private int id;

        public FormSeguridadUsuarioEmergente()
        {
            InitializeComponent();
            cbRol.DataSource = new string[] { "Administrador", "Cajero", "Recepcionista", "Reportes" };
        }

        public FormSeguridadUsuarioEmergente(int id, string usuario, string rol)
        {
            InitializeComponent();
            Text = "Modificar Usuario";
            nuevo = false;
            this.id = id;
            txtUsuario.Text = usuario;
            txtUsuario.Enabled = false;
            cbRol.DataSource = new string[] { "Administrador", "Cajero", "Recepcionista", "Reportes" };
            switch (rol)
            {
                case "Administrador":
                    cbRol.SelectedIndex = 0;
                    break;
                case "Cajero":
                    cbRol.SelectedIndex = 1;
                    break;
                case "Recepcionista":
                    cbRol.SelectedIndex = 2;
                    break;
                case "Reportes":
                    cbRol.SelectedIndex = 3;
                    break;
                default:
                    cbRol.SelectedIndex = 0;
                    break;
            }
            txtContraseña.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {
                NuevoUsuario();
            }
            else
            {
                Editar();
            }
        }

        private void NuevoUsuario()
        {
            if (txtContraseña.Text != txtConfirmación.Text)
            {
                MessageBox.Show("Los campos contraseña y verificación no coinciden.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese una contraseña valida", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Clear();
                txtConfirmación.Clear();
                txtContraseña.Focus();
            }
            else
            {
                var res = CUsuario.NuevoUsuario(txtUsuario.Text, txtContraseña.Text, cbRol.Text);
                if (res == 1)
                {
                    MessageBox.Show("Usuario ingresado correctamente.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error, verifica y vuelvelo a intentar.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Editar()
        {
            if (txtContraseña.Text != txtConfirmación.Text)
            {
                MessageBox.Show("Los campos contraseña y verificación no coinciden.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese una contraseña valida", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Clear();
                txtConfirmación.Clear();
                txtContraseña.Focus();
            }
            else
            {
                var res = CUsuario.ModificarUsuario(id, txtContraseña.Text, cbRol.Text);
                if (res == 1)
                {
                    MessageBox.Show("Usuario modificado correctamente.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error, verifica y vuelvelo a intentar.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.ForeColor = Color.Red;
            }
            else
            {
                txtUsuario.ForeColor = Color.Green;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtConfirmación.Text))
            {
                txtContraseña.ForeColor = Color.Red;
                txtConfirmación.ForeColor = Color.Red;
            }
            else
            {
                txtContraseña.ForeColor = Color.Green;
                txtConfirmación.ForeColor = Color.Green;
            }
        }

        private void txtConfirmación_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtConfirmación.Text))
            {
                txtContraseña.ForeColor = Color.Red;
                txtConfirmación.ForeColor = Color.Red;
            }
            else
            {
                txtContraseña.ForeColor = Color.Green;
                txtConfirmación.ForeColor = Color.Green;
            }
        }
    }
}
