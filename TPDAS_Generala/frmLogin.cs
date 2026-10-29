using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace TPDAS_Generala
{
    public partial class frmLogin : Form
    {
        private BLL_Usuario gestorUsuario = new BLL_Usuario();

        // Usuario que inició sesión (null si se cerró sin loguearse)
        private Usuario usuarioLogueado;
        public Usuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            uiUsuario.Enfocar();
        }

        private bool ValidarCampos()
        {
            bool usuarioOk = uiUsuario.Validar();
            bool passwordOk = uiPassword.Validar();

            if (!usuarioOk || !passwordOk)
            {
                MostrarError("Completá usuario y contraseña.");
                return false;
            }
            return true;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string nombre = uiUsuario.Texto.Trim();

            try
            {
                if (gestorUsuario.EstaLogueado(nombre))
                {
                    MostrarError("El usuario " + nombre + " ya tiene la sesión iniciada.");
                    return;
                }

                Usuario u = gestorUsuario.Login(nombre, uiPassword.Texto);
                if (u == null)
                {
                    MostrarError("Usuario o contraseña incorrectos.");
                    uiPassword.Limpiar();
                    uiPassword.Enfocar();
                    return;
                }

                usuarioLogueado = u;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string nombre = uiUsuario.Texto.Trim();

            try
            {
                if (gestorUsuario.Registrar(nombre, uiPassword.Texto))
                {
                    lblMensaje.ForeColor = Color.FromArgb(46, 125, 50);
                    lblMensaje.Text = "Usuario " + nombre + " creado. Ya podés iniciar sesión.";
                }
                else
                {
                    MostrarError("El usuario " + nombre + " ya existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la base de datos.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarError(string mensaje)
        {
            lblMensaje.ForeColor = Color.FromArgb(198, 40, 40);
            lblMensaje.Text = mensaje;
        }
    }
}
