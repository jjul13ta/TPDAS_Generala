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
    public partial class frmBitacora : Form
    {
        private const string Todos = "(Todos)";

        private BLL_Bitacora gestorBitacora = new BLL_Bitacora();
        private List<Bitacora> registros = new List<Bitacora>();

        public frmBitacora()
        {
            InitializeComponent();
            dgvBitacora.AutoGenerateColumns = false;
            colFecha.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            try
            {
                registros = gestorBitacora.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo leer la bitácora.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registros = new List<Bitacora>();
            }

            string seleccionado = cmbUsuario.SelectedItem as string;

            List<string> usuarios = new List<string>();
            usuarios.Add(Todos);
            usuarios.AddRange(registros.Select(b => b.Usuario.UserName).Distinct().OrderBy(n => n));

            cmbUsuario.SelectedIndexChanged -= cmbUsuario_SelectedIndexChanged;
            cmbUsuario.DataSource = usuarios;
            cmbUsuario.SelectedItem = usuarios.Contains(seleccionado) ? seleccionado : Todos;
            cmbUsuario.SelectedIndexChanged += cmbUsuario_SelectedIndexChanged;

            Mostrar();
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            string usuario = cmbUsuario.SelectedItem as string;

            var filas = registros
                .Where(b => usuario == null || usuario == Todos || b.Usuario.UserName == usuario)
                .Select(b => new { b.Fecha, Usuario = b.Usuario.UserName, b.Evento })
                .ToList();

            dgvBitacora.DataSource = filas;
            lblCantidad.Text = filas.Count + (filas.Count == 1 ? " registro" : " registros");
        }
    }
}
