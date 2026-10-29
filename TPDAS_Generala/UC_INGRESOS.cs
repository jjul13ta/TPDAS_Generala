using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPDAS_Generala
{
    public partial class UC_INGRESOS : UserControl
    {
        private static readonly Color ColorError = Color.FromArgb(255, 205, 210);

        public UC_INGRESOS()
        {
            InitializeComponent();
        }

        private void UC_INGRESOS_Load(object sender, EventArgs e)
        {

        }

        public string Texto
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string Etiqueta
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        private bool requerido;

        public bool Requerido
        {
            get { return requerido; }
            set { requerido = value; }
        }

        // Oculta el texto ingresado (para contraseñas)
        public bool EsPassword
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        public bool Validar()
        {
            bool ok = true;

            if (requerido && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.BackColor = ColorError;
                ok = false;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }
            return ok;
        }

        public void Limpiar()
        {
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
        }

        public void Enfocar()
        {
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Al escribir se quita la marca de error
            if (textBox1.BackColor != Color.White && textBox1.Text.Trim() != "")
            {
                textBox1.BackColor = Color.White;
            }
        }
    }
}
