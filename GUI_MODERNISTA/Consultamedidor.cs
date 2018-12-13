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
    public partial class Consultamedidor : Form
    {

        public string nucue; 
        public Consultamedidor()
        {
            InitializeComponent();
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

        private void Consultamedidor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Registroo.Buscar(portausuarios.cuen);
        }
    }
}
