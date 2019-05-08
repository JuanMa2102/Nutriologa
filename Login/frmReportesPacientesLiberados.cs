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
    public partial class frmReportesPacientesLiberados : Form
    {
        private Tratamiento_Negocio Model { get; set; }
        public frmReportesPacientesLiberados()
        {
            InitializeComponent();
            Model = new Tratamiento_Negocio(Comun.Conexion);
            llenarForm();
        }
        public void llenarForm()
        {
            try
            {
                Model.LlenarReportePacientesLiberados();
                dgvLiberado.AutoGenerateColumns = false;
                dgvLiberado.DataSource = Model.ListaReporteTratamiento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    
}
