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
    public partial class graficaanalisisyreporteszonas : UserControl
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
        public graficaanalisisyreporteszonas()
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

            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando = new SqlCommand();
                if (datos.ciudad != "" && datos.departamento != "" && datos.zona != "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT t1.ID_VARIABLES,t1.ID_CONTROL, t1.ID_MEDIDOR, t1.FECHA, t1.HORA, t1." + datos.variableaconsultar + ", t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.ESTRATO  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t1.FECHA >= '" + datos.FechaInicio + "' and t1.FECHA <= '" + datos.FechaFin + "'"), conexi);
                }
                if (datos.ciudad != "" && datos.departamento == "" && datos.zona == "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT t1.ID_VARIABLES,t1.ID_CONTROL, t1.ID_MEDIDOR, t1.FECHA, t1.HORA, t1." + datos.variableaconsultar + ", t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.ESTRATO  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO ='" + datos.ciudad + "' AND t1.FECHA >= '" + datos.FechaInicio + "' and t1.FECHA <= '" + datos.FechaFin + "'"), conexi);
                }
                if (datos.ciudad == "" && datos.departamento != "" && datos.zona == "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT t1.ID_VARIABLES,t1.ID_CONTROL, t1.ID_MEDIDOR, t1.FECHA, t1.HORA, t1." + datos.variableaconsultar + ", t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.ESTRATO  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t1.FECHA >= '" + datos.FechaInicio + "' and t1.FECHA <= '" + datos.FechaFin + "'"), conexi);
                }
                if (datos.ciudad == "" && datos.departamento == "" && datos.zona != "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT t1.ID_VARIABLES,t1.ID_CONTROL, t1.ID_MEDIDOR, t1.FECHA, t1.HORA, t1." + datos.variableaconsultar + ", t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.ESTRATO  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "' and t1.FECHA <= '" + datos.FechaFin + "'"), conexi);
                }
                if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT t1.ID_VARIABLES,t1.ID_CONTROL, t1.ID_MEDIDOR, t1.FECHA, t1.HORA, t1." + datos.variableaconsultar + ", t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.ESTRATO  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "' and t1.FECHA <= '" + datos.FechaFin + "'"), conexi);
                }
                if (datos.ciudad == "" && datos.departamento != "" && datos.zona != "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT t1.ID_VARIABLES,t1.ID_CONTROL, t1.ID_MEDIDOR, t1.FECHA, t1.HORA, t1." + datos.variableaconsultar + ", t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.ESTRATO  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "' and t1.FECHA <= '" + datos.FechaFin + "'"), conexi);
                }
                if (datos.ciudad != "" && datos.departamento == "" && datos.zona != "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT t1.ID_VARIABLES,t1.ID_CONTROL, t1.ID_MEDIDOR, t1.FECHA, t1.HORA, t1." + datos.variableaconsultar + ", t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.ESTRATO  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO = '" + datos.ciudad + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "' and t1.FECHA <= '" + datos.FechaFin + "'"), conexi);
                }
                if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT t1.ID_VARIABLES,t1.ID_CONTROL, t1.ID_MEDIDOR, t1.FECHA, t1.HORA, t1." + datos.variableaconsultar + ", t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.ESTRATO  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO = '" + datos.ciudad + "' AND t2.DEPARTAMENTO = '" + datos.departamento + "' AND t1.FECHA >= '" + datos.FechaInicio + "' and t1.FECHA <= '" + datos.FechaFin + "'"), conexi);
                }
                SqlDataReader reader = comando.ExecuteReader();

                int con = 0;
                double VARIA = 0.0;

                
                chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                while (reader.Read())
                {
                    con++;
                    VARIA = Convert.ToDouble(reader.GetString(5));


                    chart1.Series[0].Points.AddXY(con, VARIA);

                }
                conexion.cerrarbd();

            }




        }
    }
}
