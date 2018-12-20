using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers; 
using System.IO;
using System.Net.Http;
using Newtonsoft.Json; 


namespace GUI_MODERNISTA
{
    public partial class reportesyanalisisINID : Form
    {
        GMarkerGoogle marker;
        GMapOverlay mapOverlay;
        DataTable dt; 
        int vContadorDatos; 
        Panel panel;
        double latinicial = 4.570868;
        double loninicial = -74.29733299999998; 


        public reportesyanalisisINID()
        {
            InitializeComponent();
           
        }

        private void Registro_Load(object sender, EventArgs e)
        {
          
           
                monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;

            comboBox1.Items.Add("VOLUMENM3");
            comboBox1.Items.Add("PRESION_PSI");
            comboBox1.Items.Add("FLUJO_LT_MIN");

        }
        
        private void button1_ClickAsync(object sender, EventArgs e)
        {

            if (textidmedidor.Text == "" ||  comboBox1.Text  == "" || textfechainicio.Text == "" || textfechafin.Text=="")
            {
                MessageBox.Show("INGRESE TODOS LOS DATOS", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                ConsultareportesyanalisisIN reportes = new ConsultareportesyanalisisIN(panel);
                reportes.fechainicio = textfechainicio.Text;
                reportes.fechafin = textfechafin.Text;
                reportes.variable = comboBox1.Text;
                reportes.idmedidor = textidmedidor.Text;
                
                panel2.Controls.Clear();
                panel2.Controls.Add(reportes);

                graficaanalisisyreportes reportes1 = new graficaanalisisyreportes();
                reportes1.fechainicio = textfechainicio.Text;
                reportes1.fechafin = textfechafin.Text;
                reportes1.variable = comboBox1.Text;
                reportes1.idmedidor = textidmedidor.Text;

                
                panel3.Controls.Clear();
                panel3.Controls.Add(reportes1);

                mapa reportes2 = new mapa();
                reportes2.fechainicio = textfechainicio.Text;
                reportes2.fechafin = textfechafin.Text;
                reportes2.variable = comboBox1.Text;
                reportes2.idmedidor = textidmedidor.Text;
                
                panel4.Controls.Clear();
                panel4.Controls.Add(reportes2);
            }
            
     
            
        }

        

        


        

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textfechainicio.Text = monthCalendar1.SelectionStart.Day.ToString() + "/" +
                monthCalendar1.SelectionStart.Month.ToString() + "/" + monthCalendar1.SelectionStart.Year.ToString(); 
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textfechafin.Text = monthCalendar2.SelectionStart.Day.ToString() + "/" +
                monthCalendar2.SelectionStart.Month.ToString() + "/" + monthCalendar2.SelectionStart.Year.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible)
            {
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;
            }
            if (monthCalendar2.Visible)
            {
                monthCalendar2.Visible = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (monthCalendar2.Visible)
            {
                monthCalendar2.Visible = false;
            }
            else
            {
                monthCalendar2.Visible = true;
            }
            if (monthCalendar1.Visible)
            {
                monthCalendar1.Visible = false;
            }
        }
    }
}
