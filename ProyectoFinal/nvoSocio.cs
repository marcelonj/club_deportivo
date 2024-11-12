using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoFinal.Entidades;

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

            if (txtNombre.Text == "" || txtApellido.Text == "" || cboGenero.Text == "" || txtEdad.Text == "" || txtDni.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos para registrar un nuevo socio", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;

                E_Socio socio = new E_Socio();
                socio.nombre = txtNombre.Text;
                socio.apellido = txtApellido.Text;
                socio.genero = cboGenero.Text;
                socio.edad = Convert.ToInt32(txtEdad.Text);
                socio.dni = Convert.ToInt32(txtDni.Text);

                Datos.Socio socios = new Datos.Socio();
                respuesta = socios.Nuevo_Socio(socio);

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("POSTULANTE YA EXISTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("se almaceno con exito con el codigo Nro  " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }
    }
}
