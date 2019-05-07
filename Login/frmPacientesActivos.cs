using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nutriologa_Global;
using Nutriologa_Negocio;

namespace Login
{
    public partial class frmPacientesActivos : Form
    {
        private  Tratamiento_Negocio Model { get; set; }
        public frmPacientesActivos()
        {
            InitializeComponent();
            Model = new Tratamiento_Negocio(Comun.Conexion);
            llenarForm();
        }

        private void dgvReportePeriodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenarForm()
        {
            try
            {
                Model.LlenarReportePacientesActivos();
                dgvReportePeriodo.AutoGenerateColumns = false;
                dgvReportePeriodo.DataSource = Model.ListaReporteTratamiento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarForm();
        }
    }
}
