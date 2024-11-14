using MySql.Data.MySqlClient;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProyectoFinal.Datos
{
    internal class Carnet
    {
        public string Nuevo_Carnet(int nroSocio)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoCarnet", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("nSocio", MySqlDbType.Int32).Value = nroSocio;
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }
    }
}
