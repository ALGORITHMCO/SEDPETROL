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
        int vContadorDatos; 
        Panel panel;
        public reportesyanalisisIN()
        {
            InitializeComponent();
           
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }

       

        
        private void button1_Click(object sender, EventArgs e)
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

            panel2.Controls.Clear();
            panel2.Controls.Add(reportes);

            graficaanalisisyreportes reportes1 = new graficaanalisisyreportes();
            reportes1.fechainicio = textfechainicio.Text;
            reportes1.fechafin = textfechafin.Text;
            reportes1.variable = textvariable.Text;
            reportes1.departamento = textdepartamento.Text;
            reportes1.ciudad = textciudad.Text;
            reportes1.zona = textzona.Text;
            reportes1.localidad = textlocalidad.Text;
            reportes1.barrio = textbarrio.Text;
            reportes1.idmedidor = textidmedidor.Text;

            //portal.con.Text = textcontrato.Text;

            // reportes.Show();

            panel3.Controls.Clear();
            panel3.Controls.Add(reportes1);


            // Sacamos un numero aleatorio del 0 al 100


        }
    }
}
