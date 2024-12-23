﻿using System;
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
            cboApto.Items.Add("Apto");
            cboApto.Items.Add("No apto");
            optSocio.Checked = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal menu = new Principal();
            menu.Show();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || cboGenero.Text == "" || txtEdad.Text == "" || txtDni.Text == "" || cboApto.Text == "")
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
                socio.apto =cboApto.Text;
                if (optSocio.Checked)
                {
                    socio.tipo = 1;
                }
                else if (optNoSocio.Checked)
                {
                    socio.tipo = 2;
                }

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
