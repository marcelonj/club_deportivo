using MySql.Data.MySqlClient;
using ProyectoFinal.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Cuota : Form
    {
        public Cuota()
        {
            InitializeComponent();
        }

        void limpiarDatos()
        {
            lblNroSocioDato.Text = "-";
            lblDniDato.Text = "-";
            lblNombreDato.Text = "-";
            lblApellidoDato.Text = "-";
        }

        int comprobarDocumento(int dni)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "SELECT * FROM socio WHERE dni=" + dni + ";";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    lblNroSocioDato.Text = reader.GetString(0);
                    lblDniDato.Text = reader.GetString(5);
                    lblNombreDato.Text = reader.GetString(1);
                    lblApellidoDato.Text = reader.GetString(2);
                    return Convert.ToInt32(reader.GetString(0));
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            if (comprobarDocumento(Convert.ToInt32(txtDocumento.Text)) != 0)
            {
                btnCuota.Enabled = true;
                int nroSocio = comprobarDocumento(Convert.ToInt32(txtDocumento.Text));
            }
            else
            {
                btnCuota.Enabled = false;
                limpiarDatos();
            }
        }

        private void btnCuota_Click(object sender, EventArgs e)
        {
            int nroSocio = comprobarDocumento(Convert.ToInt32(txtDocumento.Text));
            Datos.Carnet carnet = new Datos.Carnet();
            int resultado = Convert.ToInt32(carnet.Pagar_Cuota(nroSocio));
            switch (resultado)
            {
                case 1:
                    MessageBox.Show("El socio no posee carnet", "CARNET NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("El socio posee la cuota al dia", "CUOTA AL DIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("Cuota pagada correctamente", "PAGO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
