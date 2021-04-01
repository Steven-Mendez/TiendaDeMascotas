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
    public partial class FormCatalogoClienteEmergente : Form
    {
        private bool añadir = true;

        private int id;

        public FormCatalogoClienteEmergente()
        {
            InitializeComponent();
        }

        public FormCatalogoClienteEmergente(int id, string nombre, string nombre2, string apellido, string apellido2, string correo, string celular)
        {
            InitializeComponent();
            añadir = false;
            Text = "Modificar Cliente";
            this.id = id;
            txtNombre.Text = nombre;
            txtNombre2.Text = nombre2;
            txtApellido.Text = apellido;
            txtApellido2.Text = apellido2.Trim();
            txtCorreo.Text = correo;
            txtCelular.Text = celular;
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
            }
            else
            {
                MessageBox.Show("Algunos campos son incorrectos, verifica que los nombres y/o apellidos comiencen por mayuscula, utiliza un correo valido con todos los caracteres en minúsculas y escribe tu numero de telefono con 8 digitios consecutivos, recuerda que tampoco puede empezar por 0.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Añadir()
        {
            var res = CCliente.NuevoCliente(txtNombre.Text, txtNombre2.Text, txtApellido.Text, txtApellido2.Text, txtCorreo.Text, int.Parse(txtCelular.Text));
            if (res == 1)
            {
                MessageBox.Show("Cliente ingresado correctamente.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error, verifica y vuelvelo a intentar.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Editar()
        {
            var res = CCliente.ModificarCliente(id, txtNombre.Text, txtNombre2.Text, txtApellido.Text, txtApellido2.Text, txtCorreo.Text, int.Parse(txtCelular.Text));
            if (res == 1)
            {
                MessageBox.Show("Cliente ingresado correctamente.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error, verifica y vuelvelo a intentar.", "Productos Para Mascotas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarNombre(sender);
        }

        private void txtNombre2_TextChanged(object sender, EventArgs e)
        {
            ValidarNombre(sender);
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ValidarNombre(sender);
        }

        private void txtApellido2_TextChanged(object sender, EventArgs e)
        {
            ValidarNombre(sender);
        }

        private const string patronNombre = @"^[A-Z][a-z]{1,50}$";
        private const string patronCorreo = @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        private const string patronCelular = @"^[1-9][0-9]{7}$";

        private bool ValidarCampos()
        {
            return Regex.IsMatch(txtNombre.Text, patronNombre) && Regex.IsMatch(txtNombre2.Text, patronNombre) &&
                   Regex.IsMatch(txtApellido.Text, patronNombre) && Regex.IsMatch(txtApellido2.Text, patronNombre) &&
                   Regex.IsMatch(txtCorreo.Text, patronCorreo) && Regex.IsMatch(txtCelular.Text, patronCelular);
        }

        private void ValidarNombre(object transmisor)
        {
            if (transmisor.GetType() == typeof(TextBox))
            {
                var txt = (TextBox)transmisor;
                if (Regex.IsMatch(txt.Text, patronNombre))
                {
                    txt.ForeColor = Color.Green;
                }
                else
                {
                    txt.ForeColor = Color.Red;
                }
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                var txt = (TextBox)sender;
                if (Regex.IsMatch(txt.Text, patronCorreo))
                {
                    txt.ForeColor = Color.Green;
                }
                else
                {
                    txt.ForeColor = Color.Red;
                }
            }
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
            {
                var txt = (TextBox)sender;
                if (Regex.IsMatch(txt.Text, patronCelular))
                {
                    txt.ForeColor = Color.Green;
                }
                else
                {
                    txt.ForeColor = Color.Red;
                }
            }
        }
    }
}
