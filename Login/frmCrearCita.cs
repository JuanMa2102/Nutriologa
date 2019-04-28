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
using Nutriologa_Global;
using Nutriologa_Negocio;

namespace Login
{
    public partial class frmCrearCita : Form
    {
        Cita_Negocio Model { get; set; }
        public bool salir = false;
        public frmCrearCita()
        {
            InitializeComponent();
            redondear(btnGuardar);
            redondear(btnrestablecer);
            redondear();
            Model = new Cita_Negocio(Comun.Conexion);
            llenarCombo();
        }

        public void llenarCombo()
        {
            cmbHorario.DataSource = Model.ListaHorario;
            cmbHorario.DisplayMember = "Horario";
            cmbHorario.ValueMember = "IDHorario";

            cmbPaciente.DataSource = Model.ListaPaciente;
            cmbPaciente.DisplayMember = "Nombre";
            cmbPaciente.ValueMember = "IDNombre";
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
        public void redondear(TextBox btn)
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
        public void redondear()
        {
            Rectangle r = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 30;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            this.Region = new Region(gp);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            salir = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int verificar = 1;
                Cita c = new Cita();
                c.IDNombre = Convert.ToInt32(this.cmbPaciente.SelectedValue.ToString());
                c.Fecha = dtmFecha.Value;
                c.IDHorario = Convert.ToInt32(this.cmbHorario.SelectedValue.ToString());
                Model.CrearCita(c, ref verificar);
                if (verificar == 1)
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
