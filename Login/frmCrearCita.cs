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
        int fecha;
        int horario;
        int numtel;
        public bool salir = false;
        public frmCrearCita()
        {
            InitializeComponent();
            redondear(btnGuardar);
            redondear(btnrestablecer);
            redondear();
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
                int verificar = 0;
                Cita c = new Cita();
                c.idcita = 1;
                c.fecha = fecha; 
                c.horario = 14;
                c.idpaciente = 1;
                Cita_Negocio cita = new Cita_Negocio();
                cita.CrearCita(c, ref verificar);
                if (verificar == 1)
                {

                    frmAgendarCita fp = new frmAgendarCita();
                    fp.ShowDialog();
                    fp.Dispose();
                    this.Close();
                }
                else
                {
                    frmCrearCita fc = new frmCrearCita();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
           numtel = Convert.ToInt32(txtNum.Text);
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
          fecha = Convert.ToInt32(txtFecha.Text);
        }

        private void txtHorario_TextChanged(object sender, EventArgs e)
        {
            horario = Convert.ToInt32(txtHorario.Text);
        }
    }
}
