using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_Mascota.Modelo;

namespace Tienda_Mascota.Vista
{
    public partial class FormMenuPrincipal : Form
    {
        private MUsuario usuario;
        private List<Button> botones = new List<Button>();

        private Form formActivo = null;

        public FormMenuPrincipal(MUsuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            switch (usuario.rol)
            {
                case "Recepcionista":
                    botones.Add(btnCliente);
                    botones.Add(btnProducto);
                    btnFacturacion.Enabled = false;
                    btnRecaudaciones.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;

                case "Cajero":
                    btnCliente.Enabled = false;
                    btnProducto.Enabled = false;
                    botones.Add(btnFacturacion);
                    btnRecaudaciones.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;

                case "Reportes":
                    btnCliente.Enabled = false;
                    btnProducto.Enabled = false;
                    btnFacturacion.Enabled = false;
                    botones.Add(btnRecaudaciones);
                    btnUsuarios.Enabled = false;
                    break;

                case "Administrador":
                    btnCliente.Enabled = false;
                    btnProducto.Enabled = false;
                    btnFacturacion.Enabled = false;
                    btnRecaudaciones.Enabled = false;
                    botones.Add(btnUsuarios);
                    break;
            }
            lblNombreCargo.Text = $"{usuario.nombre}\n{usuario.rol}";
        }

        private void activarBoton(object transmisor)
        {
            if (transmisor.GetType() == typeof(Button))
            {
                var t = (Button)transmisor;
                foreach (var boton in botones)
                {
                    boton.BackColor = boton.Text == t.Text ? Color.FromArgb(255, 139, 0) : Color.FromArgb(34, 34, 34);
                    boton.FlatAppearance.MouseOverBackColor = boton.Text == t.Text ? boton.BackColor : Color.FromArgb(255, 179, 51);
                }
            }
        }

        private void abrirForm(Form form, object sender)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            activarBoton(sender);
            formActivo = form;
            formActivo.TopLevel = false;
            formActivo.Dock = DockStyle.Fill;
            pContenidoPrincipal.Controls.Add(formActivo);
            pContenidoPrincipal.Tag = formActivo;
            formActivo.BringToFront();
            formActivo.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            abrirForm(new FormCatalogoCliente(), sender);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            abrirForm(new FormCatalogoProducto(), sender);
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            abrirForm(new FormOperacionesFacturacion(usuario.idUsuario, usuario.nombre), sender);
        }

        private void btnRecaudaciones_Click(object sender, EventArgs e)
        {
            abrirForm(new FormProximamente(), sender);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirForm(new FormSeguridadUsuario(), sender);
        }

        private void FormMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
