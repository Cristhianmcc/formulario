using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario.vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                string username = txtUsuario.Text;
                string password = txtPassword.Text;

                UserControlador controlador = new UserControlador();
                controlador.login(username, password);

                if (controlador.login(username,password))
                {
                    MessageBox.Show("Bienvenido");

                    Form1 formulario = new Form1();
                    formulario.Show();
                    this.Hide
                        ();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }   


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
