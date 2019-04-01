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

        public static int login(DatosRegis datos)
        {
            int retorno = 0;
            int retorno1 = 0;

            using (SqlConnection cone = conexion.conectarbd())
            {

                SqlCommand consul = new SqlCommand(String.Format("SELECT * FROM Usuarios WHERE usuario ='" + datos.usuario + "'OR contraseña ='" + datos.contraseña + "'"), cone);
                SqlDataReader dr = consul.ExecuteReader();

                if (dr.Read())
                {
                    return retorno = 1;
                }
                else
                {
                    return retorno = -1;
                }
                

            }
            



        }
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

        public static int agregarN(AgregarNovedades novedades)
        {
            int retorno = 0;
            int retorno1 = 0;
            novedades.idnovedad = 1;
            using (SqlConnection cone = conexion.conectarbd())
            {
                SqlCommand consul = new SqlCommand(String.Format("SELECT * FROM ALIMENTACION_HISTORICA WHERE ID_INFENTRADA ='" + novedades.idnovedad + "'"), cone);
                SqlDataReader dr = consul.ExecuteReader();

                if (dr.Read())
                {
                    return retorno = -1;
                }
                else
                {
                    using (SqlConnection conee = conexion.conectarbd())
                    {
                        //SqlCommand comando = new SqlCommand(String.Format("Insert into ALIMENTACION_HISTORICA (ID_INFENTRADA, ID_MEDIDOR, REVISIONES_INTERNAS, CORTES_SERVICIO, RECONEXION, DEFRAUDACION_FLUIDOS, RECLAMACIONES, VIOLACIONES, AUTO_PROTECCION, EVALUACION_PROMEDIOS, INGRESO_DATOS_1VEZ, CAMPO1, CAMPO2, CAMPO3, CAMPO4, CAMPO5) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}')",
                        //novedades.idnovedad, novedades.idmedidor, novedades.revisionesinternas, novedades.cortes, novedades.reconexiones, novedades.fraudefluidos, novedades.reclamaciones, novedades.violaciones, novedades.autoproteccion,novedades.evaluaciondepromedios, novedades.ingresodatosprimeravez,novedades.campo1, novedades.campo2, novedades.campo3, novedades.campo4, novedades.campo5), conee);

                        SqlCommand comando = new SqlCommand(String.Format("Insert into ALIMENTACION_HISTORICA (ID_MEDIDOR,FECHA_INGRESO_NOVEDAD, HORA_INGRESO_NOVEDAD, REVISIONES_INTERNAS, CORTES_SERVICIO, RECONEXION, DEFRAUDACION_FLUIDOS, VIOLACIONES, AUTO_PROTECCION, EVALUACION_PROMEDIOS, INGRESO_DATOS_1VEZ, CAMPO1, CAMPO2, CAMPO3, CAMPO4, CAMPO5) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}')",
                        novedades.idmedidor,novedades.fechaingreso, novedades.horaingresonovedad, novedades.revisionesinternas, novedades.cortes, novedades.reconexiones, novedades.fraudefluidos, novedades.violaciones, novedades.autoproteccion,novedades.evaluaciondepromedios, novedades.ingresodatosprimeravez,novedades.campo1, novedades.campo2, novedades.campo3, novedades.campo4, novedades.campo5), conee);

                        //SqlCommand comando = new SqlCommand(String.Format("Insert into ALIMENTACION_HISTORICA (ID_MEDIDOR,REVISIONES_INTERNAS, CORTES_SERVICIO, RECONEXION) values ('{0}', '{1}', '{2}', '{3}')",
                        // novedades.fechaingreso, novedades.horaingresonovedad, novedades.idmedidor, novedades.departamento), conee);
                        return retorno1 = comando.ExecuteNonQuery();
                    }
                }
            }
        }

        public static int agregarPQRS(AgregarPQRS PQRS)
        {
            int retorno = 0;
            int retorno1 = 0;

            using (SqlConnection cone = conexion.conectarbd())
            {
                SqlCommand consul = new SqlCommand(String.Format("SELECT * FROM PQRS WHERE ID_PQRS ='" + PQRS.idPQRS + "'"), cone);
                SqlDataReader dr = consul.ExecuteReader();

                if (dr.Read())
                {
                    return retorno = -1;
                }
                else
                {
                    using (SqlConnection conee = conexion.conectarbd())
                    {
                        //SqlCommand comando = new SqlCommand(String.Format("Insert into ALIMENTACION_HISTORICA (ID_INFENTRADA, ID_MEDIDOR, REVISIONES_INTERNAS, CORTES_SERVICIO, RECONEXION, DEFRAUDACION_FLUIDOS, RECLAMACIONES, VIOLACIONES, AUTO_PROTECCION, EVALUACION_PROMEDIOS, INGRESO_DATOS_1VEZ, CAMPO1, CAMPO2, CAMPO3, CAMPO4, CAMPO5) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}')",
                        //novedades.idnovedad, novedades.idmedidor, novedades.revisionesinternas, novedades.cortes, novedades.reconexiones, novedades.fraudefluidos, novedades.reclamaciones, novedades.violaciones, novedades.autoproteccion,novedades.evaluaciondepromedios, novedades.ingresodatosprimeravez,novedades.campo1, novedades.campo2, novedades.campo3, novedades.campo4, novedades.campo5), conee);

                        SqlCommand comando = new SqlCommand(String.Format("Insert into PQRS (ID_MEDIDOR, FECHA_INGRESO_PQRS, HORA_INGRESO_PQRS,NOMBRE_PETICIONARIO,IDENTIFICACION, DIRECCION, TELEFONO_FIJO, CELULAR, CORREO_ELECTRONICO,DESCRIPCION_PQRS, TIPOS_DE_SOLICITUD, CONSULTA_ESTADO_PQRS, DANO_PRESENTADO_EN, CAMPO1, CAMPO2, CAMPO3, CAMPO4, CAMPO5) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}')",
                        PQRS.idmedidor, PQRS.fechaingreso,PQRS.nombrepeticionario, PQRS.identificacion, PQRS.direccion, PQRS.telefonofijo, PQRS.celular, PQRS.correoelectronico, PQRS.horaingreso, PQRS.descripciónPQRS, PQRS.tipodesolicitud, PQRS.consultaestadoPQRS, PQRS.dañopresentado, PQRS.campo1, PQRS.campo2, PQRS.campo3, PQRS.campo4, PQRS.campo5), conee);

                        //SqlCommand comando = new SqlCommand(String.Format("Insert into ALIMENTACION_HISTORICA (ID_MEDIDOR,REVISIONES_INTERNAS, CORTES_SERVICIO, RECONEXION) values ('{0}', '{1}', '{2}', '{3}')",
                        // novedades.fechaingreso, novedades.horaingresonovedad, novedades.idmedidor, novedades.departamento), conee);
                        return retorno1 = comando.ExecuteNonQuery();
                        
                    }
                }
                
            }
        }

        public static int ingresarPredio(IngresoDatosMedidor medidor)
        {
            int retorno = 0;


            using (SqlConnection cone = conexion.conectarbd())
            {
                SqlCommand consul = new SqlCommand(String.Format("SELECT * FROM MEDIDOR WHERE ID_MEDIDOR ='" + medidor.idmedidor + "'"), cone);
                SqlDataReader dr = consul.ExecuteReader();

                if (dr.Read())
                {
                    return retorno = -1;

                }
                else
                {
                    using (SqlConnection conee = conexion.conectarbd())
                    {

                        SqlCommand comando = new SqlCommand(String.Format("Insert into PREDIO (ID_PROPIETARIO, ID_CHIP, MATRICULA_INMOBILIARIA, DIRECCION, DEPARTAMENTO, MUNICIPIO, LOCALIDAD, BARRIO, ESTRATO, CLASE_USO, UNID_HAB_FAMILIAS, UNID_NOHAB_FAMILIAS, ZONA, CICLO, RUTA) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}')",
                        medidor.idpropietario, medidor.idchip, medidor.matriculainmobiliaria, medidor.direccion, medidor.departamento, medidor.municipio, medidor.localidad, medidor.barrio, medidor.estrato, medidor.claseuso, medidor.unidadhabitacional, medidor.unidadnohabitacional, medidor.zona, medidor.ciclo, medidor.ruta), conee);
                        conexion.cerrarbd();
                        return retorno = comando.ExecuteNonQuery();
                        
                    }
                    

                }

                

            }
        }



        public static int ingresarMedidor(IngresoDatosMedidor medidor)
        {
            int retorno = 0;
            
   
            using (SqlConnection cone = conexion.conectarbd())
            {
                SqlCommand consul = new SqlCommand(String.Format("SELECT * FROM MEDIDOR WHERE ID_MEDIDOR ='" + medidor.idmedidor + "'"), cone);
                SqlDataReader dr = consul.ExecuteReader();

                if (dr.Read())
                {
                    return retorno = -1;
                    
                }
                else
                {
                    using (SqlConnection conee = conexion.conectarbd())
                    {

                        //SqlCommand comando = new SqlCommand(String.Format("Insert into PREDIO (ID_PROPIETARIO, ID_CHIP, MATRICULA_INMOBILIARIA, DIRECCION, DEPARTAMENTO, MUNICIPIO, LOCALIDAD, BARRIO, ESTRATO, CLASE_USO, UNID_HAB_FAMILIAS, UNID_NOHAB_FAMILIAS, ZONA, CICLO, RUTA) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}')",
                        //medidor.idpropietario, medidor.idchip, medidor.matriculainmobiliaria, medidor.direccion, medidor.departamento, medidor.municipio, medidor.localidad, medidor.barrio, medidor.estrato, medidor.claseuso, medidor.unidadhabitacional, medidor.unidadnohabitacional, medidor.zona, medidor.ciclo, medidor.ruta), conee);

                        SqlCommand comando = new SqlCommand(String.Format("Insert into MEDIDOR (ID_PREDIO, CUENTA_CONTRATO, NU_MEDIDOR, MARCA, TIPO, ULTIMA_LECTURA, LECTURA_ANTERIOR, CONSUMOM3, DIAMETRO, CAMPO1, CAMPO2, CAMPO3, CAMPO4, CAMPO5) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}')",
                        medidor.idpredio, medidor.cuentacontrato, medidor.numeromedidor, medidor.marca, medidor.tipo, medidor.ultimalectura, medidor.lecturaanterior, medidor.consumom3, medidor.diametro, medidor.campo1, medidor.campo2, medidor.campo3, medidor.campo4, medidor.campo5), conee);

                        conexion.cerrarbd();

                        return retorno = comando.ExecuteNonQuery();
                    }
                    


                }
                
            }
          
        }


        public static int ingresarPropietario(IngresoDatosPropietario propietario)
        {
            int retorno = 0;


            using (SqlConnection cone = conexion.conectarbd())
            {
                SqlCommand consul = new SqlCommand(String.Format("SELECT * FROM PROPIETARIO WHERE ID_PROPIETARIO ='" + propietario.idpropietario + "'"), cone);
                SqlDataReader dr = consul.ExecuteReader();

                if (dr.Read())
                {
                    return retorno = -1;

                }
                else
                {
                    using (SqlConnection conee = conexion.conectarbd())
                    {

                        
                        SqlCommand comando = new SqlCommand(String.Format("Insert into PROPIETARIO (TIPO_IDENTIFICACION, NU_IDENTIFICACION, NOMBRE_PROPIETARIO, PORC_PROPIEDAD, CALIDAD_PROPIETARIO, CUENTA_CONTRATO, ESTADO, CAMPO1, CAMPO2, CAMPO3, CAMPO4, CAMPO5) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}','{10}','{11}')",
                        propietario.tipoidentificacion, propietario.numeroidentificacion, propietario.nombrepropietario, propietario.porcentajepropiedad, propietario.calidadpropietario, propietario.cuentacontrato, propietario.estado, propietario.campo1, propietario.campo2, propietario.campo3, propietario.campo4, propietario.campo5), conee);

                        conexion.cerrarbd();

                        return retorno = comando.ExecuteNonQuery();
                    }



                }

            }

        }


        public static int ingresarCA(IngresoConsumosAnteriores consumos)
        {
            int retorno = 0;
            

            using (SqlConnection cone = conexion.conectarbd())
            {
                SqlCommand consul = new SqlCommand(String.Format("SELECT * FROM FACTURAS WHERE ID_FACTURAS ='" + consumos.idfactura+ "'"), cone);
                SqlDataReader dr = consul.ExecuteReader();

                if (dr.Read())
                {
                    return retorno = -1;
                }
                else
                {
                    using (SqlConnection conee = conexion.conectarbd())
                    {

                        SqlCommand comando = new SqlCommand(String.Format("Insert into FACTURAS (ID_MEDIDOR, EMPRESA, FACTURA_SP_NO, CONSUMOM3, PERIODO1, PERIODO2, PERIODO3, PERIODO4, PERIODO5, PERIODO6, CONSUMO_PROMEDIO, PERIODO_A_FACTURAR, FACTURADO_CON, DESCARGUE_FUENTE, TOTAL_A_PAGAR, FECHA_PAGO_OPORTUNO, FECHA_LIMITE_PAGO, CUENTA_CONTRATO) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')",
                        consumos.idmedidor, consumos.empresa, consumos.facturaspno, consumos.consumom3, consumos.periodo1, consumos.periodo2, consumos.periodo3, consumos.periodo4, consumos.periodo5, consumos.periodo6, consumos.consumopromedio, consumos.periodoafacturar, consumos.facturadocon, consumos.descarguefuente, consumos.totalapagar, consumos.fechalimitepago, consumos.fechapagoportuno, consumos.cuentacontrato), conee);
                        conexion.cerrarbd();
                        return retorno = comando.ExecuteNonQuery();
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


        public static List<analisisyreportesID> analisisyreportes(Consultareportesyanalisis datos)
        {

            List<analisisyreportesID> Lista = new List<analisisyreportesID>();
            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando;
                if (datos.variableaconsultar == "VOLUMENM3")
                {
                    comando = new SqlCommand(string.Format(
                       "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  M.NU_MEDIDOR = '" + datos.ID_MEDIDOR + "'  and FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                }
                else
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  M.NU_MEDIDOR = '" + datos.ID_MEDIDOR + "'  and FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                }
                SqlDataReader reader = comando.ExecuteReader();
                int fecha = -1;
                int vaanterior = 0; 
                while (reader.Read())
                {
                
                    analisisyreportesID palimentacion = new analisisyreportesID();
                    
                    palimentacion.FECHA = Convert.ToString(reader.GetInt32(3)) + "-" +Convert.ToString(reader.GetInt32(1))+ "-" + Convert.ToString(reader.GetInt32(2));

                    if (datos.variableaconsultar == "VOLUMENM3")
                    {
                        palimentacion.VARIABLE = Convert.ToString(reader.GetInt32(0));
                    }
                    else {
                        palimentacion.VARIABLE = Convert.ToString(reader.GetInt32(0));
                    }
                    vaanterior = reader.GetInt32(0); 
                    Lista.Add(palimentacion);
                    
                }
                conexion.cerrarbd();
                return Lista;

            }

        }

        public static List<analisisyreportesID> analisisyreporteszonas(Consultareportesyanalisis datos)
        {

            List<analisisyreportesID> Lista = new List<analisisyreportesID>();
            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando=new SqlCommand();
                if (datos.variableaconsultar == "VOLUMENM3")
                {
                    
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona != "")
                    {
                        if (datos.barrio == "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + "),DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' and t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                        }
                        if (datos.barrio != "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + "),DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' and t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                        }
                        if (datos.barrio != "" && datos.localidad != "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' AND t2.BARRIO = '" + datos.barrio + "' and t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                        }
                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO ='" + datos.ciudad + "' and t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                           "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.ZONA = '" + datos.zona + "' AND t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO = '" + datos.ciudad + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO = '" + datos.ciudad + "' AND t2.DEPARTAMENTO = '" + datos.departamento + "' AND t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }

                }
                else
                {
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona != "")
                    {
                        if (datos.barrio == "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*),DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' and t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                        }
                        if (datos.barrio != "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*),DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' and t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                        }
                        if (datos.barrio != "" && datos.localidad != "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' AND t2.BARRIO = '" + datos.barrio + "' and t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                        }
                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO ='" + datos.ciudad + "' and t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                           "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.ZONA = '" + datos.zona + "' AND t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO = '" + datos.ciudad + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO = '" + datos.ciudad + "' AND t2.DEPARTAMENTO = '" + datos.departamento + "' AND t1.FECHA BETWEEN '" + datos.FechaInicio + "' AND  '" + datos.FechaFin + "'GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA), DATEPART (DAY, t1.FECHA)"), conexi);

                    }
                }



                SqlDataReader reader = comando.ExecuteReader();
                int vaanterior=0; 
                while (reader.Read())
                {
                    analisisyreportesID palimentacion = new analisisyreportesID();
                    
                    palimentacion.FECHA = Convert.ToString(reader.GetInt32(3)) + "-" + Convert.ToString(reader.GetInt32(1)) + "-" + Convert.ToString(reader.GetInt32(2));

                    if (datos.variableaconsultar == "VOLUMENM3")
                    {
                        palimentacion.VARIABLE = Convert.ToString(reader.GetInt32(0) );
                    }
                    else
                    {
                        palimentacion.VARIABLE = Convert.ToString(reader.GetInt32(0));
                    }
                    vaanterior = reader.GetInt32(0);
                    Lista.Add(palimentacion);
                }
                conexion.cerrarbd();
                return Lista;

            }

        }

        public static List<String> vaconsultaDEPAR()
        {

            List<String> Lista = new List<String>();
            using (SqlConnection conexi = conexion.conectarbd())
            {

                SqlCommand comando = new SqlCommand(string.Format(
                    "Select DEPARTAMENTO from PREDIO GROUP BY DEPARTAMENTO"), conexi);

                SqlDataReader reader = comando.ExecuteReader();
                String DEPAR = "";
                while (reader.Read())
                {
                    if (reader.GetString(0) == DEPAR)
                    {

                    }
                    else
                    {
                        Lista.Add(reader.GetString(0));
                    }
                    DEPAR = reader.GetString(0);

                }
                conexion.cerrarbd();
                return Lista;

            }
        }


        public static List<String> vaconsultaMUNI(string depar)
        {

            List<String> Lista = new List<String>();
            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select MUNICIPIO from PREDIO WHERE DEPARTAMENTO = '" + depar + "' GROUP BY MUNICIPIO"), conexi);

                SqlDataReader reader = comando.ExecuteReader();
                String MUNI = "";

               
                while (reader.Read())
                {
                    if (reader.GetString(0) == MUNI)
                    {

                    }
                    else
                    {
                        Lista.Add(reader.GetString(0));
                    }
                    MUNI = reader.GetString(0);

                }

                Lista.Add("");

                conexion.cerrarbd();
                return Lista;
            }
        }


        public static List<String> vaconsultaZONA(string depar, string muni)
        {

            List<String> Lista = new List<String>();
            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select ZONA from PREDIO WHERE DEPARTAMENTO = '" + depar + "' AND MUNICIPIO = '" + muni + "' GROUP BY ZONA"), conexi);

                SqlDataReader reader = comando.ExecuteReader();
                String MUNI = "";
                while (reader.Read())
                {
                    if (reader.GetString(0) == MUNI)
                    {

                    }
                    else
                    {
                        Lista.Add(reader.GetString(0));
                    }
                    MUNI = reader.GetString(0);

                }

                Lista.Add("");

                conexion.cerrarbd();
                return Lista;
            }
        }

        public static List<String> vaconsultaLOCALIDAD(string depar, string muni, string zona)
        {

            List<String> Lista = new List<String>();
            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select LOCALIDAD from PREDIO WHERE DEPARTAMENTO = '" + depar + "' AND MUNICIPIO = '" + muni + "' AND ZONA= '"+zona+ "' GROUP BY LOCALIDAD"), conexi);

                SqlDataReader reader = comando.ExecuteReader();
                String MUNI = "";
                while (reader.Read())
                {
                    if (reader.GetString(0) == MUNI)
                    {

                    }
                    else
                    {
                        Lista.Add(reader.GetString(0));
                    }
                    MUNI = reader.GetString(0);

                }

                Lista.Add("");

                conexion.cerrarbd();
                return Lista;
            }
        }

        public static List<String> vaconsultaBARRIO(string depar, string muni, string zona, string localidad)
        {

            List<String> Lista = new List<String>();
            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select BARRIO from PREDIO WHERE DEPARTAMENTO = '" + depar + "' AND MUNICIPIO = '" + muni + "' AND ZONA= '" + zona + "' AND LOCALIDAD= '"+localidad+ "' GROUP BY BARRIO"), conexi);

                SqlDataReader reader = comando.ExecuteReader();
                String MUNI = "";
                while (reader.Read())
                {
                    if (reader.GetString(0) == MUNI)
                    {

                    }
                    else
                    {
                        Lista.Add(reader.GetString(0));
                    }
                    MUNI = reader.GetString(0);

                }


                Lista.Add("");

                conexion.cerrarbd();
                return Lista;
            }
        }


        public static List<String> vaconsultaIDMEDIDOR()
        {

            List<String> Lista = new List<String>();
            using (SqlConnection conexi = conexion.conectarbd())
            {

                SqlCommand comando = new SqlCommand(string.Format(
                    "Select ID_MEDIDOR from MEDIDOR"), conexi);

                SqlDataReader reader = comando.ExecuteReader();
                int DEPAR = -1;
                while (reader.Read())
                {
                    if (reader.GetInt32(0) == DEPAR)
                    {

                    }
                    else
                    {
                        Lista.Add(Convert.ToString(reader.GetInt32(0)));
                    }
                    DEPAR = reader.GetInt32(0);

                }
                
                conexion.cerrarbd();
                return Lista;

            }

        }


        public static List<analisisyreportesID> analisisyreportesMES(Consultareportesyanalisis datos)
        {

            List<analisisyreportesID> Lista = new List<analisisyreportesID>();
            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando;
                if (datos.variableaconsultar == "VOLUMENM3")
                {
                    comando = new SqlCommand(string.Format(
                    "SELECT ROUND(SUM(t1." + datos.variableaconsultar + "),2), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)   FROM VARIABLES t1 inner join MEDIDOR M on t1.ID_MEDIDOR = M.ID_MEDIDOR  WHERE M.NU_MEDIDOR = '" + datos.ID_MEDIDOR + "'  and FECHA >= '" + datos.FechaInicio + "-1' AND FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) order by DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                }
                else
                {
                    comando = new SqlCommand(string.Format(
                     "SELECT ROUND(SUM(t1." + datos.variableaconsultar + ")/count(*),2), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)  FROM VARIABLES t1 inner join MEDIDOR M on t1.ID_MEDIDOR = M.ID_MEDIDOR  WHERE M.NU_MEDIDOR = '" + datos.ID_MEDIDOR + "'  and FECHA >= '" + datos.FechaInicio + "-1' AND FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) order by DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                }

                SqlDataReader reader = comando.ExecuteReader();
                int fecha = -1;
                int vaanterior = 0; 
                while (reader.Read())
                {

                    analisisyreportesID palimentacion = new analisisyreportesID();
                    
                    palimentacion.FECHA = Convert.ToString(reader.GetInt32(2)) + "-" + Convert.ToString(reader.GetInt32(1));

                    if (datos.variableaconsultar == "VOLUMENM3")
                    {
                        palimentacion.VARIABLE = Convert.ToString(reader.GetInt32(0) );
                    }
                    else
                    {
                        palimentacion.VARIABLE = Convert.ToString(reader.GetInt32(0));
                    }
                    vaanterior = reader.GetInt32(0);
                    Lista.Add(palimentacion);


                }
                conexion.cerrarbd();
                return Lista;

            }

        }

        public static List<analisisyreportesID> analisisyreportesAÑO(Consultareportesyanalisis datos)
        {

            List<analisisyreportesID> Lista = new List<analisisyreportesID>();

           
            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando;
                if (datos.variableaconsultar == "VOLUMENM3")
                {
                   comando = new SqlCommand(string.Format(
                    "SELECT SUM(VARIABLES." + datos.variableaconsultar + "), DATEPART (YEAR, VARIABLES.FECHA) FROM VARIABLES  inner join MEDIDOR M on VARIABLES.ID_MEDIDOR = M.ID_MEDIDOR  WHERE M.NU_MEDIDOR= '" + datos.ID_MEDIDOR + "' AND DATEPART (YEAR, VARIABLES.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, VARIABLES.FECHA)<= " + datos.FechaFin + "   GROUP BY DATEPART (YEAR, VARIABLES.FECHA)"), conexi);
                }
                else
                {
                   comando = new SqlCommand(string.Format(
                      "SELECT SUM(VARIABLES." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, VARIABLES.FECHA) FROM VARIABLES inner join MEDIDOR M on VARIABLES.ID_MEDIDOR = M.ID_MEDIDOR  WHERE M.NU_MEDIDOR= '" + datos.ID_MEDIDOR + "' AND DATEPART (YEAR, VARIABLES.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, VARIABLES.FECHA)<= " + datos.FechaFin + "   GROUP BY DATEPART (YEAR, VARIABLES.FECHA)"), conexi);
                }
                SqlDataReader reader = comando.ExecuteReader();
                int fecha = -1;
                int vaanterior = 0; 
                while (reader.Read())
                {
                    analisisyreportesID palimentacion = new analisisyreportesID();
                    palimentacion.FECHA = Convert.ToString(reader.GetInt32(1));
                    if (datos.variableaconsultar == "VOLUMENM3")
                    {
                        palimentacion.VARIABLE = Convert.ToString(reader.GetInt32(0) );
                    }
                    else
                    {
                        palimentacion.VARIABLE = Convert.ToString(reader.GetInt32(0));
                    }
                    vaanterior = reader.GetInt32(0);
                    Lista.Add(palimentacion);

                }
            }

            conexion.cerrarbd();
            //using (SqlConnection conexi1 = conexion.conectarbd())
           // {
              //  SqlCommand comando1 = new SqlCommand(string.Format(
               //     "SELECT    t2.DEPARTAMENTO, t2.ZONA, t2.DIRECCION, t2.ESTRATO, M.ID_MEDIDOR FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO WHERE  M.ID_MEDIDOR = '" + datos.ID_MEDIDOR + "'"), conexi1);
               // SqlDataReader reader1 = comando1.ExecuteReader();
               // while (reader1.Read())
               // {

                   // palimentacion.ID_MEDIDOR = Convert.ToString(reader1.GetInt32(4));
                   // palimentacion.DEPARTAMENTO = reader1.GetString(0);
                   // palimentacion.ZONA = reader1.GetString(1);
                   // palimentacion.DIRECION = reader1.GetString(2);
                    //palimentacion.ESTRATO = reader1.GetString(3);
                    


               // }
            //}
              //  conexion.cerrarbd();
                return Lista;

            }


        public static List<analisisyreportesID> analisisyreporteszonasaño(Consultareportesyanalisis datos)
        {

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
                            "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);
                        }
                        if (datos.barrio != "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);
                        }
                        if (datos.barrio != "" && datos.localidad != "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' AND t2.BARRIO = '" + datos.barrio + "' AND DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);
                        }
                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                             "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                             "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                              "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  AND t2.ZONA = '" + datos.zona + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                         "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                           "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                          "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                }
                else
                {
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona != "")
                    {
                        if (datos.barrio == "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);
                        }
                        if (datos.barrio != "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);
                        }
                        if (datos.barrio != "" && datos.localidad != "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' AND t2.BARRIO = '" + datos.barrio + "' AND DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);
                        }
                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                             "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                             "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                              "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  AND t2.ZONA = '" + datos.zona + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                         "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                           "SELECT SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                          "SELECT SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND  DATEPART (YEAR, t1.FECHA)>= " + datos.FechaInicio + " AND DATEPART (YEAR, t1.FECHA)<= " + datos.FechaFin + "  GROUP BY DATEPART (YEAR, t1.FECHA)"), conexi);

                    }
                }
                SqlDataReader reader = comando.ExecuteReader();
                int vaanterior = 0; 
                while (reader.Read())
                {
                    analisisyreportesID palimentacion = new analisisyreportesID();
                    palimentacion.FECHA = Convert.ToString(reader.GetInt32(1));
                    if (datos.variableaconsultar == "VOLUMENM3")
                    {
                        palimentacion.VARIABLE = Convert.ToString(reader.GetInt32(0) );
                    }
                    else
                    {
                        palimentacion.VARIABLE = Convert.ToString(reader.GetInt32(0));
                    }
                    vaanterior = reader.GetInt32(0);
                    Lista.Add(palimentacion);

                }
                conexion.cerrarbd();
                return Lista;

            }

        }

        public static List<analisisyreportesID> analisisyreporteszonasmes(Consultareportesyanalisis datos)
        {

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
                                "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) order by DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                        }
                        if (datos.barrio != "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) order by DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                        }
                        if (datos.barrio != "" && datos.localidad != "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "'  AND t2.LOCALIDAD = '" + datos.localidad + "'  AND t2.BARRIO = '" + datos.barrio + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) order by DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                        }
                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO ='" + datos.ciudad + "'  AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) order by DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                           "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) order by DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) "), conexi);
                    }
                    if (datos.ciudad == "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) order by DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) order by DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) order by DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO = '" + datos.ciudad + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) order by DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + "), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO = '" + datos.ciudad + "' AND t2.DEPARTAMENTO = '" + datos.departamento + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)  order by DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                    }
                }
                else
                {
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona != "")
                    {
                        if (datos.barrio == "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                                "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                        }
                        if (datos.barrio != "" && datos.localidad == "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                        }
                        if (datos.barrio != "" && datos.localidad != "")
                        {
                            comando = new SqlCommand(string.Format(
                            "SELECT  SUM(t1." + datos.variableaconsultar + ") / count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "'  AND t2.LOCALIDAD = '" + datos.localidad + "'  AND t2.BARRIO = '" + datos.barrio + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                        }
                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO ='" + datos.ciudad + "'  AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                           "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                    }
                    if (datos.ciudad == "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                    }
                    if (datos.ciudad == "" && datos.departamento != "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                    }
                    if (datos.ciudad != "" && datos.departamento == "" && datos.zona != "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO = '" + datos.ciudad + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                    }
                    if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT SUM(t1." + datos.variableaconsultar + ")/count(*), DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA) FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO = '" + datos.ciudad + "' AND t2.DEPARTAMENTO = '" + datos.departamento + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                    }
                }
                SqlDataReader reader = comando.ExecuteReader();
                int vaanterior = 0; 
                while (reader.Read())
                {
                    analisisyreportesID palimentacion = new analisisyreportesID();

                    // palimentacion.ID_VARIABLES = Convert.ToString(reader.GetInt32(0));
                    // palimentacion.ID_CONTROL = Convert.ToString(reader.GetInt32(1));
                    // palimentacion.ID_MEDIDOR = Convert.ToString(reader.GetInt32(2));
                    palimentacion.FECHA = Convert.ToString(reader.GetInt32(2)) + "-" + Convert.ToString(reader.GetInt32(1));
                    if (datos.variableaconsultar == "VOLUMENM3")
                    {
                        palimentacion.VARIABLE = Convert.ToString(reader.GetInt32(0) );
                    }
                    else
                    {
                        palimentacion.VARIABLE = Convert.ToString(reader.GetInt32(0));
                    }
                    vaanterior = reader.GetInt32(0);
                    Lista.Add(palimentacion);


                    Lista.Add(palimentacion);

                }
                conexion.cerrarbd();
                return Lista;

            }

        }


        public static String[] DaconsultaNUMEDIDOR(string NUMEDIDOR)
        {

            String[] Lista = new String[10] { "", "", "", "", "", "", "", "", "", "" };
            using (SqlConnection conexi = conexion.conectarbd())
            {

                SqlCommand comando = new SqlCommand(string.Format(
                    "SELECT  t2.DEPARTAMENTO , t2.MUNICIPIO, t2.ZONA, t2.LOCALIDAD, t2.BARRIO, t2.CLASE_USO, M.MARCA, M.TIPO, M.DIAMETRO, M.ID_MEDIDOR  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO  WHERE M.NU_MEDIDOR = '" + NUMEDIDOR + "'"), conexi);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Lista[0] = reader.GetString(0);
                    Lista[1] = reader.GetString(1);
                    Lista[2] = reader.GetString(2);
                    Lista[3] = reader.GetString(3);
                    Lista[4] = reader.GetString(4);
                    Lista[5] = reader.GetString(5);
                    Lista[6] = reader.GetString(6);
                    Lista[7] = reader.GetString(7);
                    Lista[8] = reader.GetString(8);
                    Lista[9] = Convert.ToString(reader.GetInt32(9));
                }

                return Lista;


                conexion.cerrarbd();

            }
        }



        public static int agregaralertasaguas(alertasaguacl datos)
        {

            using (SqlConnection conee = conexion.conectarbd())
            {
                SqlCommand comando = new SqlCommand(String.Format("Insert into ANC (ID_MEDIDOR,FECHAINGRESO, HORAINGRESO, VOLUMENINGRESADO, SUMATORIACONSUMOLEGAL, DIFERENCIA, PERDIDASTECNICAS, PERDIDASCOMERCIALES, ACCIONESFRAUDULENTAS, MEDIDORESMANIPULADOS, MICROMEDICION, CLASE_DE_USO, CAMPO1, CAMPO2, CAMPO3, CAMPO4, CAMPO5) values ('{0}', '{1}', '{2}', '{3}','{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}')",
                 datos.ID_MEDIDOR, datos.FECHAINGRESO, datos.HORAINGRESO, datos.VOLUMENINGRESADO, datos.SUMATORIACONSUMOLEGAL, datos.DIFERENCIA, datos.PERDIDASTECNICAS,
                datos.PERDIDASCOMERCIALES, datos.ACCIONESFRAUDULENTAS, datos.MEDIDORESMANIPULADOS, datos.MICROMEDICION, datos.CLASE_DE_USO, datos.CAMPO1,
                datos.CAMPO2, datos.CAMPO3, datos.CAMPO4, datos.CAMPO5), conee);
                return comando.ExecuteNonQuery();
            }


        }


        public static List<String> vaconsultaNUIDMEDIDOR()
        {

            List<String> Lista = new List<String>();
            using (SqlConnection conexi = conexion.conectarbd())
            {

                SqlCommand comando = new SqlCommand(string.Format(
                    "Select NU_MEDIDOR from MEDIDOR"), conexi);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    Lista.Add(reader.GetString(0));

                }

                conexion.cerrarbd();
                return Lista;

            }

        }

        public static String vaconsultaIDANC()
        {

            String Lista = "";
            using (SqlConnection conexi = conexion.conectarbd())
            {

                SqlCommand comando = new SqlCommand(string.Format(
                    "SELECT ID_ANC FROM ANC WHERE ID_ANC = (SELECT MAX(ID_ANC) FROM ANC)"), conexi);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    Lista =Convert.ToString(reader.GetInt32(0)+1);

                }

                conexion.cerrarbd();
                return Lista;

            }

        }


    }

    }


