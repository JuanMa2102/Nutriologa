using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Nutriologa_Negocio;
using Nutriologa_Global;
     

namespace Login
{
    public partial class frmLogin : Form
        
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            try
            {
                if(txtUser.Text == "USUARIO")
                {
                    txtUser.Text = "";
                    txtUser.ForeColor = Color.LightGray;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "")
                {
                    txtUser.Text = "USUARIO";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            
        }

        public void login()
        {
            try
            {
                int verificar = 0;
                LoginNutriologa lg = new LoginNutriologa();
                lg.usuario = txtUser.Text;
                lg.pass = txtPass.Text;
                Login_Negocio Ln = new Login_Negocio();
                Ln.ingresar(lg, ref verificar);
                if (verificar == 1)
                {
                    lblUser.Visible = false;
                    lblPass.Visible = false;
                    this.Visible = false;
                    frmPrincipal home = new frmPrincipal();
                    home.ShowDialog();
                    if (home.salir)
                    {
                        //home.Dispose();
                        this.Close();
                    }
                    else
                    {
                        home.Dispose();  
                    }
                }
                else
                if(verificar == 0)
                {
                    lblUser.Visible = true;
                    lblUser.Text = "No existe el usuario";
                    lblPass.Visible = false;
                    txtUser.Focus();
                }
                else
                if (verificar == 2)
                {
                    lblPass.Text = "Contraseña incorrecta";
                    lblUser.Visible = false;
                    lblPass.Visible = true;
                    txtPass.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public bool ValidarCampos()
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Focus();
                lblUser.Text = "Ingrese un usuario";
                lblUser.Visible = true;
                lblPass.Visible = false;
                return false;
            }
            else
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Focus();
                lblPass.Text = "Ingrese una Contraseña";
                lblUser.Visible = false;
                lblPass.Visible = true;
                return false;
            }
            else
                return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                    login();
            }
            catch
            {

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_Enter_1(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text == "CONTRASEÑA")
                {
                    txtPass.Text = "";
                    txtPass.UseSystemPasswordChar = true;
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void txtPass_Leave_1(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text == "")
                {
                    txtPass.UseSystemPasswordChar = false;
                    txtPass.Text = "CONTRASEÑA";
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
