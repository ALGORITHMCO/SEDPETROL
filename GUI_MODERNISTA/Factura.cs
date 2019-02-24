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
        public Factura()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crystalReportViewer1.Refresh();
            //int[] ListaSuma = {0,0,0,0,0,0,0,0,0,0,0,0,0};
            // int mesBase, suma;
            //string inicio = year.Text + "-" + monthStart.Text + "-" + "01";
            //int mes = Convert.ToInt32(monthEnd.Text);
            //int anio = Convert.ToInt32(year.Text);
            //mes += 1;
            //if (mes == 13)
            //{
            //    mes = 1;
            //    anio += 1;
            //}
            //string fin = anio.ToString() + "-0" + mes.ToString() + "-01";

            

                        
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\Users\cesar77muse\Desktop\sedpetrol\SEDPETROL\GUI_MODERNISTA\CrystalReport1.rpt");  // direccion del reporte

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            //using (SqlConnection cone = conexion.conectarbd())
            //{
            //    SqlCommand consul = new SqlCommand(String.Format("SELECT SUM ([VOLUMENM3]), DATEPART (MONTH, FECHA) FROM [dbo].[VARIABLES]WHERE[CUENTA_CONTRATO] ='" + contrato.Text + "'and[FECHA] >= '" + inicio + "'AND[FECHA] <' " + fin + "'GROUP BY DATEPART(MONTH, FECHA)"), cone);
            //    SqlDataReader reader = consul.ExecuteReader();


            //    while (reader.Read())
            //    {
            //        suma = reader.GetInt32(0);
            //        mesBase = reader.GetInt32(1);
            //        switch (mesBase)
            //        {
            //            case 1:
            //                ListaSuma[0] = suma;
            //                break;
            //            case 2:
            //                ListaSuma[1] = suma;
            //                break;
            //            case 3:
            //                ListaSuma[2] = suma;
            //                break;
            //            case 4:
            //                ListaSuma[3] = suma;
            //                break;
            //            case 5:
            //                ListaSuma[4] = suma;
            //                break;
            //            case 6:
            //                ListaSuma[5] = suma;
            //                break;
            //            case 7:
            //                ListaSuma[6] = suma;
            //                break;
            //            case 8:
            //                ListaSuma[7] = suma;
            //                break;
            //            case 9:
            //                ListaSuma[8] = suma;
            //                break;
            //            case 10:
            //                ListaSuma[9] = suma;
            //                break;
            //            case 11:
            //                ListaSuma[10] = suma;
            //                break;
            //            case 12:
            //                ListaSuma[11] = suma;
            //                break;
            //            default:
            //                ListaSuma[12] = 0;
            //                break;

            //        }

            //    }

            //    conexion.cerrarbd();

            //}

            crParameterDiscreteValue.Value = contrato.Text;
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["ProductName"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            //crParameterDiscreteValue.Value = ListaSuma[0];
            //crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            //crParameterFieldDefinition = crParameterFieldDefinitions["enero"];
            //crParameterValues.Add(crParameterDiscreteValue);
            //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            //////
            //crParameterDiscreteValue.Value = ListaSuma[1];
            //crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            //crParameterFieldDefinition = crParameterFieldDefinitions["febrero"];
            //crParameterValues.Add(crParameterDiscreteValue);
            //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            //////
            //crParameterDiscreteValue.Value = ListaSuma[2];
            //crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            //crParameterFieldDefinition = crParameterFieldDefinitions["marzo"];
            //crParameterValues.Add(crParameterDiscreteValue);
            //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            ////
            //crParameterDiscreteValue.Value = ListaSuma[3];
            //crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            //crParameterFieldDefinition = crParameterFieldDefinitions["abril"];
            //crParameterValues.Add(crParameterDiscreteValue);
            //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);





            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }
    }
}
