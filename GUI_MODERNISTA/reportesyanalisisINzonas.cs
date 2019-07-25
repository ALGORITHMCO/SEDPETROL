using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_MODERNISTA
{



    public partial class reportesyanalisisINzonas : Form
    {
      
        

        int vContadorDatos;
        Panel panel;
        int mes;
        int año;
        int diainicio;
        int diafin;
        string variable;
        string fechainicio;
        string fechafin;
        string departamento;
        string ciudad;
        string zona;
        string localidad;
        string barrio;

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

            comboBox2.DataSource = Registroo.vaconsultaDEPAR();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "" || textfechainicio.Text == "" || textfechafin.Text == "")
            {
                MessageBox.Show("INGRESE VARIABLE A CONSULTAR", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (comboBox2.Text == "" && comboBox3.Text == "" && comboBox4.Text == "")
                {
                    MessageBox.Show("Ingrese algún parametro de busqueda", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    graficaanalisisyreporteszonas reportes1 = new graficaanalisisyreporteszonas();

                    ConsultareportesyanalisisINzonas dd = new ConsultareportesyanalisisINzonas();

                    variable = comboBox1.Text;
                    fechainicio = textfechainicio.Text;
                    fechafin = textfechafin.Text;
                    departamento = comboBox2.Text;
                    ciudad = comboBox3.Text;
                    zona = comboBox4.Text;
                    localidad = comboBox5.Text;
                    barrio = comboBox6.Text;

                    dd.fechainicio = textfechainicio.Text;
                    dd.fechafin = textfechafin.Text;
                    dd.variable = comboBox1.Text;
                    dd.departamento = comboBox2.Text;
                    dd.ciudad = comboBox3.Text;
                    dd.zona = comboBox4.Text;
                    dd.localidad = comboBox5.Text;
                    dd.barrio = comboBox6.Text;

                    panel2.Controls.Clear();
                    panel2.Controls.Add(dd);

                    reportes1.fechainicio = textfechainicio.Text;
                    reportes1.fechafin = textfechafin.Text;
                    reportes1.variable = comboBox1.Text;
                    reportes1.departamento = comboBox2.Text;
                    reportes1.ciudad = comboBox3.Text;
                    reportes1.zona = comboBox4.Text;
                    reportes1.localidad = comboBox5.Text;
                    reportes1.barrio = comboBox6.Text;


                    panel3.Controls.Clear();
                    panel3.Controls.Add(reportes1);

                    mapazonas reportes2 = new mapazonas();
                    reportes2.fechainicio = textfechainicio.Text;
                    reportes2.fechafin = textfechafin.Text;
                    reportes2.variable = comboBox1.Text;
                    reportes2.departamento = comboBox2.Text;
                    reportes2.ciudad = comboBox3.Text;
                    reportes2.zona = comboBox4.Text;
                    reportes2.localidad = comboBox5.Text;
                    reportes2.barrio = comboBox6.Text;


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
            textfechainicio.Text = monthCalendar1.SelectionStart.Year.ToString() + "-" +
               monthCalendar1.SelectionStart.Month.ToString() + "-" + monthCalendar1.SelectionStart.Day.ToString();

            diainicio = monthCalendar1.SelectionStart.Day;
            mes = monthCalendar1.SelectionStart.Month;
            año = monthCalendar1.SelectionStart.Year;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textfechafin.Text = monthCalendar2.SelectionStart.Year.ToString() + "-" +
                monthCalendar2.SelectionStart.Month.ToString() + "-" + monthCalendar2.SelectionStart.Day.ToString();

            diafin = monthCalendar2.SelectionStart.Day;
            mes = monthCalendar2.SelectionStart.Month;
            año = monthCalendar2.SelectionStart.Year;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void generardocumento(Document documento)
        {

           
            ConsultareportesyanalisisINzonas dd = new ConsultareportesyanalisisINzonas();

            dd.fechainicio = fechainicio;
            dd.fechafin = fechafin;
            dd.variable = variable;
            dd.departamento = departamento;
            dd.ciudad = ciudad;
            dd.zona = zona;
            dd.localidad = localidad;
            dd.barrio = barrio;

            panel2.Controls.Clear();
            panel2.Controls.Add(dd);
            int i, j;
            PdfPTable datatable = new PdfPTable(dd.dataGridView1.Columns.Count);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañodelasColumnas(dd.dataGridView1);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < dd.dataGridView1.ColumnCount; i++)
            {
                datatable.AddCell(dd.dataGridView1.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < dd.dataGridView1.Rows.Count; i++)
            {
                for (j = 0; j < dd.dataGridView1.ColumnCount; j++)
                {
                    if (dd.dataGridView1[j, i].Value != null)
                        datatable.AddCell(new Phrase(dd.dataGridView1[j, i].Value.ToString()));
                }
                datatable.CompleteRow();
            }
            documento.Add(datatable);


        }

        public float[] GetTamañodelasColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
            throw new NotImplementedException();
        }
        private void To_pdf()
        {

            Document doc = new Document(PageSize.LETTER_LANDSCAPE.Rotate(), 30, 20, 20, 20);
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = @"C:";
            save.Title = "Guardar Consulta";
            save.DefaultExt = "pdf";
            save.Filter = "pdf Files (*.pdf)|*.pdf| All Files(*.*)|*.*";
            save.FilterIndex = 2;
            save.RestoreDirectory = true;
            string filename = "";
            if (save.ShowDialog() == DialogResult.OK)
            {
                filename = save.FileName;

                if (filename.Trim() != "")
                {
                    FileStream file = new FileStream(filename,
                        FileMode.OpenOrCreate,
                        FileAccess.ReadWrite,
                        FileShare.ReadWrite);
                    PdfWriter.GetInstance(doc, file);
                    doc.Open();


                    string remito = "Scada Aquasoft";
                    string fecha = "fecha: " + DateTime.Now.ToString();

                    Chunk chunk = new Chunk("DETALLES DE LA CONSULTA", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                    doc.Add(new Paragraph(chunk));
                    doc.Add(new Paragraph("                    "));
                    doc.Add(new Paragraph("                    "));
                    //  doc.Add(new Paragraph("---------------------------------------------------------------------------------------", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph(remito));
                    doc.Add(new Paragraph(fecha)); doc.Add(new Paragraph("Departamento: " + departamento));
                    doc.Add(new Paragraph("Ciudad: " + ciudad));
                    doc.Add(new Paragraph("Zona: " + zona));
                    doc.Add(new Paragraph("Localidad: " + localidad));
                    doc.Add(new Paragraph("Barrio: " + barrio));
                    doc.Add(new Paragraph("Variable en " + variable));
                    doc.Add(new Paragraph("                    "));
                    doc.Add(new Paragraph("                    "));
                    doc.Add(new Paragraph("                    "));
                    generardocumento(doc);
                    doc.AddCreationDate();
                    // doc.Add(new Paragraph("---------------------------------------------------------------------------------------", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));

                }



                var chartimage = new MemoryStream();

                graficaanalisisyreporteszonas reportes1 = new graficaanalisisyreporteszonas();

                reportes1.fechainicio = fechainicio;
                reportes1.fechafin = fechafin;
                reportes1.variable = variable;
                reportes1.departamento = departamento;
                reportes1.ciudad = ciudad;
                reportes1.zona = zona;
                reportes1.localidad = localidad;
                reportes1.barrio = barrio;

                panel3.Controls.Clear();
                panel3.Controls.Add(reportes1);


                reportes1.chart1.SaveImage(chartimage, ChartImageFormat.Png);
                iTextSharp.text.Image chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
                chart_image.ScaleToFit(770, 200);
                doc.Add(new Paragraph("                    "));
                doc.Add(new Paragraph("                    "));
                doc.Add(chart_image);
                doc.Close();

                Process.Start(filename);
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }

        }

        



        private void button4_Click_1(object sender, EventArgs e)
        {
            To_pdf();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string departa = comboBox2.Text;

            comboBox3.DataSource = Registroo.vaconsultaMUNI(departa);
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string departa = comboBox2.Text;
            string muni = comboBox3.Text;
            
            comboBox4.DataSource = Registroo.vaconsultaZONA(departa, muni);
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departa = comboBox2.Text;
            string muni = comboBox3.Text;
            string zona = comboBox4.Text; 

            comboBox5.DataSource = Registroo.vaconsultaLOCALIDAD(departa, muni, zona);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departa = comboBox2.Text;
            string muni = comboBox3.Text;
            string zona = comboBox4.Text;
            string locali = comboBox5.Text;

            comboBox6.DataSource = Registroo.vaconsultaBARRIO(departa, muni, zona, locali);
        }
    }
}
