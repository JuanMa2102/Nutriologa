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
    public partial class frmPacientes : Form
    {
        public bool EsModificar = false;
        Paciente_Negocio Model { get; set; }
        Paciente paciente = new Paciente();
        public int id_paciente;
        public bool salir = false;
        public frmPacientes()
        {
            InitializeComponent();
            redondear(btnsave);
            redondear(btnAtras);
            redondear(btnres);
            redondear();
            Model = new Paciente_Negocio(Comun.Conexion);
        }
        public frmPacientes(Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
            id_paciente = paciente.IDPaciente;
            EsModificar = true;
            redondear(btnsave);
            redondear(btnAtras);
            redondear(btnres);
            redondear();
            Model = new Paciente_Negocio(Comun.Conexion);
            llenar();
        }
        public void llenar()
        {
            paciente = Model.ModificarPaciente(paciente);
            txtNombre.Text = paciente.Nombre;
            txtApellido.Text = paciente.Apellido;
            txtEdad.Text = paciente.Edad.ToString();
            txtTelefono.Text = paciente.Telefono.ToString();
            txtEstatura.Text = paciente.Estatura.ToString();
            txtEdad.Text = paciente.Edad.ToString();
            txtTalla.Text = paciente.Talla.ToString();
            txtPeso.Text = paciente.Peso.ToString();
            txtGrasa.Text = paciente.PromGrasa.ToString();
            txtColesterol.Text = paciente.NivColesterol.ToString();
            txtAcido.Text = paciente.NivAcidoUrico.ToString();
            txtTrigliserido.Text = paciente.NivTrigliceridos.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                salir = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int verificar = 0;
            Paciente paciente = new Paciente();
            paciente.IDPaciente = id_paciente;
            paciente.Nombre = txtNombre.Text;
            paciente.Apellido = txtApellido.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.Estatura = Convert.ToDecimal( txtEstatura.Text);
            paciente.Edad = Convert.ToInt32(txtEdad.Text);
            paciente.Talla = Convert.ToDecimal(txtTalla.Text);
            paciente.Peso = Convert.ToDecimal(txtPeso.Text);
            paciente.PromGrasa = Convert.ToDecimal(txtPeso.Text);
            paciente.NivColesterol = Convert.ToDecimal(txtColesterol.Text);
            paciente.NivAcidoUrico = Convert.ToDecimal(txtAcido.Text);
            paciente.NivTrigliceridos = Convert.ToDecimal(txtTrigliserido.Text);
            if (EsModificar)
            {
                Model.GuardarPacienteModificado(paciente);
                this.Close();
            }
            else
            {
                Model.GuardarPaciente(paciente, ref verificar);
                if (verificar == 1)
                    this.Close();
            }
        }
    }
}
