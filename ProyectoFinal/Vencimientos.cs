using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Vencimientos : Form
    {
        public Vencimientos()
        {
            InitializeComponent();
        }

        private void Vencimientos_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            string fechaFormateada = fechaActual.ToString("yyyy-MM-dd");
            DataTable dt = new DataTable();
            MySqlConnection con = Datos.Conexion.getInstancia().CrearConexion();
            MySqlDataReader resultado;
            try
            {
                string query = "SELECT s.nroSocio, nombre, apellido, genero, dni FROM socio s INNER JOIN carnet c ON s.nroSocio=c.nroSocio WHERE fechaVencimiento='" + fechaFormateada + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                resultado = cmd.ExecuteReader();
                dt.Load(resultado);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dtgvSocios.DataSource = dt;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }
    }
}
