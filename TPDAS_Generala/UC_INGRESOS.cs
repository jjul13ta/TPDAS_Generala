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


        public bool Validar()
        {
            bool ok = requerido;


            if(ok && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.BackColor = Color.Red;
                ok = false;
            }
            else
            {
                textBox1.BackColor = Color.White;
                ok = true;
            }
            return ok;
        }
    }
}
