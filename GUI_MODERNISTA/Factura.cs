using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
namespace GUI_MODERNISTA
{
    public partial class Factura : Form
    {
        int[] ListaSuma = new int[12];
        int mes,anio;
        int mesBase, suma;
        string inicio, fin;
        public Factura()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crystalReportViewer1.RefreshReport();
             crystalReportViewer1.Update();
            
            for (int i = 0; i < 12; i++) {
                ListaSuma[i] = 0;
            }
           
            inicio = year.Text + "-" + monthStart.Text + "-" + "01";
             mes = Convert.ToInt32(monthEnd.Text);
             anio = Convert.ToInt32(year.Text);
            mes += 1;
            if (mes == 13)
            {
                mes = 1;
                anio += 1;
            }
            
                fin = anio.ToString() + "-" + mes.ToString() + "-01";
            
            
            using (SqlConnection cone = conexion.conectarbd())
            {
                SqlCommand consul = new SqlCommand(String.Format("SELECT SUM ([VOLUMENM3]), DATEPART (MONTH, FECHA) FROM [dbo].[VARIABLES]WHERE[CUENTA_CONTRATO] ='" + contrato.Text + "'and[FECHA] >= '" + inicio + "'AND[FECHA] <' " + fin + "'GROUP BY DATEPART(MONTH, FECHA)"), cone);
                SqlDataReader reader = consul.ExecuteReader();


                while (reader.Read())
                {
                    suma = reader.GetInt32(0);
                    mesBase = reader.GetInt32(1);
                    switch (mesBase)
                    {
                        case 1:
                            ListaSuma[0] = suma;
                            break;
                        case 2:
                            ListaSuma[1] = suma;
                            break;
                        case 3:
                            ListaSuma[2] = suma;
                            break;
                        case 4:
                            ListaSuma[3] = suma;
                            break;
                        case 5:
                            ListaSuma[4] = suma;
                            break;
                        case 6:
                            ListaSuma[5] = suma;
                            break;
                        case 7:
                            ListaSuma[6] = suma;
                            break;
                        case 8:
                            ListaSuma[7] = suma;
                            break;
                        case 9:
                            ListaSuma[8] = suma;
                            break;
                        case 10:
                            ListaSuma[9] = suma;
                            break;
                        case 11:
                            ListaSuma[10] = suma;
                            break;
                        case 12:
                            ListaSuma[11] = suma;
                            break;
                        default:
                            ListaSuma[12] = 0;
                            break;

                    }

                }

                conexion.cerrarbd();

            }
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\CrystalReport1.rpt");  // direccion del reporte

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
            crParameterDiscreteValue.Value = contrato.Text;
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["ProductName"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crParameterDiscreteValue.Value = ListaSuma[0];
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["enero"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            ////
            crParameterDiscreteValue.Value = ListaSuma[1];
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["febrero"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            ////
            crParameterDiscreteValue.Value = ListaSuma[2];
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["marzo"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            //
            crParameterDiscreteValue.Value = ListaSuma[3];
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["abril"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            //
            crParameterDiscreteValue.Value = ListaSuma[4];
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["mayo"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            //
            crParameterDiscreteValue.Value = ListaSuma[5];
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["junio"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            //
            crParameterDiscreteValue.Value = ListaSuma[6];
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["julio"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            //
            crParameterDiscreteValue.Value = ListaSuma[7];
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["agosto"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            //
            crParameterDiscreteValue.Value = ListaSuma[8];
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["septiembre"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            //
            crParameterDiscreteValue.Value = ListaSuma[9];
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["octubre"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            //
            crParameterDiscreteValue.Value = ListaSuma[10];
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["noviembre"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            //
            crParameterDiscreteValue.Value = ListaSuma[11];
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["diciembre"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);





            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
          
        }
    }
}
