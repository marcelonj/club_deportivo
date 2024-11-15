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
            int nroSocio;
            if(int.TryParse(txtDocumento.Text, out nroSocio))
            {
                if (comprobarDocumento(Convert.ToInt32(txtDocumento.Text)) != 0)
                {
                    if(txtMonto.Text != "")
                    {
                        btnCuota.Enabled = true;
                    }                    
                    nroSocio = comprobarDocumento(Convert.ToInt32(txtDocumento.Text));
                }
                else
                {
                    btnCuota.Enabled = false;
                    limpiarDatos();
                }
            }
            else
            {
                btnCuota.Enabled= false;
            }
            
        }

        private void btnCuota_Click(object sender, EventArgs e)
        {
            int nroSocio = comprobarDocumento(Convert.ToInt32(txtDocumento.Text));
            float monto;
            if(float.TryParse(txtMonto.Text, out monto))
            {
                Datos.Carnet carnet = new Datos.Carnet();
                int resultado = Convert.ToInt32(carnet.Pagar_Cuota(nroSocio, monto));
                switch (resultado)
                {
                    case 1:
                        MessageBox.Show("No socio pago el día", "PAGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        MessageBox.Show("El socio posee la cuota al dia", "CUOTA AL DIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        MessageBox.Show("Cuota pagada correctamente", "PAGO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido", "MONTO INVALIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
