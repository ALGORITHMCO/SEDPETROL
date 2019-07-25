using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class consulta : Form
    {
        public consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textcontrato.Text == "")
            {
                MessageBox.Show("INGRESE NUMERO DE CONTRATO", "DATOS FALTANTES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                portausuarios portal = new portausuarios();
                portal.cuenta = textcontrato.Text;
                //portal.con.Text = textcontrato.Text;
                portal.Show(); // muestra la forma2
            }

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
