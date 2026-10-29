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
    public partial class frmEstadisticas : Form
    {
        private BLL_Usuario gestorUsuario = new BLL_Usuario();
        private BLL_Partida gestorPartida = new BLL_Partida();

        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> usuarios = gestorUsuario.Listar();
                cmbUsuario.DataSource = usuarios;
                cmbUsuario.DisplayMember = "UserName";

                // Por defecto muestra al primer usuario con sesión iniciada
                if (BLL_Usuario.UsuariosLogueados.Count > 0)
                {
                    int id = BLL_Usuario.UsuariosLogueados[0].ID;
                    int indice = usuarios.FindIndex(u => u.ID == id);
                    if (indice >= 0)
                        cmbUsuario.SelectedIndex = indice;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los usuarios.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario u = cmbUsuario.SelectedItem as Usuario;
            if (u == null)
                return;

            try
            {
                int ganadas = gestorPartida.Ganadas(u);
                int perdidas = gestorPartida.Perdidas(u);
                int empatadas = gestorPartida.Empatadas(u);
                double promedio = gestorPartida.PromedioVictorias(u);
                TimeSpan tiempo = TimeSpan.FromSeconds(gestorPartida.TiempoTotal(u));

                lblGanadas.Text = ganadas.ToString();
                lblPerdidas.Text = perdidas.ToString();
                lblEmpatadas.Text = empatadas.ToString();
                lblJugadas.Text = (ganadas + perdidas + empatadas).ToString();
                lblPromedio.Text = promedio.ToString("0.#") + " %";
                barPromedio.Value = (int)Math.Round(promedio);
                lblTiempo.Text = ((int)tiempo.TotalHours).ToString("00") + ":" + tiempo.Minutes.ToString("00") + ":" + tiempo.Seconds.ToString("00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron calcular las estadísticas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
