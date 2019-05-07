using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            frmCitasporPeriodo fl = new frmCitasporPeriodo();
            this.Visible = false;
            fl.ShowDialog();
            fl.Dispose();
        
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            frmReportesPacientesLiberados rpl = new frmReportesPacientesLiberados();
            this.Visible = false;
            rpl.ShowDialog();
            rpl.Dispose();
        }
    }
}
