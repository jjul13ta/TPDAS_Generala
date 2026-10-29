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
    public partial class frmPartidaNueva : Form
    {
        private BLL_Partida gestorPartida = new BLL_Partida();

        // Partida ya iniciada, lista para jugar (null si se canceló)
        private Partida partida;
        public Partida Partida
        {
            get { return partida; }
        }

        public frmPartidaNueva()
        {
            InitializeComponent();
        }

        private void frmPartidaNueva_Load(object sender, EventArgs e)
        {
            // Cada combo necesita su propia lista, si no quedan sincronizados entre sí
            cmbJugador1.DataSource = new List<Usuario>(BLL_Usuario.UsuariosLogueados);
            cmbJugador1.DisplayMember = "UserName";

            cmbJugador2.DataSource = new List<Usuario>(BLL_Usuario.UsuariosLogueados);
            cmbJugador2.DisplayMember = "UserName";

            if (cmbJugador2.Items.Count > 1)
                cmbJugador2.SelectedIndex = 1;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Usuario jugador1 = cmbJugador1.SelectedItem as Usuario;
            Usuario jugador2 = cmbJugador2.SelectedItem as Usuario;

            if (jugador1 == null || jugador2 == null)
            {
                MessageBox.Show("Elegí los dos jugadores.", "Nueva partida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Partida nueva = new Partida();
            nueva.Jugador1 = jugador1;
            nueva.Jugador2 = jugador2;

            try
            {
                if (!gestorPartida.IniciarPartida(nueva))
                {
                    MessageBox.Show("Los dos jugadores tienen que ser distintos.", "Nueva partida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo iniciar la partida.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            partida = nueva;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
