using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nutriologa_Negocio;
using Nutriologa_Global;
using System.Drawing.Drawing2D;

namespace Login
{
    public partial class frmNuevoTratamiento : Form
    {
        private Tratamiento_Negocio Model { get; set; }
        public int id_tratamiento = 0 ;
        Tratamiento tratamiento = new Tratamiento();
        public bool salir = false;
        public frmNuevoTratamiento()
        {
            InitializeComponent();
            redondear(btnGuardar);
            Model = new Tratamiento_Negocio(Comun.Conexion);
        }

        public frmNuevoTratamiento(Tratamiento t)
        {
            id_tratamiento = t.IDTratamiento;
            tratamiento = t;
            InitializeComponent();
            redondear(btnGuardar);
            Model = new Tratamiento_Negocio(Comun.Conexion);
            llenar();
        }

        public void llenar()
        {
            tratamiento = Model.ModificarTratamiento(tratamiento);
            txtNombre.Text = tratamiento.Nombre;
            txtDescripcion.Text = tratamiento.Descripcion;
        }

        #region redondera
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

        
        #endregion
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Tratamiento t = new Tratamiento();
            t.IDTratamiento = id_tratamiento;
            t.Nombre = txtNombre.Text;
            t.Descripcion = txtDescripcion.Text;
            if (id_tratamiento != 0)
            {
                Model.GuardarTratamientoModificado(t);
                this.Close();
            }
            else
            {
                Model.GuardarTratamiento(t);
                Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
