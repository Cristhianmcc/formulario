using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form1 : Form

    {
        MySqlConnection connection;

        private int id_selected = -1;

        public Form1()
        {
            InitializeComponent();
            String connectionString = "Server=localhost;" +
                "Database= usuario;" +
                "User ID = root;" +
                " Password = ;" +
                " SslMode = ; ";
            connection = new MySqlConnection(connectionString);
            ListarTodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           


        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarTodo()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("USUARIO");
            dt.Columns.Add("CONTRASEÑA");
            dt.Columns.Add("CORREO");
            


            string query = "SELECT * FROM users";
            MySqlCommand cmd = new MySqlCommand(query, this.connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string username = reader.GetString("username");
                    string password = reader.GetString("password");
                    string email = reader.GetString("email");

                    dt.Rows.Add(id, username, password, email);

                    

                }
            }
            catch (Exception ex)
            {
                lbl_mensaje.Text += "Error en Lista: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }

            datagrid.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crearUsuario();
            ListarTodo();
        }

        private void crearUsuario()
        {
            string query = "INSERT INTO users (username,password,email)" +
                " VALUES (@username,@password,@email)";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                cmd.Parameters.AddWithValue("@password", txt_pass.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                lbl_mensaje.Text += "Registro insertado correctamente";
            }
            catch (Exception ex) {
                lbl_mensaje.Text += "Error en registro: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            crearUsuario();
            ListarTodo();
        }
    }
}
        
    

