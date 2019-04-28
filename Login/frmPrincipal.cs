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

namespace Login
{
    public partial class frmPrincipal : Form
    {
        public bool salir = false;
        public frmPrincipal()
        {
            InitializeComponent();
            redondear(btnPaciente);
            redondear(panelNav);
            redondear(btnCita);
            redondear(btnCerrar);
            redondear(btnConsultar);
            redondear(btnLiberar);
            redondear(btnGenerar);
            // redondear(pictureBox1);
            redondear(btnAtras);
            redondear(imageUsuario);
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


        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            frmAgendarPaciente paciente = new frmAgendarPaciente();

            paciente.ShowDialog();
            paciente.Dispose();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            salir = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
            fl.Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarCita fl = new frmConsultarCita();
            this.Visible = false;
            fl.ShowDialog();
            fl.Dispose();
            if (fl.salir)
            {
                this.Visible = true;
            }
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            frmAgendarCita cita = new frmAgendarCita();

            cita.ShowDialog();
            cita.Dispose();
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            frmPacientes fl = new frmPacientes();
            this.Visible = false;
            fl.ShowDialog();
            fl.Dispose();
            if (fl.salir)
            {
                this.Visible = true;
            }
        }
    }
}
