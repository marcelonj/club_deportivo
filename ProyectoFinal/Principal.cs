using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            nvoSocio nvosocios = new nvoSocio();
            nvosocios.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cuota cuota = new Cuota();
            cuota.Show();
            this.Hide();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            Socios socios = new Socios();
            socios.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Carnet carnet = new Carnet();
            carnet.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vencimientos vencimientos = new Vencimientos();
            vencimientos.Show();
            this.Hide();
        }
    }
}
