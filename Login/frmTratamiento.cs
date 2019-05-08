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
using System.Drawing.Drawing2D;

namespace Login
{
    public partial class frmTratamiento : Form
    {
        private Tratamiento_Negocio Model { get; set; }
        public static Tratamiento BuscarCita = new Tratamiento();
        public frmTratamiento()
        {
            InitializeComponent();
            //redondear(btnEliminar);
            redondear(btnNuevaCita);
            redondear(btnConsultarCita);
            redondear(btnEliminarCita);
            redondear(pnlGrid);
            Model = new Tratamiento_Negocio(Comun.Conexion);
            llenarForm();

        }
        #region diseño
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
#endregion
        public void llenarForm()
        {
            try
            {
                Model.LlenarListaTratamiento();
                dgvPaciente.AutoGenerateColumns = false;
                dgvPaciente.DataSource = Model.ListaTratamiento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            frmNuevoTratamiento t = new frmNuevoTratamiento();
            t.ShowDialog();
            t.Dispose();
            llenarForm();
        }

        private void btnConsultarCita_Click(object sender, EventArgs e)
        {
            Tratamiento t = new Tratamiento();
            t = ObtenerDatos();
            frmNuevoTratamiento liberar = new frmNuevoTratamiento(t);
            liberar.ShowDialog();
            liberar.Dispose();
            llenarForm();
        }

        private Tratamiento ObtenerDatos()
        {
            try
            {
                Tratamiento tratamiento = new Tratamiento();
                foreach (DataGridViewRow row in this.ObtenerFilaSeleccionada())
                {
                    tratamiento.IDTratamiento = Convert.ToInt32(row.Cells["IDTratamiento"].Value.ToString());
                    tratamiento.Nombre = row.Cells["Nombre"].Value.ToString();
                }
                return tratamiento;
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

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            Tratamiento t = new Tratamiento();
            t = ObtenerDatos();
            frmEliminarPaciente liberar = new frmEliminarPaciente(t);
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
