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
namespace GUI_MODERNISTA
{
    public partial class formFactura : Form
    {
        public formFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // C:\Users\cesar77muse\Documents\FATURA\CrystalProjectVS2010\CrystalReport1.rpt
            ReportDocument crystalrpt = new ReportDocument();
            crystalrpt.Load(@"C:\CrystalReport1.rpt");  // direccion del reporte

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
            crParameterDiscreteValue.Value = textBox1.Text;
            crParameterFieldDefinitions = crystalrpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["ProductName"];

            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);


            crystalReportViewer1.ReportSource = crystalrpt;
            crystalReportViewer1.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
