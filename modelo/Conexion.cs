using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario.modelo
{
    public class Conexion
    {       
        
            private string server = "localhost";
            private string db_name = "test_csharp";
            private string db_user = "root";
            private string db_pass = "Lurin@2024";

        //atributo de mysql

        private MySqlConnection conn;

        //propiedad
        public MySqlConnection getConexion { get => conn; }


        public Conexion() 
        {
           
            String connectionString = $"Server={server};Database={db_name};User ID = {db_user};Password ={db_pass} ;";
            conn = new MySqlConnection(connectionString);
        }

        public void open()
        {
            if (conn.State== System.Data.ConnectionState.Closed) 
            { 
                conn.Open();
            }
        }
        public void close()

        {
            if (conn.State!= System.Data.ConnectionState.Open) 
            { 
                conn.Close();
            }
        }
       
    }
}

