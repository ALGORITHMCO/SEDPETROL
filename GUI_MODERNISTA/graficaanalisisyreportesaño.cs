using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_MODERNISTA
{
    public partial class graficaanalisisyreportesaño : UserControl
    {
        public String fechainicio;
        public String fechafin;
        public String variable;
        public String departamento;
        public String ciudad;
        public String zona;
        public String localidad;
        public String barrio;
        public String idmedidor;

        Panel panel;
        public graficaanalisisyreportesaño()
        {
            InitializeComponent();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

            Consultareportesyanalisis datos = new Consultareportesyanalisis();
            datos.FechaInicio = Convert.ToString(fechainicio);
            datos.FechaFin = Convert.ToString(fechafin);
            datos.variableaconsultar = variable;
            datos.departamento = departamento;
            datos.ciudad = ciudad;
            datos.zona = zona;
            datos.localidad = localidad;
            datos.barrio = barrio;
            datos.ID_MEDIDOR = idmedidor;



            using (SqlConnection conexi = conexion.conectarbd())
            {

                SqlCommand comando = new SqlCommand(string.Format(
                    "SELECT SUM(VARIABLES." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, VARIABLES.FECHA) FROM VARIABLES WHERE  VARIABLES.ID_MEDIDOR= " + datos.ID_MEDIDOR+ " AND DATEPART (YEAR, VARIABLES.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, VARIABLES.FECHA)<= " + datos.FechaFin + "   GROUP BY DATEPART (YEAR, VARIABLES.FECHA)"), conexi);
                SqlDataReader reader = comando.ExecuteReader();
                int con = 0;
                double VARIA = 0.0;
                string dia = "";


                if (datos.variableaconsultar == "VOLUMENM3")
                {
                    chart1.Series[0].LegendText = "M3";
                }
                if (datos.variableaconsultar == "PRESION_PSI")
                {
                    chart1.Series[0].LegendText = "PSI";
                }
                if (datos.variableaconsultar == "FLUJO_LT_MIN")
                {
                    chart1.Series[0].LegendText = "LT/MIN";
                }
                chart1.ChartAreas["ChartArea1"].AxisY.Title = datos.variableaconsultar;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "FECHA";

                while (reader.Read())
                {

                    VARIA = Convert.ToDouble(reader.GetInt32(0)) + VARIA;
                    chart1.Series[0].Points.AddXY(con, VARIA);
                    chart1.Series[0].Points[con].AxisLabel = Convert.ToString(reader.GetInt32(1));
                    
                    con++;

                }


                conexion.cerrarbd();

            }




        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
