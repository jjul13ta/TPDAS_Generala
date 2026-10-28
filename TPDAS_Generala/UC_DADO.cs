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
    public partial class UC_DADO : UserControl
    {
        public UC_DADO()
        {
            InitializeComponent();
        }

        private void UC_DADO_Load(object sender, EventArgs e)
        {

        }

        public int Numero
        {
            get { return int.TryParse(button1.Text, out int n) ? n : 0; }
            set { button1.Text = value.ToString(); }
        }


        
    }
}
