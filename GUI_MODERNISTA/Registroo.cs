using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUI_MODERNISTA
{
    class Registroo
    {

        public static int agregar(DatosRegis datos)
        {
            int retorno = 0;
            int retorno1 = 0;

            using (SqlConnection cone = conexion.conectarbd())
            {

                SqlCommand consul = new SqlCommand(String.Format("SELECT * FROM Usuarios WHERE usuario ='" + datos.usuario + "'OR correo ='" + datos.correo + "'"), cone);
                SqlDataReader dr = consul.ExecuteReader();

                if (dr.Read())
                {
                    return retorno = -1;
                }
                else
                {
                    using (SqlConnection conee = conexion.conectarbd())
                    {
                        SqlCommand comando = new SqlCommand(String.Format("Insert into Usuarios (usuario, nombre, contraseña, correo) values ('{0}', '{1}', '{2}', '{3}')",
                         datos.usuario, datos.nombre, datos.contraseña, datos.correo), conee);
                        return retorno1 = comando.ExecuteNonQuery();
                    }
                }

            }

            

        }


        public static List<Medidor> Buscar(String pcuenta)
        {

            List<Medidor> Lista = new List<Medidor>();
            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select ID_MEDIDOR, ID_PREDIO,  CUENTA_CONTRATO, NU_MEDIDOR, TIPO, MARCA, ULTIMA_LECTURA, LECTURA_ANTERIOR, CONSUMOM3 from MEDIDOR where CUENTA_CONTRATO ='" + pcuenta + "'"), conexi);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Medidor pmedidor = new Medidor();
                    pmedidor.ID_MEDIDOR = Convert.ToString(reader.GetInt32(0));
                    pmedidor.ID_PREDIO = Convert.ToString(reader.GetInt32(1));
                    pmedidor.CUENTA_CONTRATO = reader.GetString(2);
                    pmedidor.NU_MEDIDOR = reader.GetString(3);
                    pmedidor.TIPO = reader.GetString(4);
                    pmedidor.MARCA= reader.GetString(5);
                    pmedidor.ULTIMA_LECTURA = reader.GetString(6);
                    pmedidor.LECTURA_ANTERIOR = reader.GetString(7);
                    pmedidor.CONSUMOM3= reader.GetString(8);

                    Lista.Add(pmedidor);

                    ConsultaAlimentacion.ID_MEDIDOR = reader.GetInt32(0);
                    ConsultaFacturaPropietario.ID_MEDIDOR = reader.GetInt32(0);

                }
                conexion.cerrarbd();
                return Lista;

            }

        }


        public static List<AlimentacionHistorica> Buscaralimentacionhis (int pidmedidor)
        {

            List<AlimentacionHistorica> Lista = new List<AlimentacionHistorica>();
            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select ID_INFENTRADA, ID_MEDIDOR, REVISIONES_INTERNAS, CORTES_SERVICIO,RECONEXION, DEFRAUDACION_FLUIDOS, RECLAMACIONES, CAMBIO_USO from ALIMENTACION_HISTORICA where ID_MEDIDOR ='" + pidmedidor + "'"), conexi);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    AlimentacionHistorica palimentacion = new AlimentacionHistorica();
                    palimentacion.ID_INFENTRADA= Convert.ToString(reader.GetInt32(0));
                    palimentacion.ID_MEDIDOR = Convert.ToString(reader.GetInt32(1)); 
                    palimentacion.REVISIONES_INTERNAS = reader.GetString(2);
                    palimentacion.CORTES_SERVICIO = reader.GetString(3);
                    palimentacion.RECONEXION= reader.GetString(4);
                    palimentacion.DEFRAUDACION_FLUIDOS= reader.GetString(5);
                    palimentacion.RECLAMACIONES = reader.GetString(6);
                    palimentacion.CAMBIO_DE_USO = reader.GetString(7);

                    Lista.Add(palimentacion);

                }
                conexion.cerrarbd();
                return Lista;

            }

        }



        public static List<FacturaPropietario> BuscarFacturaPropietario(int pidmedidor)
        {

            List<FacturaPropietario> Lista = new List<FacturaPropietario>();
            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando = new SqlCommand(string.Format("SELECT t1.ID_FACTURAS,t1.ID_MEDIDOR, t1.EMPRESA, t1.FACTURA_SP_NO, t1.CONSUMOM3, t1.PERIODO1, t1.PERIODO2,t1.PERIODO3 , t1.PERIODO4 , t1.PERIODO5 , t1.PERIODO6  , t1.CONSUMO_PROMEDIO , t1.PERIODO_A_FACTURAR  , t1.FACTURADO_CON , t1.DESCARGUE_FUENTE, t1.TOTAL_A_PAGAR , t1.FECHA_PAGO_OPORUNO, t1.FECHA_LIMITE_PAGO  , t2.ID_PROPIETARIO, t2.TIPO_IDENTIFICACION, t2.NU_IDENTIFICACION, t2.NOMBRE_PROPIETARIO, t2.PORC_PROPIEDAD, t2.CALIDAD_PROPIETARIO  FROM PROPIETARIO t2 inner join PREDIO P on t2.ID_PROPIETARIO = P.ID_PROPIETARIO inner join MEDIDOR M on P.ID_PREDIO = M.ID_PREDIO inner join FACTURAS t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE M.ID_MEDIDOR = '" + pidmedidor + "'"), conexi);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    FacturaPropietario pfactura = new FacturaPropietario();
                    pfactura.ID_FACTURAS = Convert.ToString(reader.GetInt32(0));
                    pfactura.ID_MEDIDOR = Convert.ToString(reader.GetInt32(1));
                    pfactura.EMPRESA = reader.GetString(2);
                    pfactura.FACTURA_SP_NO = reader.GetString(3);
                    pfactura.CONSUMOM3 = reader.GetString(4);
                    pfactura.PERIODO1 = reader.GetString(5);
                    pfactura.PERIODO2= reader.GetString(6);
                    pfactura.PERIODO3 = reader.GetString(7);
                    pfactura.PERIODO4 = reader.GetString(8);
                    pfactura.PERIODO5 = reader.GetString(9);
                    pfactura.PERIODO6 = reader.GetString(10);
                    pfactura.CONSUMO_PROMEDIO = reader.GetString(11);
                    pfactura.PERIODO_A_FACTURAR = reader.GetString(12);
                    pfactura.FACTURADO_CON = reader.GetString(13);
                    pfactura.DESCARGUE_FUENTE = reader.GetString(14);
                    pfactura.TOTAL_A_PAGAR = reader.GetString(15);
                    pfactura.FECHA_PAGO_OPORTUNO = reader.GetString(16);
                    pfactura.FECHA_LIMITE_PAGO = reader.GetString(17);

                    pfactura.ID_PROPIETARIO= Convert.ToString(reader.GetInt32(18));
                    pfactura.TIPO_IDENTIFICACION = reader.GetString(19);
                    pfactura.NU_IDENTIFICACION= reader.GetString(20);
                    pfactura.NOMBRE_PROPIETARIO= reader.GetString(21);
                    pfactura.PORC_PROPIEDAD = reader.GetString(22);
                    pfactura.CALIDAD_PROPIETARIO = reader.GetString(23);

                    Lista.Add(pfactura);

                }
                conexion.cerrarbd();
                return Lista;

            }
        }


        public static List<AlimentacionHistorica> analisisyreportes (Consultareportesyanalisis datos)
        {

            List<AlimentacionHistorica> Lista = new List<AlimentacionHistorica>();
            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select ID_MEDIDOR, FECHA, HORA, " + datos.variableaconsultar + " from VARIABLES where ID_MEDIDOR ='" + datos.ID_MEDIDOR + "'"), conexi);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    AlimentacionHistorica palimentacion = new AlimentacionHistorica();
                    palimentacion.ID_INFENTRADA = Convert.ToString(reader.GetInt32(0));
                    palimentacion.ID_MEDIDOR = reader.GetString(1);
                    palimentacion.REVISIONES_INTERNAS = reader.GetString(2);
                    palimentacion.CORTES_SERVICIO = reader.GetString(3);


                    Lista.Add(palimentacion);

                }
                conexion.cerrarbd();
                return Lista;

            }

        }
    }
}
