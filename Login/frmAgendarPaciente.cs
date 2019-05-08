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
    public partial class frmAgendarPaciente : Form
    {

        private Paciente_Negocio Model { get; set; }
        public frmAgendarPaciente()
        {
            InitializeComponent();
            redondear(btnAtras);
            redondear(btnEliminar);
            redondear(btnGenerar);
            redondear(btnLiberar);
            redondear(btnModificar);
            redondear(pnlGrid);
            Model = new Paciente_Negocio(Comun.Conexion);
            llenarForm();

        }
        public void llenarForm()
        {
            try
            {
                Model.LlenarLista();
                dgvPaciente.AutoGenerateColumns = false;
                dgvPaciente.DataSource = Model.ListaPaciente;
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            frmPacientes p = new frmPacientes();
            p.ShowDialog();
            p.Dispose();
            llenarForm();
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente = ObtenerDatos();
            frmLiberarPaciente liberar = new frmLiberarPaciente(paciente);
            liberar.ShowDialog();
            liberar.Dispose();
            llenarForm();
        }
        private Paciente ObtenerDatos()
        {
            try
            {
                Paciente paciente = new Paciente();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    paciente.IDPaciente = Convert.ToInt32(row.Cells["IDPaciente"].Value.ToString());
                    paciente.Nombre = row.Cells["Nombre"].Value.ToString();
                }
                return paciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private List<DataGridViewRow> ObtenerFilaSeleccionada()
        {
            try
            {
                List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dgvPaciente.Rows)
                {
                    if (row.Selected)
                    {
                        rowSelected.Add(row);
                    }
                }
                return rowSelected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente = ObtenerDatos();
            frmPacientes liberar = new frmPacientes(paciente);
            liberar.ShowDialog();
            liberar.Dispose();
            llenarForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente = ObtenerDatos();
            frmEliminarPaciente liberar = new frmEliminarPaciente(paciente);
            liberar.ShowDialog();
            liberar.Dispose();
            llenarForm();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
