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
    public partial class frmEliminarPaciente : Form
    {
        Paciente p = new Paciente();
        Tratamiento t = new Tratamiento();
        Cita c = new Cita();
        public int tipo ;
        public frmEliminarPaciente(Paciente paciente)
        {
            InitializeComponent();
            redondear();
            redondear(btnSI);
            redondear(btnNO);
            p = paciente;
            label1.Text = "¿Estas seguro de eliminar al paciente " + paciente.Nombre + " ?";
            tipo = 1;
        }
        public frmEliminarPaciente(Tratamiento Tratamiento)
        {
            InitializeComponent();
            redondear();
            redondear(btnSI);
            redondear(btnNO);
            t = Tratamiento;
            label1.Text = "¿Estas seguro de eliminar el tratamiento " + Tratamiento.Nombre + " ?";
            tipo = 2;
        }
        public frmEliminarPaciente(Cita cita)
        {
            InitializeComponent();
            redondear();
            redondear(btnSI);
            redondear(btnNO);
            c = cita;
            label1.Text = "¿Estas seguro de eliminar la cita de " + cita.Nombre + " ?";
            tipo = 3;
        }
        #region diseño
        public void redondear(Button btn)
        {
            Rectangle r = new Rectangle(0, 0, btn.Width, btn.Height);
            GraphicsPath gp = new GraphicsPath();
            int d = 10;
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
        #endregion
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipo == 1)
                {
                    int verificar = 0;
                    Paciente_Negocio paciente = new Paciente_Negocio(Comun.Conexion);
                    paciente.EliminarPaciente(p, ref verificar);
                    if (verificar == 1)
                    {
                        this.Close();
                    }
                }
                else
                if(tipo == 2)
                {
                    Tratamiento_Negocio Negocio = new Tratamiento_Negocio(Comun.Conexion);
                    Negocio.EliminarTratamiento(t);
                    Close();
                }
                else 
                if(tipo == 3)
                {
                    Cita_Negocio negocio = new Cita_Negocio(Comun.Conexion);
                    negocio.EliminarTratamiento(c);
                    Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}