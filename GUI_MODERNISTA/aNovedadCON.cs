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
    
    public partial class aNovedadCON : Form
    {
        
        public String idmed;
        
        public aNovedadCON()
        {
           
            
            InitializeComponent();

            fingnovedad.Text = DateTime.Now.ToShortDateString();
            horaingnov.Text = DateTime.Now.ToShortTimeString();

       
        }


        public static String idmedido;



        private void Registro_Load(object sender, EventArgs e)
        {
      
            List<String> columnData = new List<String>();
            List<String> columnData1 = new List<String>();

            using (SqlConnection cone = conexion.conectarbd())
            {

                //string query = "SELECT ID_INFENTRADA FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR+'" + idmed +"'";
                //using (SqlCommand command = new SqlCommand(query, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            columnData.Add(reader.GetValue(0).ToString());

                //        }
                //    }
                //}

                //idnovedad.DataSource = columnData;

                //string query = "SELECT ALIMENTACION_HISTORICA.ID_INFENTRADA FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR+'" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            idnovedad.Text= reader.GetValue(0).ToString();
                //            //columnData.Add(reader.GetValue(0).ToString());

                //        }
                //    }
                //}

                string query100 = "SELECT ALIMENTACION_HISTORICA.ID_INFENTRADA FROM ALIMENTACION_HISTORICA, MEDIDOR WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR=MEDIDOR.ID_MEDIDOR AND ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query100, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));

                            //label6.Text = Convert.ToString(reader.GetInt32(0) + 1);
                            columnData.Add(reader.GetValue(0).ToString());
                        }
                    }
                }

                idnovedad.DataSource = columnData;

                string query1 = "SELECT MEDIDOR.NU_MEDIDOR FROM ALIMENTACION_HISTORICA, MEDIDOR WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR=MEDIDOR.ID_MEDIDOR AND ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query1, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));

                            //label6.Text = Convert.ToString(reader.GetInt32(0) + 1);
                            label8.Text = reader.GetValue(0).ToString();
                        }
                    }
                }





                string query2 = "SELECT PREDIO.DEPARTAMENTO, MEDIDOR.ID_MEDIDOR FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + idmed + "'";
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

                string query3 = "SELECT PREDIO.MUNICIPIO FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + idmed + "'";
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

                string query4 = "SELECT PREDIO.ZONA FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + idmed + "'";
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

                string query5 = "SELECT PREDIO.LOCALIDAD FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + idmed + "'";
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

                string query6 = "SELECT PREDIO.BARRIO FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + idmed + "'";
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

                string query7 = "SELECT ALIMENTACION_HISTORICA.DEFRAUDACION_FLUIDOS FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query7, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            fraudefluidoscb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }


                string query8 = "SELECT ALIMENTACION_HISTORICA.CORTES_SERVICIO FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query8, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            cortescb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query9 = "SELECT ALIMENTACION_HISTORICA.RECONEXION FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query9, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            reconexionescb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query10 = "SELECT ALIMENTACION_HISTORICA.VIOLACIONES FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query10, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            violacionescb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query11 = "SELECT ALIMENTACION_HISTORICA.AUTO_PROTECCION FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query11, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            autoproteccioncb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }
                string query12 = "SELECT ALIMENTACION_HISTORICA.REVISIONES_INTERNAS FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query12, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            revisionesinternascb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query13 = "SELECT ALIMENTACION_HISTORICA.EVALUACION_PROMEDIOS FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query13, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            evaluacionpromedioscb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }
                string query14 = "SELECT ALIMENTACION_HISTORICA.CORTES_SERVICIO FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query14, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            evaluacionpromedioscb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query15 = "SELECT ALIMENTACION_HISTORICA.CAMPO1 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query15, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            campo1.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query16 = "SELECT ALIMENTACION_HISTORICA.CAMPO2 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query16, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            campo2.Text = reader.GetValue(0).ToString();
                        }
                    }
                }
                string query17 = "SELECT ALIMENTACION_HISTORICA.CAMPO3 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query17, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            campo2.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query18 = "SELECT ALIMENTACION_HISTORICA.CAMPO4 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query18, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            campo4.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query19 = "SELECT ALIMENTACION_HISTORICA.CAMPO5 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                using (SqlCommand command = new SqlCommand(query19, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            campo5.Text = reader.GetValue(0).ToString();
                        }
                    }
                }
                string query89 = "SELECT MEDIDOR.ID_MEDIDOR FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + idnovedad.Text + "'";
                using (SqlCommand command = new SqlCommand(query89, cone))
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
            }
        
       
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarNovedades novedad = new AgregarNovedades();

            novedad.fechaingreso = fingnovedad.Text;
            novedad.horaingresonovedad = horaingnov.Text;
            novedad.idmedidor = idmedidor.Text;
            novedad.nmedidor = idnovedad.Text;
            novedad.revisionesinternas = revisionesinternascb.Text;
            novedad.cortes = cortescb.Text;
            novedad.reconexiones = reconexionescb.Text;
            novedad.fraudefluidos = fraudefluidoscb.Text;
            novedad.alertasdesviacionessignificativas = alertadesviacionescb.Text;
            novedad.violaciones = violacionescb.Text;
            novedad.autoproteccion = autoproteccioncb.Text;
            novedad.evaluaciondepromedios = evaluacionpromedioscb.Text;
            
            novedad.campo1 = campo1.Text;
            novedad.campo2 = campo2.Text;
            novedad.campo3 = campo3.Text;
            novedad.campo4 = campo4.Text;
            novedad.campo5 = campo5.Text;

           
            if (!String.IsNullOrEmpty(idnovedad.Text) && !String.IsNullOrEmpty(fraudefluidoscb.Text) && !String.IsNullOrEmpty(revisionesinternascb.Text) && !String.IsNullOrEmpty(cortescb.Text) && !String.IsNullOrEmpty(reconexionescb.Text) &&  !String.IsNullOrEmpty(violacionescb.Text) && !String.IsNullOrEmpty(autoproteccioncb.Text) && !String.IsNullOrEmpty(evaluacionpromedioscb.Text) && !String.IsNullOrEmpty(alertadesviacionescb.Text))
 
            {
                int resul = Registroo.agregarN(novedad);
                if (resul == 1)
                {
                    MessageBox.Show("Datos guardados Correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    idnovedad.Text = "";
                    departamento.Text = "";
                    ciudad.Text = "";
                    zona.Text = "";
                    localidad.Text = "";
                    barrio.Text = "";
                    fraudefluidoscb.Text = "";
                    revisionesinternascb.Text = "";
                    cortescb.Text = "";
                    reconexionescb.Text = "";
                    alertadesviacionescb.Text = "";
                    violacionescb.Text = "";
                    autoproteccioncb.Text = "";
                    evaluacionpromedioscb.Text = "";
            
                    campo1.Text = "";
                    campo2.Text = "";
                    campo3.Text = "";
                    campo4.Text = "";
                    campo5.Text = "";

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


            InitializeComponent();

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

                //string query = "SELECT ID_INFENTRADA FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR+'" + idmed +"'";
                //using (SqlCommand command = new SqlCommand(query, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            columnData.Add(reader.GetValue(0).ToString());

                //        }
                //    }
                //}

                //idnovedad.DataSource = columnData;

                //string query = "SELECT ALIMENTACION_HISTORICA.ID_INFENTRADA FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR+'" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            idnovedad.Text= reader.GetValue(0).ToString();
                //            //columnData.Add(reader.GetValue(0).ToString());

                //        }
                //    }
                //}

                //string query100 = "SELECT ALIMENTACION_HISTORICA.ID_INFENTRADA FROM ALIMENTACION_HISTORICA, MEDIDOR WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR=MEDIDOR.ID_MEDIDOR AND ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query100, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));

                //            //label6.Text = Convert.ToString(reader.GetInt32(0) + 1);
                //            columnData.Add(reader.GetValue(0).ToString());
                //        }
                //    }
                //}

                //idnovedad.DataSource = columnData;

                //string query1 = "SELECT MEDIDOR.NU_MEDIDOR FROM ALIMENTACION_HISTORICA, MEDIDOR WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR=MEDIDOR.ID_MEDIDOR AND ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query1, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));

                //            //label6.Text = Convert.ToString(reader.GetInt32(0) + 1);
                //            label8.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                //string query2 = "SELECT PREDIO.DEPARTAMENTO, MEDIDOR.ID_MEDIDOR FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query2, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            departamento.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                //string query3 = "SELECT PREDIO.MUNICIPIO FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query3, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            ciudad.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                //string query4 = "SELECT PREDIO.ZONA FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query4, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            zona.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                //string query5 = "SELECT PREDIO.LOCALIDAD FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query5, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            localidad.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                //string query6 = "SELECT PREDIO.BARRIO FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query6, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            barrio.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                string query107 = "SELECT ALIMENTACION_HISTORICA.DEFRAUDACION_FLUIDOS FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_INFENTRADA='" + idnovedad.Text + "'";
                using (SqlCommand command = new SqlCommand(query107, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            fraudefluidoscb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }
                string query108 = "SELECT ALIMENTACION_HISTORICA.CORTES_SERVICIO FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_INFENTRADA='" + idnovedad.Text + "'";
                using (SqlCommand command = new SqlCommand(query108, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            cortescb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query109 = "SELECT ALIMENTACION_HISTORICA.RECONEXIONES FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_INFENTRADA='" + idnovedad.Text + "'";
                using (SqlCommand command = new SqlCommand(query108, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            reconexionescb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }


                string query110 = "SELECT ALIMENTACION_HISTORICA.VIOLACIONES FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_INFENTRADA='" + idnovedad.Text + "'";
                using (SqlCommand command = new SqlCommand(query110, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            violacionescb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query111 = "SELECT ALIMENTACION_HISTORICA.VIOLACIONES FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_INFENTRADA='" + idnovedad.Text + "'";
                using (SqlCommand command = new SqlCommand(query111, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            autoproteccioncb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }


                string query112 = "SELECT ALIMENTACION_HISTORICA.REVISIONES_INTERNAS FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_INFENTRADA='" + idnovedad.Text + "'";
                using (SqlCommand command = new SqlCommand(query112, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            revisionesinternascb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query113 = "SELECT ALIMENTACION_HISTORICA.EVALUACION_PROMEDIOS FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_INFENTRADA='" + idnovedad.Text + "'";
                using (SqlCommand command = new SqlCommand(query113, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            evaluacionpromedioscb.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query114 = "SELECT ALIMENTACION_HISTORICA.CAMPO1 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_INFENTRADA='" + idnovedad.Text + "'";
                using (SqlCommand command = new SqlCommand(query114, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            campo1.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query115 = "SELECT ALIMENTACION_HISTORICA.CAMPO1 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_INFENTRADA='" + idnovedad.Text + "'";
                using (SqlCommand command = new SqlCommand(query115, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            campo2.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query116 = "SELECT ALIMENTACION_HISTORICA.CAMPO3 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_INFENTRADA='" + idnovedad.Text + "'";
                using (SqlCommand command = new SqlCommand(query116, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            campo3.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                string query117 = "SELECT ALIMENTACION_HISTORICA.CAMPO4 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_INFENTRADA='" + idnovedad.Text + "'";
                using (SqlCommand command = new SqlCommand(query116, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            campo4.Text = reader.GetValue(0).ToString();
                        }
                    }
                }


                string query118 = "SELECT ALIMENTACION_HISTORICA.CAMPO5 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_INFENTRADA='" + idnovedad.Text + "'";
                using (SqlCommand command = new SqlCommand(query118, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            campo5.Text = reader.GetValue(0).ToString();
                        }
                    }
                }

                //string query8 = "SELECT ALIMENTACION_HISTORICA.CORTES_SERVICIO FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "' AND ALIMENTACION_HISTORICA.ID_INFENTRADA='" + idnovedad + "'";
                //using (SqlCommand command = new SqlCommand(query8, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            cortescb.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                //string query9 = "SELECT ALIMENTACION_HISTORICA.RECONEXION FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query9, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            reconexionescb.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                //string query10 = "SELECT ALIMENTACION_HISTORICA.VIOLACIONES FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query10, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            violacionescb.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                //string query11 = "SELECT ALIMENTACION_HISTORICA.AUTO_PROTECCION FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query11, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            autoproteccioncb.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}
                //string query12 = "SELECT ALIMENTACION_HISTORICA.REVISIONES_INTERNAS FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query12, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            revisionesinternascb.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                //string query13 = "SELECT ALIMENTACION_HISTORICA.EVALUACION_PROMEDIOS FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query13, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            evaluacionpromedioscb.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}
                //string query14 = "SELECT ALIMENTACION_HISTORICA.CORTES_SERVICIO FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query14, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            evaluacionpromedioscb.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                //string query15 = "SELECT ALIMENTACION_HISTORICA.CAMPO1 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query15, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            campo1.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                //string query16 = "SELECT ALIMENTACION_HISTORICA.CAMPO2 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query16, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            campo2.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}
                //string query17 = "SELECT ALIMENTACION_HISTORICA.CAMPO3 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query17, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            campo2.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                //string query18 = "SELECT ALIMENTACION_HISTORICA.CAMPO4 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query18, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            campo4.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                //string query19 = "SELECT ALIMENTACION_HISTORICA.CAMPO5 FROM ALIMENTACION_HISTORICA WHERE ALIMENTACION_HISTORICA.ID_MEDIDOR='" + idmed + "'";
                //using (SqlCommand command = new SqlCommand(query19, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));
                //            campo5.Text = reader.GetValue(0).ToString();
                //        }
                //    }
                //}






            }




        }


    }
}
