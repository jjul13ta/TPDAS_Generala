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
    public partial class frmPartida : Form
    {
        private const int CantidadCategorias = 10;
        private const int FilaTotal = CantidadCategorias;

        private static readonly Color ColorTurno = Color.FromArgb(255, 193, 7);
        private static readonly Color ColorEncabezado = Color.FromArgb(55, 71, 79);
        private static readonly Color ColorPosible = Color.FromArgb(129, 160, 130);
        private static readonly Color ColorTexto = Color.FromArgb(38, 50, 56);
        private static readonly Color ColorTachado = Color.FromArgb(198, 40, 40);
        private static readonly Color ColorFondoTurno = Color.FromArgb(255, 248, 225);
        private static readonly Color ColorFondoTotal = Color.FromArgb(232, 245, 233);

        private static readonly Font FuenteAnotada = new Font("Segoe UI", 11F, FontStyle.Bold);
        private static readonly Font FuentePosible = new Font("Segoe UI", 10F, FontStyle.Italic);
        private static readonly Font FuenteTotal = new Font("Segoe UI", 12F, FontStyle.Bold);

        private BLL_Partida gestorPartida = new BLL_Partida();
        private BLL_Turno gestorTurno = new BLL_Turno();
        private BLL_Planilla gestorPlanilla = new BLL_Planilla();
        private BLL_Bitacora gestorBitacora = new BLL_Bitacora();

        private Partida partida;
        public Partida Partida
        {
            get { return partida; }
        }

        private bool terminada;
        public bool Terminada
        {
            get { return terminada; }
        }

        private Turno turno;
        private UC_DADO[] dados;

        public frmPartida()
        {
            InitializeComponent();
        }

        public frmPartida(Partida partida) : this()
        {
            this.partida = partida;
        }

        private void frmPartida_Load(object sender, EventArgs e)
        {
            if (partida == null)
                return; // abierto desde el diseñador

            dados = new UC_DADO[] { uC_DADO1, uC_DADO2, uC_DADO3, uC_DADO4, uC_DADO5 };
            foreach (UC_DADO d in dados)
            {
                d.Click += Dado_Click;
            }

            Text = "Partida: " + partida.Jugador1.UserName + " vs " + partida.Jugador2.UserName;
            colJugador1.HeaderText = partida.Jugador1.UserName;
            colJugador2.HeaderText = partida.Jugador2.UserName;

            CargarFilas();
            turno = gestorPartida.TurnoActual(partida);
            Refrescar();
        }

        // ---------- Planilla ----------

        private void CargarFilas()
        {
            dgvPlanilla.Rows.Clear();
            foreach (Categoria c in partida.Jugador1.Planilla.Categorias)
            {
                dgvPlanilla.Rows.Add(NombreCategoria(c), "", "");
            }

            int total = dgvPlanilla.Rows.Add("TOTAL", "0", "0");
            DataGridViewRow filaTotal = dgvPlanilla.Rows[total];
            filaTotal.DefaultCellStyle.BackColor = ColorFondoTotal;
            filaTotal.DefaultCellStyle.SelectionBackColor = ColorFondoTotal;
            filaTotal.DefaultCellStyle.SelectionForeColor = ColorTexto;
            filaTotal.DefaultCellStyle.Font = FuenteTotal;
        }

        public static string NombreCategoria(Categoria c)
        {
            if (c is Numero)
                return "Al " + ((Numero)c).Valor;
            if (c.Nombre == "Poker")
                return "Póker";
            return c.Nombre;
        }

        private void Refrescar()
        {
            bool enJuego = turno != null;
            bool turnoJugador1 = enJuego && turno.Usuario == partida.Jugador1;
            bool turnoJugador2 = enJuego && turno.Usuario == partida.Jugador2;

            ActualizarColumna(colJugador1.Index, partida.Jugador1, turnoJugador1);
            ActualizarColumna(colJugador2.Index, partida.Jugador2, turnoJugador2);

            if (!enJuego)
            {
                foreach (UC_DADO d in dados)
                {
                    d.Enabled = false;
                }
                btnTirar.Enabled = false;
                btnAnotar.Enabled = false;
                return;
            }

            bool puedeTirar = gestorTurno.SePuede(turno);

            lblTurno.Text = "Turno de " + turno.Usuario.UserName;
            lblInfo.Text = "Ronda " + partida.Rondas.Count + " de " + CantidadCategorias
                + "   ·   Tirada " + turno.Numero + " de 3";

            for (int i = 0; i < dados.Length; i++)
            {
                dados[i].Numero = turno.Dados[i].Valor;
                dados[i].Enabled = puedeTirar && turno.Numero > 0;
                if (!dados[i].Enabled)
                    dados[i].Retenido = false;
            }

            if (turno.Numero == 0)
                btnTirar.Text = "Tirar dados";
            else if (puedeTirar)
                btnTirar.Text = "Volver a tirar (" + (3 - turno.Numero) + " restantes)";
            else
                btnTirar.Text = "Sin tiradas: elegí dónde anotar";

            btnTirar.Enabled = puedeTirar;
            btnAnotar.Enabled = turno.Numero > 0;

            // Si la fila seleccionada ya está anotada, paso a la primera libre
            SeleccionarPrimeraLibre();
        }

        private void ActualizarColumna(int columna, Usuario jugador, bool esSuTurno)
        {
            List<Categoria> categorias = jugador.Planilla.Categorias;

            for (int i = 0; i < categorias.Count; i++)
            {
                Categoria c = categorias[i];
                DataGridViewCell celda = dgvPlanilla.Rows[i].Cells[columna];

                celda.Style.BackColor = esSuTurno ? ColorFondoTurno : Color.White;

                if (c.Marcada)
                {
                    celda.Value = c.Puntos == 0 ? "X" : c.Puntos.ToString();
                    celda.Style.ForeColor = c.Puntos == 0 ? ColorTachado : ColorTexto;
                    celda.Style.Font = FuenteAnotada;
                }
                else if (esSuTurno && turno.Numero > 0)
                {
                    // vista previa de lo que sumaría anotando ahí
                    celda.Value = "+" + gestorPlanilla.PuntosPosibles(c, turno.Dados);
                    celda.Style.ForeColor = ColorPosible;
                    celda.Style.Font = FuentePosible;
                }
                else
                {
                    celda.Value = "";
                }
            }

            dgvPlanilla.Rows[FilaTotal].Cells[columna].Value = gestorPlanilla.PuntajeTotal(jugador.Planilla).ToString();

            DataGridViewColumn col = dgvPlanilla.Columns[columna];
            col.HeaderCell.Style.BackColor = esSuTurno ? ColorTurno : ColorEncabezado;
            col.HeaderCell.Style.ForeColor = esSuTurno ? ColorTexto : Color.White;
            col.HeaderCell.Style.SelectionBackColor = col.HeaderCell.Style.BackColor;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SeleccionarPrimeraLibre()
        {
            List<Categoria> categorias = turno.Usuario.Planilla.Categorias;
            DataGridViewRow actual = dgvPlanilla.CurrentRow;

            if (actual != null && actual.Index < categorias.Count && !categorias[actual.Index].Marcada)
                return;

            for (int i = 0; i < categorias.Count; i++)
            {
                if (!categorias[i].Marcada)
                {
                    dgvPlanilla.CurrentCell = dgvPlanilla.Rows[i].Cells[0];
                    return;
                }
            }
        }

        // ---------- Dados ----------

        private void Dado_Click(object sender, EventArgs e)
        {
            if (turno == null || turno.Numero == 0 || !gestorTurno.SePuede(turno))
                return;

            UC_DADO dado = (UC_DADO)sender;
            dado.Retenido = !dado.Retenido;
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            if (turno == null || !gestorTurno.SePuede(turno))
                return;

            List<int> indices = null; // null = se tiran todos (primera tirada)

            if (turno.Numero > 0)
            {
                indices = new List<int>();
                for (int i = 0; i < dados.Length; i++)
                {
                    if (!dados[i].Retenido)
                        indices.Add(i);
                }

                if (indices.Count == 0)
                {
                    MessageBox.Show("Retuviste los 5 dados. Soltá alguno para volver a tirar o anotá el resultado.",
                        "Generala", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            gestorTurno.Tirar(turno, indices);
            Refrescar();
        }

        // ---------- Anotar ----------

        private void btnAnotar_Click(object sender, EventArgs e)
        {
            if (dgvPlanilla.CurrentRow == null)
            {
                MessageBox.Show("Elegí una categoría de la planilla.", "Generala", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Anotar(dgvPlanilla.CurrentRow.Index);
        }

        private void dgvPlanilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                Anotar(e.RowIndex);
        }

        private void Anotar(int fila)
        {
            if (turno == null)
                return;

            if (turno.Numero == 0)
            {
                MessageBox.Show("Primero tirá los dados.", "Generala", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (fila < 0 || fila >= FilaTotal)
            {
                MessageBox.Show("Elegí una categoría de la planilla.", "Generala", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Categoria categoria = turno.Usuario.Planilla.Categorias[fila];

            if (categoria.Marcada)
            {
                MessageBox.Show("Ya anotaste en " + NombreCategoria(categoria) + ". Elegí otra categoría.",
                    "Generala", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int puntos = gestorPlanilla.PuntosPosibles(categoria, turno.Dados);
            if (puntos == 0)
            {
                DialogResult r = MessageBox.Show("Con estos dados " + NombreCategoria(categoria) + " vale 0 puntos.\n¿Querés tacharla?",
                    "Tachar categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.Yes)
                    return;
            }

            if (gestorTurno.Anotar(turno, categoria))
            {
                SiguienteTurno();
            }
        }

        private void SiguienteTurno()
        {
            foreach (UC_DADO d in dados)
            {
                d.Retenido = false;
            }

            turno = gestorPartida.TurnoActual(partida);

            if (turno == null)
                Finalizar();
            else
                Refrescar();
        }

        private void Finalizar()
        {
            terminada = true;
            Refrescar();

            try
            {
                gestorPartida.TerminarPartida(partida);
            }
            catch (Exception ex)
            {
                MessageBox.Show("La partida terminó pero no se pudo guardar.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int puntos1 = gestorPlanilla.PuntajeTotal(partida.Jugador1.Planilla);
            int puntos2 = gestorPlanilla.PuntajeTotal(partida.Jugador2.Planilla);
            string marcador = partida.Jugador1.UserName + " " + puntos1 + "  -  " + puntos2 + " " + partida.Jugador2.UserName;

            string resultado = partida.Ganador == null
                ? "¡Empate!"
                : "¡Ganó " + partida.Ganador.UserName + "!";

            lblTurno.Text = resultado;
            lblInfo.Text = "Partida terminada   ·   " + marcador;
            btnTirar.Text = "Partida terminada";

            MessageBox.Show(resultado + "\n\n" + marcador, "Fin de la partida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmPartida_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (terminada || partida == null || e.CloseReason != CloseReason.UserClosing)
                return;

            DialogResult r = MessageBox.Show("La partida todavía no terminó y no se va a guardar.\n¿Querés abandonarla?",
                "Abandonar partida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                gestorBitacora.Registrar(partida.Jugador1, "Partida abandonada");
                gestorBitacora.Registrar(partida.Jugador2, "Partida abandonada");
            }
            catch (Exception)
            {
                // si falla la bitácora igual se cierra la partida
            }
        }
    }
}
