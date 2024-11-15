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
            cboTipo.Items.Add("Socios");
            cboTipo.Items.Add("No socios");
            cboTipo.Text = "Socios";
        }

        private void actualizarDataGrid(int tipo)
        {
            DataTable dt = new DataTable();
            MySqlConnection con = Datos.Conexion.getInstancia().CrearConexion();
            MySqlDataReader resultado;
            try
            {
                string query = "SELECT nroSocio, nombre, apellido, genero, dni FROM socio WHERE tipo=" + tipo + ";";
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

        private void refrescarDataGrid()
        {
            if(cboTipo.Text == "Socios")
            {
                actualizarDataGrid(1);
            }
            else if(cboTipo.Text == "No socios")
            {
                actualizarDataGrid(2);
            }
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
            refrescarDataGrid();
        }
    }
}
