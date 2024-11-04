using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoFinal
{
    public partial class nvoSocio : Form
    {
        public nvoSocio()
        {
            InitializeComponent();
            cboGenero.Items.Add("Masculino");
            cboGenero.Items.Add("Femenino");
            cboGenero.Items.Add("Otro");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Socios socios = new Socios();
            socios.Show();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int nroSocio = 0;
            MySqlConnection con = null;
            MySqlCommand cmd = null;

            try
            {
                con = Datos.Conexion.getInstancia().CrearConexion();
                cmd = new MySqlCommand("getNroSocio", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                MySqlDataReader resultado = cmd.ExecuteReader();
                if (resultado.Read())
                {
                    nroSocio = resultado.GetInt32(0);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (nroSocio > 0)
            {
                string insert = "INSERT INTO socio (nroSocio, nombre, apellido, genero, edad, dni) VALUES (@nroSocio, @nombre, @apellido, @genero, @edad, @dni)";
                con.Open();
                cmd = new MySqlCommand(insert, con);
                cmd.Parameters.Add(new MySqlParameter("@nroSocio", nroSocio));
                cmd.Parameters.Add(new MySqlParameter("@nombre", txtNombre.Text));
                cmd.Parameters.Add(new MySqlParameter("@apellido", txtApellido.Text));
                cmd.Parameters.Add(new MySqlParameter("@genero", cboGenero.Text));
                cmd.Parameters.Add(new MySqlParameter("@edad", txtEdad.Text));
                cmd.Parameters.Add(new MySqlParameter("@dni", txtDni.Text));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se agrego al nuevo socio correctamente\nNúmero de socio: " + nroSocio);
                }
            }
            else
            {
                MessageBox.Show("Ocurrio un error al obtener el número de socio");
            }
            con.Close();
        }

        private void nvoSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
