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
    public partial class frmCitasporPeriodo : Form
    {
        private Cita_Negocio Model { get; set; }
        public static Cita BuscarCita = new Cita();
        Cita cita = new Cita();
        public frmCitasporPeriodo()
        {
      
            InitializeComponent();
            Model = new Cita_Negocio(Comun.Conexion);
            
        }
        public void llenarForm()
        {
            try
            {
                Model.LlenarListaReporteCitaPeriodo(cita);
                dgvReportePeriodo.AutoGenerateColumns = false;
                dgvReportePeriodo.DataSource = Model.ListaReportePeriodo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void recargar()
        {
            try
            {
                Model.LlenarListaCitaBusqueda(BuscarCita);
                dgvReportePeriodo.AutoGenerateColumns = false;
                dgvReportePeriodo.DataSource = Model.ListaCita;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      

        private void dtmFecha_ValueChanged(object sender, EventArgs e)
        {
 
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarDatos();
            llenarForm();
           


        }
        public void IngresarDatos()
        {
            cita.Fechain = dtmFechaIn.Value;
            cita.Fechafi = dtmFechaFi.Value;
        }

        private void dgvReportePeriodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCitasporPeriodo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
