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
    public partial class reportesyanalisisIN : Form
    {

        Panel panel;
        public reportesyanalisisIN(Panel p)
        {
            InitializeComponent();
            panel = p;
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            ConsultareportesyanalisisIN reportes = new ConsultareportesyanalisisIN(panel);
            reportes.fechainicio = textfechainicio.Text;
            reportes.fechafin = textfechafin.Text;
            reportes.variable = textvariable.Text;
            reportes.departamento = textdepartamento.Text;
            reportes.ciudad = textciudad.Text;
            reportes.zona = textzona.Text;
            reportes.localidad = textlocalidad.Text;
            reportes.barrio = textbarrio.Text;
            reportes.idmedidor = textidmedidor.Text;

            //portal.con.Text = textcontrato.Text;

            // reportes.Show();

            panel.Controls.Clear();
            panel.Controls.Add(reportes);
        }
    }
}
