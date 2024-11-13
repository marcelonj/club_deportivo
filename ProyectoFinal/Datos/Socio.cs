using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoFinal.Datos
{
    internal class Socio
    {
        public string Nuevo_Socio(E_Socio socio)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = socio.nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = socio.apellido;
                comando.Parameters.Add("Gen", MySqlDbType.VarChar).Value = socio.genero;
                comando.Parameters.Add("Edad", MySqlDbType.Int32).Value = socio.edad;
                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value = socio.dni;
                comando.Parameters.Add("Tipo", MySqlDbType.Int32).Value = socio.tipo;
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
                if(sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }
    }
}
