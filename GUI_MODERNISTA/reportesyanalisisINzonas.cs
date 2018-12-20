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
    public partial class reportesyanalisisINzonas : Form
    {
        int vContadorDatos; 
        Panel panel;
        public reportesyanalisisINzonas()
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
        
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "" || textfechainicio.Text == "" || textfechafin.Text == "")
            {
                MessageBox.Show("INGRESE VARIABLE A CONSULTAR", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (textdepartamento.Text == "" && textciudad.Text == "" && textzona.Text == "")
                {
                    MessageBox.Show("Ingrese algún parametro de busqueda", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                 
                    else
                    {
                        ConsultareportesyanalisisINzonas reportes = new ConsultareportesyanalisisINzonas(panel);
                        reportes.fechainicio = textfechainicio.Text;
                        reportes.fechafin = textfechafin.Text;
                        reportes.variable = comboBox1.Text;
                        reportes.departamento = textdepartamento.Text;
                        reportes.ciudad = textciudad.Text;
                        reportes.zona = textzona.Text;
                        reportes.localidad = textlocalidad.Text;
                        reportes.barrio = textbarrio.Text;
                        

                        panel2.Controls.Clear();
                        panel2.Controls.Add(reportes);

                        graficaanalisisyreporteszonas reportes1 = new graficaanalisisyreporteszonas();
                        reportes1.fechainicio = textfechainicio.Text;
                        reportes1.fechafin = textfechafin.Text;
                        reportes1.variable = comboBox1.Text;
                        reportes1.departamento = textdepartamento.Text;
                        reportes1.ciudad = textciudad.Text;
                        reportes1.zona = textzona.Text;
                        reportes1.localidad = textlocalidad.Text;
                        reportes1.barrio = textbarrio.Text;


                        panel3.Controls.Clear();
                        panel3.Controls.Add(reportes1);

                        mapazonas reportes2 = new mapazonas();
                        reportes2.fechainicio = textfechainicio.Text;
                        reportes2.fechafin = textfechafin.Text;
                        reportes2.variable = comboBox1.Text;
                        reportes2.departamento = textdepartamento.Text;
                        reportes2.ciudad = textciudad.Text;
                        reportes2.zona = textzona.Text;
                        reportes2.localidad = textlocalidad.Text;
                        reportes2.barrio = textbarrio.Text;


                        panel4.Controls.Clear();
                        panel4.Controls.Add(reportes2);
                    }
                }
            


        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
