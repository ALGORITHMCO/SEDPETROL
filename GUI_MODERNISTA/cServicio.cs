using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GUI_MODERNISTA
{
    
    public partial class cServicio : Form
    {
        Panel panel1;
        int a,b,c;
        public cServicio()
        {
            //panel1 = p;
            
            InitializeComponent();

            fingnovedad.Text = DateTime.Now.ToShortDateString();
            horaingnov.Text = DateTime.Now.ToShortTimeString();

            

            tiposdealarmas.Items.Add("Consumo > normal");
            tiposdealarmas.Items.Add("Consumo < normal");
            tiposdealarmas.Items.Add("Presion > normal");
            tiposdealarmas.Items.Add("Presion < normal");
            tiposdealarmas.Items.Add("Presion > normal");
            tiposdealarmas.Items.Add("Presion < normal");
            tiposdealarmas.Items.Add("Otros");
            tiposdealarmas.Items.Add("N/A");

            saperturacierre.Items.Add("Abierta");
            saperturacierre.Items.Add("Cerrada");

            claseuso.Items.Add("Residencial");
            claseuso.Items.Add("Comercial");
           
            ppconsumospre.Items.Add("Casas de habitación o rurales, 100 Lt/hab/día");
            ppconsumospre.Items.Add("Conj. Residenciales hasta 90 m2 de área, 150 Lt/hab/día");
            ppconsumospre.Items.Add("Residencias y departamentos con 100 a 200 m2 de área, 200 Lt/hab/día");
            ppconsumospre.Items.Add("Residencias y departamentos con área superior a 200 m2 de área, 250 Lt/hab/día");
            ppconsumospre.Items.Add("Alojamientos provisionales, 80 Lt/hab/día");
            ppconsumospre.Items.Add("Hoteles sin cocina y sin lavanderia, 200 Lt/depto/día");
            ppconsumospre.Items.Add("Hoteles con cocina y con lavanderia, 300    Lt/depto/día");
            ppconsumospre.Items.Add("Hospitales, 400    Lt/cama/día");
            ppconsumospre.Items.Add("Escuelas internas,  150 Lt/persona/dia");
            ppconsumospre.Items.Add("Escuelas externas,   50 Lt/persona/dia");
            ppconsumospre.Items.Add("Escuelas semi internas, 100   Lt/persona/dia");
            ppconsumospre.Items.Add("Facultades,  100  Lt/persona/dia");
            ppconsumospre.Items.Add("Edifición publicos / comerciales,  50 Lt/persona/dia");
            ppconsumospre.Items.Add("Cuarteles,   150 Lt/persona/dia");
            ppconsumospre.Items.Add("Restaurantes,   30   Lt/racion");
            ppconsumospre.Items.Add("Lavanderias, 1000 Lt/Kg/de ropa seca");
            ppconsumospre.Items.Add("Orfanatos - asilos - sala cunas, 150  Lt/persona/día");
            ppconsumospre.Items.Add("Servicios ambulatorios,  500  Lt/persona/día");
            ppconsumospre.Items.Add("Mataderos - animales grandes, 400  Lt/cabeza/sacrificada");
            ppconsumospre.Items.Add("Mataderos - animales pequeños,  200  Lt/cabeza/sacrificada");
            ppconsumospre.Items.Add("Mataderos industriales - animales grandes, 2000  Lt/cabeza/sacrificada");
            ppconsumospre.Items.Add("Mataderos industriales - animales grandes,    800  Lt/cabeza/sacrificada");
            ppconsumospre.Items.Add("Gasolineras con servicio de lavado,   400   Lt/vehiculo");
            ppconsumospre.Items.Add("Otros 1");
            ppconsumospre.Items.Add("Otros 2");
            ppconsumospre.Items.Add("Otros 3");
            ppconsumospre.Items.Add("Otros 4");
            ppconsumospre.Items.Add("Otros 5");

            valorpp.Items.Add("30");
            valorpp.Items.Add("50");
            valorpp.Items.Add("100");
            valorpp.Items.Add("150");
            valorpp.Items.Add("200");
            valorpp.Items.Add("250");
            valorpp.Items.Add("400");
            valorpp.Items.Add("500");
            valorpp.Items.Add("800");
            valorpp.Items.Add("1000");
            valorpp.Items.Add("2000");

            maxmedidorvelocidad.Items.Add("D. nom.  3/4 pulgada o 19 mm, Q caracteristico 3(m3), Vol.agua requerido 6(m3 / día), Vol.agua requerido 90(m3 / mes)");
            maxmedidorvelocidad.Items.Add("D. nom.  3/4 pulgada o 19 mm,  Q caracteristico 5 (m3),  Vol. agua requerido 10 (m3/día), Vol. agua requerido 150 (m3/mes)");
            maxmedidorvelocidad.Items.Add("D. nom.  1 pulgada o 25 mm,  Q caracteristico 7 (m3),  Vol. agua requerido 14 (m3/día), Vol. agua requerido 210 (m3/mes)");
            maxmedidorvelocidad.Items.Add("D. nom.  1 pulgada o 25 mm,  Q caracteristico 10 (m3),  Vol. agua requerido 20 (m3/día), Vol. agua requerido 300 (m3/mes)");
            maxmedidorvelocidad.Items.Add("D. nom. 1 1/2 pulgada o 38 mm,  Q caracteristico 20 (m3),  Vol. agua requerido 40 (m3/día), Vol. agua requerido 600 (m3/mes)");
            maxmedidorvelocidad.Items.Add("D. nom.  2 pulgada o 50 mm,  Q caracteristico 30 (m3),  Vol. agua requerido 60 (m3/día), Vol. agua requerido 900 (m3/mes)");

            diametromedsugerido.Items.Add("Datos del Propietario");
            diametromedsugerido.Items.Add("Datos del Medidor");
            diametromedsugerido.Items.Add("Datos de Novedades Anteriores");
            diametromedsugerido.Items.Add("Datos de Consumos Anteriores");
            diametromedsugerido.Items.Add("Todos los datos asociados con el medidor");
            diametromedsugerido.Items.Add("Otros");
            diametromedsugerido.Items.Add("N/A");

            

            resultadorequerimiento.Items.Add("Requiere cambio de medidor");
            resultadorequerimiento.Items.Add("Requiere cambio de de acometida");
            resultadorequerimiento.Items.Add("Requiere cambio de red local");
            resultadorequerimiento.Items.Add("Requiere calibracion del medidor");
            resultadorequerimiento.Items.Add("Otros");
            resultadorequerimiento.Items.Add("N/A");

        }


        public static String idmedido;



        private void Registro_Load(object sender, EventArgs e)
        {
      
            List<String> columnData = new List<String>();
            List<String> columnData1 = new List<String>();

            using (SqlConnection cone = conexion.conectarbd())
            {
                
                string query = "SELECT NU_MEDIDOR FROM MEDIDOR";
                using (SqlCommand command = new SqlCommand(query, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            columnData.Add(reader.GetValue(0).ToString());
                            
                        }
                    }
                }

                string query1 = "SELECT ID_COMPORTAMIENTO FROM COMPORTAMIENTO_SERVICIO WHERE ID_COMPORTAMIENTO=(SELECT MAX(ID_COMPORTAMIENTO) FROM COMPORTAMIENTO_SERVICIO)";
                using (SqlCommand command = new SqlCommand(query1, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            icomportamiento.Text = Convert.ToString(reader.GetInt32(0) + 1);
                        }
                    }
                }


            }
            nmedidor.DataSource = columnData;

            
            nmedidor.Text = "";
            departamento.Text = "";
            ciudad.Text = "";
            localidad.Text = "";
            zona.Text = "";
            barrio.Text = "";
            tiposdealarmas.Text = "";
            saldo.Text = "";
            saperturacierre.Text = "";
            claseuso.Text = "";
            ppconsumospre.Text = "";
            promflujomedidor.Text = "";
            difconsumo.Text = "";
            alertadesvsignificativas.Text = "";
            difconsumo.Text = "";
            alertadesv.Text = "";
            maxmedidorvelocidad.Text = "";
            resultadorequerimiento.Text = "";
            campo1.Text = "";
            campo2.Text = "";
            campo3.Text = "";
            campo4.Text = "";
            campo5.Text = "";
            mamedidor.Text = "";
            tipomedidor.Text = "";
            diametromedidor.Text = "";
            hconsumo1.Text = "";
            hconsumo2.Text = "";
            hconsumo3.Text = "";
            hconsumo4.Text = "";
            hconsumo5.Text = "";
            hconsumo6.Text = "";
            diametromedsugerido.Text = "";
            valorpp.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComportamientoServicio comportamiento = new ComportamientoServicio();

            comportamiento.fechaingreso = fingnovedad.Text;
            comportamiento.horaingreso = horaingnov.Text;
            comportamiento.idcomportamiento = icomportamiento.Text;
            comportamiento.idmedidor = idmedido;
            comportamiento.tiposalarmas = tiposdealarmas.Text;
            comportamiento.saldo = saldo.Text;
            comportamiento.solicitudac = saperturacierre.Text;
            comportamiento.claseuso = claseuso.Text;
            comportamiento.patronparametrosconsumos = ppconsumospre.Text;
            comportamiento.promedioflujomedidor = promflujomedidor.Text;
            comportamiento.diferenciaconsumopatron= difconsumo.Text;
            comportamiento.alertadesvsignificativas = alertadesvsignificativas.Text;
            comportamiento.maximasparamedidores = maxmedidorvelocidad.Text;
            comportamiento.resultadorequerimiento = resultadorequerimiento.Text;
            comportamiento.diametrosugeridomedidor = diametromedsugerido.Text;
            comportamiento.resultadorequerimiento = resultadorequerimiento.Text;
            comportamiento.campo1 = campo1.Text;
            comportamiento.campo2 = campo2.Text;
            comportamiento.campo3 = campo3.Text;
            comportamiento.campo4 = campo4.Text;
            comportamiento.campo5 = campo5.Text;


            //if (!String.IsNullOrEmpty(nmedidor.Text) && !String.IsNullOrEmpty(tiposdealarmas.Text) && !String.IsNullOrEmpty(saldo.Text) &&  !String.IsNullOrEmpty(saperturacierre.Text) && !String.IsNullOrEmpty(claseuso.Text) && !String.IsNullOrEmpty(ppconsumospre.Text) && !String.IsNullOrEmpty(promflujomedidor.Text) && !String.IsNullOrEmpty(difconsumo.Text) && !String.IsNullOrEmpty(maxmedidorvelocidad.Text) && !String.IsNullOrEmpty(alertadesv.Text))
            if (!String.IsNullOrEmpty(nmedidor.Text) && !String.IsNullOrEmpty(tiposdealarmas.Text) && !String.IsNullOrEmpty(saldo.Text) && !String.IsNullOrEmpty(saperturacierre.Text) && !String.IsNullOrEmpty(claseuso.Text) && !String.IsNullOrEmpty(ppconsumospre.Text) && !String.IsNullOrEmpty(promflujomedidor.Text) && !String.IsNullOrEmpty(difconsumo.Text) && !String.IsNullOrEmpty(alertadesvsignificativas.Text) && !String.IsNullOrEmpty(maxmedidorvelocidad.Text) && !String.IsNullOrEmpty(resultadorequerimiento.Text) && !String.IsNullOrEmpty(diametromedidor.Text)) 
               // && !String.IsNullOrEmpty(saperturacierre.Text) && !String.IsNullOrEmpty(claseuso.Text) && !String.IsNullOrEmpty(ppconsumospre.Text) && !String.IsNullOrEmpty(promflujomedidor.Text) && !String.IsNullOrEmpty(difconsumo.Text) && !String.IsNullOrEmpty(alertadesv.Text) && !String.IsNullOrEmpty(maxmedidorvelocidad.Text) && !String.IsNullOrEmpty(resultadorequerimiento.Text) && !String.IsNullOrEmpty(diametromedsugerido.Text))

            {
                int resul = Registroo.ingresarCS(comportamiento);
                if (resul == 1)
                {
                    MessageBox.Show("Datos guardados Correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    nmedidor.Text = "";
                    departamento.Text = "";
                    ciudad.Text = "";
                    localidad.Text = "";
                    zona.Text = "";
                    barrio.Text = "";
                    tiposdealarmas.Text = "";
                    saldo.Text = "";
                    saperturacierre.Text = "";
                    claseuso.Text = "";
                    ppconsumospre.Text = "";
                    promflujomedidor.Text = "";
                    difconsumo.Text = "";
                    alertadesvsignificativas.Text = "";
                    maxmedidorvelocidad.Text = "";
                    resultadorequerimiento.Text = "";
                    mamedidor.Text = "";
                    tipomedidor.Text = "";
                    diametromedidor.Text = "";
                    campo1.Text = "";
                    campo2.Text = "";
                    campo3.Text = "";
                    campo4.Text = "";
                    campo5.Text = "";
                    hconsumo1.Text = "";
                    hconsumo2.Text = "";
                    hconsumo3.Text = "";
                    hconsumo4.Text = "";
                    hconsumo5.Text = "";
                    hconsumo6.Text = "";
                    diametromedsugerido.Text = "";
                    valorpp.Text = "";
                }
                else
                {
                    if (resul == -1)
                    {
                        MessageBox.Show("Datos ya estan registrados", "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show("Error conexion", "ERROR AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            



            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "ERROR AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBox2.Items.Add("Hola");


            
        }

        private void imedidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection cone = conexion.conectarbd())
            {
                string query2 = "SELECT PREDIO.DEPARTAMENTO, MEDIDOR.ID_MEDIDOR FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query2, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            departamento.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query3 = "SELECT PREDIO.MUNICIPIO FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query3, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            ciudad.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query4 = "SELECT PREDIO.ZONA FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query4, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            zona.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query5 = "SELECT PREDIO.LOCALIDAD FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query5, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            localidad.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query6 = "SELECT PREDIO.BARRIO FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query6, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            barrio.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query7 = "SELECT PREDIO.BARRIO FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query7, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            barrio.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query8 = "SELECT MEDIDOR.ID_MEDIDOR FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query8, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            idmedidor.Text = reader.GetValue(0).ToString();
                            idmedido = idmedidor.Text;
                        }
                    }
                }


                string query9 = "SELECT FACTURAS.PERIODO1 FROM FACTURAS, MEDIDOR WHERE FACTURAS.ID_MEDIDOR=MEDIDOR.ID_MEDIDOR AND MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query9, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            hconsumo1.Text = reader.GetValue(0).ToString();
                            
                        }
                    }
                }

                string query10 = "SELECT FACTURAS.PERIODO2 FROM FACTURAS, MEDIDOR WHERE FACTURAS.ID_MEDIDOR=MEDIDOR.ID_MEDIDOR AND MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query10, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            hconsumo2.Text = reader.GetValue(0).ToString();

                        }
                    }
                }

                string query11 = "SELECT FACTURAS.PERIODO3 FROM FACTURAS, MEDIDOR WHERE FACTURAS.ID_MEDIDOR=MEDIDOR.ID_MEDIDOR AND MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query11, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            hconsumo3.Text = reader.GetValue(0).ToString();

                        }
                    }
                }

                string query12 = "SELECT FACTURAS.PERIODO4 FROM FACTURAS, MEDIDOR WHERE FACTURAS.ID_MEDIDOR=MEDIDOR.ID_MEDIDOR AND MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query12, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            hconsumo4.Text = reader.GetValue(0).ToString();

                        }
                    }
                }

                string query13 = "SELECT FACTURAS.PERIODO5 FROM FACTURAS, MEDIDOR WHERE FACTURAS.ID_MEDIDOR=MEDIDOR.ID_MEDIDOR AND MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query13, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            hconsumo5.Text = reader.GetValue(0).ToString();

                        }
                    }
                }

                string query14 = "SELECT FACTURAS.PERIODO6 FROM FACTURAS, MEDIDOR WHERE FACTURAS.ID_MEDIDOR=MEDIDOR.ID_MEDIDOR AND MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query14, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            hconsumo6.Text = reader.GetValue(0).ToString();

                        }
                    }
                }

                string query15 = "SELECT MEDIDOR.MARCA FROM MEDIDOR WHERE MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query15, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            mamedidor.Text = reader.GetValue(0).ToString();

                        }
                    }
                }
                string query16 = "SELECT MEDIDOR.TIPO FROM MEDIDOR WHERE MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query16, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            tipomedidor.Text = reader.GetValue(0).ToString();

                        }
                    }
                }
                string query17 = "SELECT MEDIDOR.DIAMETRO FROM MEDIDOR WHERE MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query17, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            diametromedidor.Text = reader.GetValue(0).ToString();

                        }
                    }
                }

                string query18 = "SELECT MEDIDOR.CONSUMOM3 FROM MEDIDOR WHERE MEDIDOR.NU_MEDIDOR='" + nmedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query18, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            promflujomedidor.Text = reader.GetValue(0).ToString();

                        }
                    }
                }
            }
        }

       

       

      

        private void reclamacionescb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void valorpp_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(valorpp.Text);
            b = Convert.ToInt32(promflujomedidor.Text);
            c = b - a;
            difconsumo.Text = Convert.ToString(c);
        }
    }
}
