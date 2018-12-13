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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

       

        private void inicio_Resize(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            consulta formaSiguiente = new consulta();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }
    }
}
