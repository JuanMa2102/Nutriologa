using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nutriologa_Negocio;
using Nutriologa_Global;

namespace Login
{
    public partial class frmAgendarCita : Form
    {
        private Cita_Negocio Model { get; set; }
        public static Cita BuscarCita = new Cita();
        public frmAgendarCita()
        {
            InitializeComponent();
            //redondear(btnEliminar);
            redondear(btnNuevaCita);
            redondear(btnConsultarCita);
            redondear(btnEliminarCita);
            redondear(pnlGrid);
            Model = new Cita_Negocio(Comun.Conexion);
            llenarForm();

        }
        //public frmAgendarCita(Cita cita)
        //{
        //    InitializeComponent();
        //    //redondear(btnEliminar);
        //    redondear(btnNuevaCita);
        //    redondear(btnConsultarCita);
        //    redondear(btnEliminarCita);
        //    redondear(pnlGrid);
        //    Model = new Cita_Negocio(Comun.Conexion);
        //    this.BuscarCita = cita;
        //    recargar();
        //}
        public void llenarForm()
        {
            try
            {
                Model.LlenarListaCita();
                dgvPaciente.AutoGenerateColumns = false;
                dgvPaciente.DataSource = Model.ListaCita;
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
                dgvPaciente.AutoGenerateColumns = false;
                dgvPaciente.DataSource = Model.ListaCita;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void redondear(Button btn)
        {
            Rectangle r = new Rectangle(0, 0, btn.Width, btn.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 30;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            btn.Region = new Region(gp);
        }
        public void redondear(Panel btn)
        {
            Rectangle r = new Rectangle(0, 0, btn.Width, btn.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 30;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            btn.Region = new Region(gp);
        }
        public void redondear(PictureBox btn)
        {
            Rectangle r = new Rectangle(0, 0, btn.Width, btn.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 30;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            btn.Region = new Region(gp);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            frmCrearCita cita = new frmCrearCita();
            cita.ShowDialog();
            cita.Dispose();
            this.llenarForm();
        }

        private void btnConsultarCita_Click(object sender, EventArgs e)
        {
            frmConsultarCita cita = new frmConsultarCita();
            cita.ShowDialog();
            cita.Dispose();
            this.recargar();
        }
    }
}
