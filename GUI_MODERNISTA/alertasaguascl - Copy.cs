﻿using System;
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
    public partial class alertasaguasno : Form
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

        Double NU1 = 0.0;
        Double NU2 = 0.0;
        Double TOTAL = 0.0;
        string medidor;

        public alertasaguasno()
        {
            InitializeComponent();

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            IDANC.Text = Registroo.vaconsultaIDANC(); 
            comboBox1.DataSource = Registroo.vaconsultaNUIDMEDIDOR();


            comboBox2.Items.Add("Sobre presion");
            comboBox2.Items.Add("Fatiga material tuberia");
            comboBox2.Items.Add("Daños por terceros");
            comboBox2.Items.Add("Rotura ilícita");
            comboBox2.Items.Add("Exceso de carga");
            comboBox2.Items.Add("Otros");
            comboBox2.Items.Add("N/A");


            comboBox3.Items.Add("Acciones Fraudulentas");
            comboBox3.Items.Add("Micromedición");
            comboBox3.Items.Add("Otro");
            comboBox3.Items.Add("N/A");

            comboBox4.Items.Add("Medidores Manipulados");
            comboBox4.Items.Add("Conexiones Clandestinas");
            comboBox4.Items.Add("Otro");
            comboBox4.Items.Add("N/A");

            comboBox5.Items.Add("Suplantar Medidor");
            comboBox5.Items.Add("Medidor Invertido");
            comboBox5.Items.Add("Desconexión medidor y paso directo");
            comboBox5.Items.Add("Separar Ud de registro del medidor");
            comboBox5.Items.Add("Otro");
            comboBox5.Items.Add("N/A");

            comboBox6.Items.Add("Medidor desajustado");
            comboBox6.Items.Add("Medidor detenido");
            comboBox6.Items.Add("Otro");
            comboBox6.Items.Add("N/A");

            comboBox7.Items.Add("Comercial");
            comboBox7.Items.Add("Industrial");
            comboBox7.Items.Add("Oficial");
            comboBox7.Items.Add("Temporal");
            comboBox7.Items.Add("Provisional");
            comboBox7.Items.Add("Otro");
            comboBox7.Items.Add("N/A");


            DateTime Hoy = DateTime.Today;



            string fecha_actual = Hoy.ToString("dd/MM/yyyy");
            label12.Text = fecha_actual;

            label13.Text = DateTime.Now.ToString("HH:mm:ss");





        }

      

        private void barrio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lreconexiones_Click(object sender, EventArgs e)
        {

        }

       

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Acciones Fraudulentas")
            {
                comboBox4.Enabled = true;
                comboBox6.Enabled = false;
                comboBox6.Text="";
            }
            else
            {
                if (comboBox3.Text == "Micromedición")
                {
                    comboBox6.Enabled = true;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox4.Text = "";
                    comboBox5.Text = "";
                }
                else
                {
                    comboBox6.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Text = "";
                    comboBox4.Text = "";
                    comboBox5.Text = "";
                }
            }
        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Medidores Manipulados")
            {
                comboBox5.Enabled = true;
            }
            else
            {
                comboBox5.Enabled = false;
            }
        }

        private void fraudefluido_TextChanged_1(object sender, EventArgs en)
        {
            if (cortes.Text == "" && fraudefluido.Text != "")
            {
                NU1 = Convert.ToDouble(fraudefluido.Text);
                NU2 = 0.0;

                TOTAL = NU1 - NU2;
                Diferencia.Text = Convert.ToString(TOTAL);
            }
            else
            {
                if (fraudefluido.Text == "" && cortes.Text != "")
                {
                    NU1 = 0.0;
                    NU2 = Convert.ToDouble(cortes.Text);

                    TOTAL = NU1 - NU2;
                    Diferencia.Text = Convert.ToString(TOTAL);
                }
                else
                {
                    if (fraudefluido.Text == "" && cortes.Text == "")
                    {
                        NU1 = 0.0;
                        NU2 = 0.0;

                        TOTAL = NU1 - NU2;
                        Diferencia.Text = Convert.ToString(TOTAL);
                    }
                    else
                    {

                        NU1 = Convert.ToDouble(fraudefluido.Text);
                        NU2 = Convert.ToDouble(cortes.Text);

                        TOTAL = NU1 - NU2;
                        Diferencia.Text = Convert.ToString(TOTAL);
                    }

                }
            }
        }

        private void cortes_TextChanged_1(object sender, EventArgs e)
        {
            if (cortes.Text == "" && fraudefluido.Text != "")
            {
                NU1 = Convert.ToDouble(fraudefluido.Text);
                NU2 = 0.0;

                TOTAL = NU1 - NU2;
                Diferencia.Text = Convert.ToString(TOTAL);
            }
            else
            {
                if (fraudefluido.Text == "" && cortes.Text != "")
                {
                    NU1 = 0.0;
                    NU2 = Convert.ToDouble(cortes.Text);

                    TOTAL = NU1 - NU2;
                    Diferencia.Text = Convert.ToString(TOTAL);
                }
                else
                {
                    if (fraudefluido.Text == "" && cortes.Text == "")
                    {
                        NU1 = 0.0;
                        NU2 = 0.0;

                        TOTAL = NU1 - NU2;
                        Diferencia.Text = Convert.ToString(TOTAL);
                    }
                    else
                    {

                        NU1 = Convert.ToDouble(fraudefluido.Text);
                        NU2 = Convert.ToDouble(cortes.Text);

                        TOTAL = NU1 - NU2;
                        Diferencia.Text = Convert.ToString(TOTAL);
                    }

                }
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string medi = comboBox1.Text;
            string medi2 = comboBox1.Text;

            departamento.Text = Registroo.DaconsultaNUMEDIDOR(medi)[0];
            ciudad.Text = Registroo.DaconsultaNUMEDIDOR(medi)[1];
            zona.Text = Registroo.DaconsultaNUMEDIDOR(medi)[2];
            localidad.Text = Registroo.DaconsultaNUMEDIDOR(medi)[3];
            barrio.Text = Registroo.DaconsultaNUMEDIDOR(medi)[4];

            medidor = Registroo.DaconsultaNUMEDIDOR(medi)[9];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            alertasaguacl datos = new alertasaguacl();
            datos.ID_MEDIDOR = medidor;
            datos.FECHAINGRESO = label12.Text;
            datos.HORAINGRESO = label13.Text;
            datos.VOLUMENINGRESADO = fraudefluido.Text;
            datos.SUMATORIACONSUMOLEGAL = cortes.Text;
            datos.DIFERENCIA = Diferencia.Text;
            datos.PERDIDASTECNICAS = comboBox2.Text;
            datos.PERDIDASCOMERCIALES = comboBox3.Text;
            datos.ACCIONESFRAUDULENTAS = comboBox4.Text;
            datos.MEDIDORESMANIPULADOS = comboBox5.Text;
            datos.MICROMEDICION = comboBox6.Text;
            datos.CLASE_DE_USO = comboBox7.Text;
            datos.CAMPO1 = campo1.Text;
            datos.CAMPO2 = campo2.Text;
            datos.CAMPO3 = campo3.Text;
            datos.CAMPO4 = campo4.Text;
            datos.CAMPO5 = campo5.Text;


            int resul = Registroo.agregaralertasaguas(datos);

            if (resul == 1)
            {
                ////hola
                MessageBox.Show("Datos guardados Correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error conexion", "ERROR AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            IDANC.Text = Registroo.vaconsultaIDANC();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            To_pdf(); 
        }

        private void fraudefluido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char SignoDecimal = '.';
            if (e.KeyChar != SignoDecimal)
            {

            }
            else
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
            
        }

        private void cortes_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char SignoDecimal = '.';
            if (e.KeyChar != SignoDecimal)
            {

            }
            else
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }





        private void To_pdf()
        {
            alertasaguacl datos = new alertasaguacl();
            datos.ID_MEDIDOR = medidor;
            datos.FECHAINGRESO = label12.Text;
            datos.HORAINGRESO = label13.Text;
            datos.VOLUMENINGRESADO = fraudefluido.Text;
            datos.SUMATORIACONSUMOLEGAL = cortes.Text;
            datos.DIFERENCIA = Diferencia.Text;
            datos.PERDIDASTECNICAS = comboBox2.Text;
            datos.PERDIDASCOMERCIALES = comboBox3.Text;
            datos.ACCIONESFRAUDULENTAS = comboBox4.Text;
            datos.MEDIDORESMANIPULADOS = comboBox5.Text;
            datos.MICROMEDICION = comboBox6.Text;
            datos.CLASE_DE_USO = comboBox7.Text;
            datos.CAMPO1 = campo1.Text;
            datos.CAMPO2 = campo2.Text;
            datos.CAMPO3 = campo3.Text;
            datos.CAMPO4 = campo4.Text;
            datos.CAMPO5 = campo5.Text;

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

                    Chunk chunk = new Chunk("DETALLES DE NOVEDAD ALERTA AGUAS NO CONTABILIZADAS", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                    doc.Add(new Paragraph(chunk));
                    doc.Add(new Paragraph("                    "));
                    doc.Add(new Paragraph("                    "));
                    // doc.Add(new Paragraph("---------------------------------------------------------------------------------------", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("ID DE MEDIDOR: " +datos.ID_MEDIDOR));
                    doc.Add(new Paragraph("FECHA DE INGRESO: " +datos.FECHAINGRESO));
                    doc.Add(new Paragraph("HORA DE INGRESO: " +datos.HORAINGRESO));
                    doc.Add(new Paragraph("VOLUMEN INGRESADO: " +datos.VOLUMENINGRESADO));
                    doc.Add(new Paragraph("SUMATURA CONSUMO LEGAL: " +datos.SUMATORIACONSUMOLEGAL));
                    doc.Add(new Paragraph("DIFERENCIA: " +datos.DIFERENCIA));
                    doc.Add(new Paragraph("PERDIDAD TECNICAS: " +datos.PERDIDASTECNICAS));
                    doc.Add(new Paragraph("ACCIONES FRAUDULENTAS: " +datos.ACCIONESFRAUDULENTAS));
                    doc.Add(new Paragraph("MEDIDORES MANIPULADOS: " +datos.MEDIDORESMANIPULADOS));
                    doc.Add(new Paragraph("MICROMEDICION: " +datos.MICROMEDICION));
                    doc.Add(new Paragraph("CLASE DE USO: " +datos.CLASE_DE_USO));
                    doc.Add(new Paragraph("CAMPO 1: " +datos.CAMPO1));
                    doc.Add(new Paragraph("CAMPO 2: " +datos.CAMPO2));
                    doc.Add(new Paragraph("CAMPO 3: " +datos.CAMPO3));
                    doc.Add(new Paragraph("CAMPO 4: " +datos.CAMPO4));
                    doc.Add(new Paragraph("CAMPO 5: " +datos.CAMPO5));
                    doc.AddCreationDate();
                    // doc.Add(new Paragraph("---------------------------------------------------------------------------------------", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));


                }

                var chartimage = new MemoryStream();


                doc.Close();

                Process.Start(filename);
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }


        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}