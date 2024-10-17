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
    public partial class Socios : Form
    {
        public Socios()
        {
            InitializeComponent();
        }

        private void btnAgregarSocio_Click(object sender, EventArgs e)
        {
            nvoSocio nvosocio = new nvoSocio();
            nvosocio.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }

        private void Socios_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlConnection con = Datos.Conexion.getInstancia().CrearConexion();
            MySqlDataReader resultado;
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM socio;", con);
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
    }
}
