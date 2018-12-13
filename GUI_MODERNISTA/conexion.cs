using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUI_MODERNISTA
{
    class conexion
    {
        public static SqlConnection conectarbd()
        {
            SqlConnection cone = new SqlConnection("Server=tcp:valvulasdb.database.windows.net,1433;Initial Catalog=DBdatosvalvulas;Persist Security Info=False;User ID=cinnovacion;Password=SolraC28;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            cone.Open();
            return cone;
        }
        public static SqlConnection cerrarbd()
        {
            SqlConnection cone = new SqlConnection("Data Source=DESKTOP-AGAM516\\MSSQLSERVER01;Initial Catalog=Prueba; Integrated Security=true");
            cone.Close();
            return cone;
        }
    }
}
