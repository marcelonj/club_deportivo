using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ProyectoFinal.Datos
{
    public class Conexion
    {
        private string database;
        private string host;
        private string port;
        private string user;
        private string pass;
        public static Conexion? con = null;
    
        private Conexion()
        {
            this.database = "ClubDeportivo";
            this.host = "127.0.0.1";
            this.port = "3306";
            this.user = "main";
            this.pass = "1234";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "datasource=" + this.host +
                                          ";port=" + this.port +
                                          ";username=" + this.user +
                                          ";password=" + this.pass +
                                          ";Database=" + this.database;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
