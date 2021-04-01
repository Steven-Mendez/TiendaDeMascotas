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
using Tienda_Mascota.Modelo;

namespace Tienda_Mascota.Vista
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable res = CUsuario.ValidarAcceso(txtUsuario.Text, txtContraseña.Text);
            if (res != null)
            {
                if (res.Rows[0]["Resultado"].ToString() == "Acceso Exitoso" && res.Rows[0]["Estado"].ToString() == "Habilitado")
                {
                    var usuario = new MUsuario()
                    {
                        idUsuario = int.Parse(res.Rows[0]["ID"].ToString()),
                        estado = res.Rows[0]["Estado"].ToString(),
                        rol = res.Rows[0]["Rol"].ToString(),
                        nombre = res.Rows[0]["Usuario"].ToString()
                    };
                    new FormMenuPrincipal(usuario).Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectas", "Sistema de reservas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("No hay conexión con el serividor", "Sistema de reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnIngresar.PerformClick();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            error(txtUsuario.Text, pbUsuario, pbIconoUsuario);
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            error(txtContraseña.Text, pbContraseña, pbIconoContraseña);
        }

        private void error(string txt, PictureBox marco, PictureBox icono)
        {
            if (string.IsNullOrEmpty(txt) || string.IsNullOrWhiteSpace(txt))
            {
                marco.Image = Imagenes.txt_rojo;
                icono.Image = Iconos.high_priority_20px;
            }
            else
            {
                marco.Image = Imagenes.txt_naranja;
                icono.Image = Iconos.ok_20px;
            }
        }
    }
}
