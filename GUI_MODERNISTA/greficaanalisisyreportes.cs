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
    public partial class graficaanalisisyreportes : UserControl
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
        public graficaanalisisyreportes()
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

                SqlCommand comando = new SqlCommand(string.Format(
                    "SELECT  "+variable+" FROM  VARIABLES   WHERE ID_MEDIDOR = '" + datos.ID_MEDIDOR+ "' AND FECHA >= '" + datos.FechaInicio + "' and FECHA <= '" + datos.FechaFin + "'"), conexi);

                SqlDataReader reader = comando.ExecuteReader();

                int con = 0;
                double VARIA = 0.0;


                while (reader.Read())
                {
                    con++;
                    VARIA = Convert.ToDouble(reader.GetString(0));


                    chart1.Series[0].Points.AddXY(con, VARIA);


                }
                conexion.cerrarbd();
                
            }




        }
    }
}
