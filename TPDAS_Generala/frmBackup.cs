using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace TPDAS_Generala
{
    public partial class frmBackup : Form
    {
        private BLL_Backup gestorBackup = new BLL_Backup();

        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Filter = "Backup de SQL Server (*.bak)|*.bak|Todos los archivos (*.*)|*.*";
                dialogo.FileName = "GENERALA_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".bak";
                dialogo.OverwritePrompt = false; // también se usa para elegir un backup existente a restaurar

                if (dialogo.ShowDialog(this) == DialogResult.OK)
                {
                    txtRuta.Text = dialogo.FileName;
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Ejecutar(true);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Se van a reemplazar todos los datos actuales por los del backup.\n¿Continuar?",
                "Restaurar backup", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
                Ejecutar(false);
        }

        private void Ejecutar(bool esBackup)
        {
            lblEstado.Text = "";
            Cursor = Cursors.WaitCursor;

            try
            {
                bool ok = esBackup ? gestorBackup.Backup(txtRuta.Text) : gestorBackup.Restore(txtRuta.Text);

                if (!ok)
                {
                    MessageBox.Show("Indicá la ruta del archivo.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                lblEstado.ForeColor = Color.FromArgb(46, 125, 50);
                lblEstado.Text = esBackup ? "Backup realizado correctamente." : "Base de datos restaurada correctamente.";
            }
            catch (Exception ex)
            {
                lblEstado.ForeColor = Color.FromArgb(198, 40, 40);
                lblEstado.Text = esBackup ? "No se pudo hacer el backup." : "No se pudo restaurar.";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
