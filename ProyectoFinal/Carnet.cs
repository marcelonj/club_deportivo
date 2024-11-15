using MySql.Data.MySqlClient;
using ProyectoFinal.Datos;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Carnet : Form
    {
        public Carnet()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            int nroSocio;
            if (int.TryParse(txtDocumento.Text, out nroSocio))
            {
                if (comprobarDocumento(Convert.ToInt32(txtDocumento.Text)) != 0)
                {
                    btnEmitir.Enabled = true;
                    nroSocio = comprobarDocumento(Convert.ToInt32(txtDocumento.Text));
                }
                else
                {
                    btnEmitir.Enabled = false;
                    limpiarDatos();
                }
            }
            else
            {
                btnEmitir.Enabled = false;
                limpiarDatos();
            }
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            string respuesta;
            int nroSocio = comprobarDocumento(Convert.ToInt32(txtDocumento.Text));
            Datos.Carnet carnet = new Datos.Carnet();
            respuesta = carnet.Nuevo_Carnet(nroSocio);
            bool esnumero = int.TryParse(respuesta, out int codigo);
            if (esnumero)
            {
                if (codigo == 1)
                {
                    MessageBox.Show("SOCIO CON CARNET YA EMITIDO", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("se almaceno con exito con el carnet Nro  " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }
    }
}
