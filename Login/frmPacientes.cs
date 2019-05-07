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
        private Validaciones Val;
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
        public bool ValidarCampo()
        {
            if(txtNombre.Text.Length == 0)
            {
                txtNombre.Focus();
                return false;
            }
            else
            if(txtApellido.Text.Length == 0)
            {
                txtApellido.Focus();
                return false;
            }
            else
            if (txtTelefono.Text.Length == 0)
            {
                txtTelefono.Focus();
                return false;
            }
            else
            if (txtEstatura.Text.Length == 0)
            {
                txtEstatura.Focus();
                return false;
            }
            else
            if (txtEdad.Text.Length == 0)
            {
                txtEdad.Focus();
                return false;
            }
            else
            if (txtTalla.Text.Length == 0)
            {
                txtTalla.Focus();
                return false;
            }
            else
            if (txtPeso.Text.Length == 0)
            {
                txtPeso.Focus();
                return false;
            }
            else
            if (txtGrasa.Text.Length == 0)
            {
                txtGrasa.Focus();
                return false;
            }
            else
            if (txtColesterol.Text.Length == 0)
            {
                txtColesterol.Focus();
                return false;
            }
            else
            if (txtAcido.Text.Length == 0)
            {
                txtAcido.Focus();
                return false;
            }
            else
            if (txtTrigliserido.Text.Length == 0)
            {
                txtTrigliserido.Focus();
                return false;
            }
            return true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampo())
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
                    paciente.PromGrasa = Convert.ToDecimal(txtGrasa.Text);
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
                else
                MessageBox.Show("Campos Incompletos", "Sistema Nutriologa DS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Nutriologa DS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Nutriologa DS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Nutriologa DS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.NumeroTelefono(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Nutriologa DS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloDecimal(e);
            }
            catch (Exception ex)
            {
                txtEstatura.Focus();
                MessageBox.Show(ex.Message.ToString(), "Sistema Nutriologa DS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloNumerico(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Nutriologa DS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloDecimal(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Nutriologa DS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloDecimal(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Nutriologa DS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGrasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloDecimal(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Nutriologa DS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtColesterol_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloDecimal(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Nutriologa DS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAcido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloDecimal(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Nutriologa DS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTrigliserido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloDecimal(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistema Nutriologa DS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
