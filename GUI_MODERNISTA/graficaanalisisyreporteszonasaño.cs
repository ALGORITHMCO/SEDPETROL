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
    public partial class graficaanalisisyreporteszonasaño : UserControl
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
        public graficaanalisisyreporteszonasaño()
        {
            InitializeComponent();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

            Consultareportesyanalisis datos = new Consultareportesyanalisis();
            datos.FechaInicio = fechainicio;
            datos.FechaFin = fechafin;
            datos.variableaconsultar = variable;
            datos.departamento = departamento;
            datos.ciudad = ciudad;
            datos.zona = zona;
            datos.localidad = localidad;
            datos.barrio = barrio;
            datos.ID_MEDIDOR = idmedidor;

            List<analisisyreportesID> Lista = new List<analisisyreportesID>();
            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando = new SqlCommand();
                if (datos.variableaconsultar == "VOLUMENM3")
                {

                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona != "")
                    {
                        if (datos.barrio == "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);
                        }
                        if (datos.barrio != "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);
                        }
                        if (datos.barrio != "" && datos.localidad != "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' AND t2.BARRIO = '" + datos.barrio + "' AND DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);
                        }
                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                             "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                             "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                              "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  AND t2.ZONA = '" + datos.zona + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                         "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                           "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                          "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                }
                else
                {
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona != "")
                    {
                        if (datos.barrio == "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);
                        }
                        if (datos.barrio != "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);
                        }
                        if (datos.barrio != "" && datos.localidad != "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' AND t2.BARRIO = '" + datos.barrio + "' AND DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);
                        }
                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                             "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                             "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                              "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  AND t2.ZONA = '" + datos.zona + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                         "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                           "SELECT SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                          "SELECT SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA) order by 2 ASC"), conexi);

                    }
                }
                SqlDataReader reader = comando.ExecuteReader();

                int con = 0;
                double VARIA = 0.0;
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
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Fecha";
                int vaanterior = 0;
                while (reader.Read())
                {

                    if (datos.variableaconsultar == "VOLUMENM3")
                    {
                        VARIA = Convert.ToDouble(reader.GetInt32(0) );
                    }
                    else
                    {
                        VARIA = Convert.ToDouble(reader.GetInt32(0));
                    }
                    vaanterior = reader.GetInt32(0);

                    chart1.Series[0].Points.AddXY(con, VARIA);

                    chart1.Series["Series1"].Points[con].AxisLabel = Convert.ToString(reader.GetInt32(1));
                    con++;

                }
                conexion.cerrarbd();

            }




        }
    }
}
