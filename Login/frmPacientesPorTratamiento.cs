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
    public partial class frmPacientesPorTratamiento : Form
    {
        private Paciente_Negocio Model { get; set; }
        public frmPacientesPorTratamiento()
        {
            InitializeComponent();
            Model = new Paciente_Negocio(Comun.Conexion);
            llenarForm();
        }
        public void llenarForm()
        {
            try
            {
            Model.LlenarListaPacienteTratamiento();
            dgvPacientesTratamiento.AutoGenerateColumns = false;
            dgvPacientesTratamiento.DataSource = Model.ListaReporteTratamiento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
   
}
