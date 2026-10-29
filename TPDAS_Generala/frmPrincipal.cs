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
    public partial class frmPrincipal : Form
    {
        private BLL_Usuario gestorUsuario = new BLL_Usuario();

        // Sólo se juega una partida a la vez
        private frmPartida partidaActiva;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Fondo del área MDI
            foreach (Control c in Controls)
            {
                if (c is MdiClient)
                    c.BackColor = Color.FromArgb(232, 240, 233);
            }

            ActualizarEstado();
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            AbrirLogin();
        }

        // ---------- Ventanas ----------

        // Abre el formulario como hijo MDI, o lo trae al frente si ya estaba abierto
        private void AbrirHijo<T>() where T : Form, new()
        {
            foreach (Form f in MdiChildren)
            {
                if (f is T)
                {
                    f.Activate();
                    return;
                }
            }

            T nuevo = new T();
            nuevo.MdiParent = this;
            nuevo.StartPosition = FormStartPosition.CenterScreen;
            nuevo.Show();
        }

        private void ActualizarEstado()
        {
            List<Usuario> logueados = BLL_Usuario.UsuariosLogueados;

            if (logueados.Count == 0)
                lblEstado.Text = "Sin usuarios conectados";
            else
                lblEstado.Text = "Conectados: " + string.Join(", ", logueados.Select(u => u.UserName));

            mnuCerrarSesion.Enabled = logueados.Count > 0;
        }

        // ---------- Usuarios ----------

        private void AbrirLogin()
        {
            using (frmLogin login = new frmLogin())
            {
                if (login.ShowDialog(this) == DialogResult.OK)
                {
                    ActualizarEstado();
                    MessageBox.Show("¡Hola " + login.UsuarioLogueado.UserName + "!" +
                        (BLL_Usuario.UsuariosLogueados.Count < 2 ? "\nPara jugar, iniciá sesión con un segundo usuario." : ""),
                        "Generala", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void mnuIniciarSesion_Click(object sender, EventArgs e)
        {
            AbrirLogin();
        }

        private void mnuCerrarSesion_DropDownOpening(object sender, EventArgs e)
        {
            mnuCerrarSesion.DropDownItems.Clear();
            foreach (Usuario u in BLL_Usuario.UsuariosLogueados)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(u.UserName);
                item.Tag = u;
                item.Click += CerrarSesionUsuario_Click;
                mnuCerrarSesion.DropDownItems.Add(item);
            }
        }

        private void CerrarSesionUsuario_Click(object sender, EventArgs e)
        {
            Usuario u = (Usuario)((ToolStripMenuItem)sender).Tag;

            if (EstaJugando(u))
            {
                MessageBox.Show(u.UserName + " está jugando una partida. Terminala o cerrala antes de cerrar la sesión.",
                    "Cerrar sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CerrarSesion(u);
            ActualizarEstado();
        }

        private void CerrarSesion(Usuario u)
        {
            try
            {
                gestorUsuario.Logout(u);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se cerró la sesión de " + u.UserName + " pero no se pudo registrar en la bitácora.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HayPartidaEnCurso()
        {
            return partidaActiva != null && !partidaActiva.IsDisposed && !partidaActiva.Terminada;
        }

        private bool EstaJugando(Usuario u)
        {
            return HayPartidaEnCurso()
                && (partidaActiva.Partida.Jugador1.ID == u.ID || partidaActiva.Partida.Jugador2.ID == u.ID);
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ---------- Juego ----------

        private void mnuNuevaPartida_Click(object sender, EventArgs e)
        {
            if (HayPartidaEnCurso())
            {
                partidaActiva.Activate();
                MessageBox.Show("Ya hay una partida en curso.", "Nueva partida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (BLL_Usuario.UsuariosLogueados.Count < 2)
            {
                DialogResult r = MessageBox.Show("Para jugar se necesitan dos usuarios con sesión iniciada.\n¿Querés iniciar sesión ahora?",
                    "Nueva partida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                    AbrirLogin();
                if (BLL_Usuario.UsuariosLogueados.Count < 2)
                    return;
            }

            using (frmPartidaNueva nueva = new frmPartidaNueva())
            {
                if (nueva.ShowDialog(this) != DialogResult.OK)
                    return;

                if (partidaActiva != null && !partidaActiva.IsDisposed)
                    partidaActiva.Close(); // la anterior ya terminó

                partidaActiva = new frmPartida(nueva.Partida);
                partidaActiva.MdiParent = this;
                partidaActiva.FormClosed += (s, args) => partidaActiva = null;
                partidaActiva.WindowState = FormWindowState.Maximized;
                partidaActiva.Show();
            }
        }

        // ---------- Consultas / Administración ----------

        private void mnuEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirHijo<frmEstadisticas>();
        }

        private void mnuBitacora_Click(object sender, EventArgs e)
        {
            AbrirHijo<frmBitacora>();
        }

        private void mnuBackup_Click(object sender, EventArgs e)
        {
            if (HayPartidaEnCurso())
            {
                MessageBox.Show("Terminá la partida en curso antes de hacer un backup o restore.",
                    "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AbrirHijo<frmBackup>();
        }

        // ---------- Cierre ----------

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HayPartidaEnCurso())
            {
                DialogResult r = MessageBox.Show("Hay una partida en curso que no se va a guardar.\n¿Salir igual?",
                    "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }
            }

            // Cierra todas las sesiones abiertas (queda registrado en la bitácora)
            foreach (Usuario u in BLL_Usuario.UsuariosLogueados.ToList())
            {
                CerrarSesion(u);
            }
        }
    }
}
