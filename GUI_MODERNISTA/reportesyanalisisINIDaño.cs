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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

using System.Windows.Forms.DataVisualization.Charting;


namespace GUI_MODERNISTA
{
    public partial class reportesyanalisisINIDaño : Form
    {

        GMarkerGoogle marker;
        GMapOverlay mapOverlay;
        DataTable dt;
        int vContadorDatos;
        Panel panel;
        double latinicial = 4.570868;
        double loninicial = -74.29733299999998;
        
        string variable;
        string fechainicio;
        string fechafin;
        string idmedido;

        public reportesyanalisisINIDaño()
        {
            InitializeComponent();

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            

            comboBox1.Items.Add("VOLUMENM3");
            comboBox1.Items.Add("PRESION_PSI");
            comboBox1.Items.Add("FLUJO_LT_MIN");

            comboBox2.DataSource = Registroo.vaconsultaNUIDMEDIDOR();

        }
        private void panelContenedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                variable = comboBox1.Text;
                fechainicio = textfechainicio.Text;
                fechafin = textfechafin.Text;
                idmedido = comboBox2.Text;

                if (comboBox2.Text == "" || comboBox1.Text == "" || textfechainicio.Text == "" || textfechafin.Text == "")
                {
                    MessageBox.Show("INGRESE TODOS LOS DATOS", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {


                    ConsultareportesyanalisisINaño dd = new ConsultareportesyanalisisINaño();
                    graficaanalisisyreportesaño reportes1 = new graficaanalisisyreportesaño();

                    variable = comboBox1.Text;
                    dd.fechainicio = textfechainicio.Text;
                    dd.fechafin = textfechafin.Text;
                    dd.variable = comboBox1.Text;
                    dd.idmedidor = comboBox2.Text;

                    panel2.Controls.Clear();
                    panel2.Controls.Add(dd);


                    reportes1.fechainicio = textfechainicio.Text;
                    reportes1.fechafin = textfechafin.Text;
                    reportes1.variable = comboBox1.Text;
                    reportes1.idmedidor = comboBox2.Text;


                    panel3.Controls.Clear();
                    panel3.Controls.Add(reportes1);

                    mapa reportes2 = new mapa();
                    reportes2.fechainicio = textfechainicio.Text;
                    reportes2.fechafin = textfechafin.Text;
                    reportes2.variable = comboBox1.Text;
                    reportes2.idmedidor = comboBox2.Text;

                    panel4.Controls.Clear();
                    panel4.Controls.Add(reportes2);
                }
            }
        }
        private void button1_ClickAsync(object sender, EventArgs e)
        {

            variable = comboBox1.Text;
            fechainicio = textfechainicio.Text;
            fechafin = textfechafin.Text;
            idmedido = comboBox2.Text;

            if (comboBox2.Text == "" || comboBox1.Text == "" || textfechainicio.Text == "" || textfechafin.Text == "")
            {
                MessageBox.Show("INGRESE TODOS LOS DATOS", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {


                ConsultareportesyanalisisINaño dd = new ConsultareportesyanalisisINaño();
                graficaanalisisyreportesaño reportes1 = new graficaanalisisyreportesaño();

                variable = comboBox1.Text;
                dd.fechainicio = textfechainicio.Text;
                dd.fechafin = textfechafin.Text;
                dd.variable = comboBox1.Text;
                dd.idmedidor = comboBox2.Text;

                panel2.Controls.Clear();
                panel2.Controls.Add(dd);


                reportes1.fechainicio = textfechainicio.Text;
                reportes1.fechafin = textfechafin.Text;
                reportes1.variable = comboBox1.Text;
                reportes1.idmedidor = comboBox2.Text;


                panel3.Controls.Clear();
                panel3.Controls.Add(reportes1);

                mapa reportes2 = new mapa();
                reportes2.fechainicio = textfechainicio.Text;
                reportes2.fechafin = textfechafin.Text;
                reportes2.variable = comboBox1.Text;
                reportes2.idmedidor = comboBox2.Text;

                panel4.Controls.Clear();
                panel4.Controls.Add(reportes2);
            }



        }
        



        public void generardocumento(Document documento)
        {
            ConsultareportesyanalisisINaño dd = new ConsultareportesyanalisisINaño();
            dd.fechainicio = fechainicio;
            dd.fechafin = fechafin;
            dd.variable = variable;
            dd.idmedidor = idmedido;
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
                    // doc.Add(new Paragraph("---------------------------------------------------------------------------------------", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph(remito));
                    doc.Add(new Paragraph(fecha));
                    doc.Add(new Paragraph("Medidor " + idmedido));
                    doc.Add(new Paragraph("Variable en " + variable));
                    doc.Add(new Paragraph("                    "));
                    doc.Add(new Paragraph("                    "));
                    doc.Add(new Paragraph("                    "));
                    generardocumento(doc);
                    doc.AddCreationDate();
                    // doc.Add(new Paragraph("---------------------------------------------------------------------------------------", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));


                }

                var chartimage = new MemoryStream();


                graficaanalisisyreportesaño reportes1 = new graficaanalisisyreportesaño();
                reportes1.fechainicio = fechainicio;
                reportes1.fechafin = fechafin;
                reportes1.variable = variable;
                reportes1.idmedidor = idmedido;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            To_pdf();
        }

        private void textfechainicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textfechafin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}