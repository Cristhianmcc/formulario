﻿using formulario.entidad;
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
        private UserControlador control;
        //MySqlConnection connection;

        private int id_selected = -1;

        public Form1()
        {
            InitializeComponent();
            /* String connectionString = "Server=localhost;" +
                 "Database= test_csharp;" +
                 "User ID = root;" +
                 " Password = Lurin@2024;" +
                 " SslMode = ;";
             connection = new MySqlConnection(connectionString);*/
            control = new UserControlador();
            ListarTodo();
            limpiarCasillas();
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
            

           
            //MySqlCommand cmd = new MySqlCommand(query, this.connection);

            try
            {
                List<EUser> lista = control.GetAll();
                foreach (EUser user in lista)
                {
                    dt.Rows.Add(user.Id, user.Username, user.Password, user.Email);
                }
                //string query = "SELECT * FROM users";
                //connection.Open();
                //MySqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read())

                //{
                //    int id = reader.GetInt32("id");
                //    string username = reader.GetString("username");
                //    string password = reader.GetString("password");
                //    string email = reader.GetString("email");

                //    dt.Rows.Add(id, username, password, email);



                //}



            }
            catch (Exception ex)
            {
                //lbl_mensaje.Text += "Error en Lista: " + ex.Message;
                lbl_mensaje.Text += "Error en la lista: " + ex.Message;
            }
            //finally
            //{
            //    connection.Close();
            //}

            datagrid.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crearUsuario();
            ListarTodo();
            limpiarCasillas();
        }

        private void crearUsuario()
        {
           // string query = "INSERT INTO users (username,password,email)" +
                //" VALUES (@username,@password,@email)";
            try
            {
                EUser user = new EUser();
                user.Username =txt_username.Text;
                user.Password =txt_pass.Text;
                user.Email =txt_email.Text;

                control.Create(user);
                //MySqlCommand cmd = new MySqlCommand(query, this.connection);
                //cmd.Parameters.AddWithValue("@username", txt_username.Text);
                //cmd.Parameters.AddWithValue("@password", txt_pass.Text);
                //cmd.Parameters.AddWithValue("@email", txt_email.Text);

                //connection.Open();
                //cmd.ExecuteNonQuery();

                control.Create(user);

                lbl_mensaje.Text = "";
                lbl_mensaje.Text += "Registro insertado correctamente";
                
            }
            catch (Exception ex) {
                lbl_mensaje.Text += "Error en registro: " + ex.Message;
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

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            var fila = datagrid.Rows[indice];
            string username = fila.Cells[1].Value + "";
            string password = fila.Cells[2].Value.ToString();
            string email = fila.Cells[3].Value.ToString();

            id_selected =Convert.ToInt32(fila.Cells[0].Value.ToString());

            txt_username.Text = username;
           // txt_pass.Text = password;
            txt_email.Text = email;

            btnEliminar.Enabled = true;
            btn_actualizar.Enabled = true;

            btn_agregar.Enabled = false;


        }


        public void update()
        {
            //string query = "UPDATE users SET username=@uno," +
            //    "password=@dos,email=@tres" +
            //    " WHERE id=@cuatro";

            try
            {
                EUser user = new EUser();
                user.Id = id_selected;
                user.Username = txt_username.Text;
                user.Password = txt_pass.Text;
                user.Email= txt_email.Text;
                //MySqlCommand cmd = new MySqlCommand(query, this.connection);
                //cmd.Parameters.AddWithValue("@uno", txt_username.Text);
                //cmd.Parameters.AddWithValue("@dos", txt_pass.Text);
                //cmd.Parameters.AddWithValue("@tres", txt_email.Text);

                //cmd.Parameters.AddWithValue("@cuatro", id_selected);

                //connection.Open();
                //cmd.ExecuteNonQuery();

                control.Update(user);
                lbl_mensaje.Text = "";
                lbl_mensaje.Text += "Registro Actualizado correctamente";
                
            }
            catch (Exception ex)
            {
                lbl_mensaje.Text += "Error en registro: " + ex.Message;
            }
            //finally
            //{
            //    connection.Close();
            //}
        }

        public void delete()
        {
            //string query = "DELETE from users WHERE id=@id";
            try
            {
                EUser user = new EUser();
                user.Id = id_selected;

                control.Delete(user);
                //MySqlCommand cmd = new MySqlCommand(query, this.connection);

                //cmd.Parameters.AddWithValue("@id", id_selected);

                //connection.Open();
                //cmd.ExecuteNonQuery();

                //lbl_mensaje.Text = "";
                lbl_mensaje.Text += "Registro Eliminado Correctamente";

            }
            catch (Exception ex) {
                lbl_mensaje.Text += "Error en eliminar: " + ex.Message;
            }
            //finally { connection.Close(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            update();
            ListarTodo();
            limpiarCasillas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            delete();
            ListarTodo();
            limpiarCasillas();
        }

        private void limpiarCasillas()
        {
            txt_email.Text = "";
            txt_pass.Text = "";
            txt_username.Text = "";

            btnEliminar.Enabled = false;
            btn_actualizar.Enabled = false;

            btn_agregar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCasillas();
        }

        private void practica()
        {
            EUser entidad = new EUser(2, "aa","bb","cc");

            entidad.Id = 2;

            EUser entidad1 = new EUser();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
        
    

