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
    public partial class aNovedad : Form
    {
        public aNovedad()
        {
            InitializeComponent();
            fingnovedad.Text = DateTime.Now.ToShortDateString();
            horaingnov.Text = DateTime.Now.ToShortTimeString();

            fraudefluidoscb.Items.Add("Control de actividad Economica");
            fraudefluidoscb.Items.Add("Control clase de uso");
            fraudefluidoscb.Items.Add("Variacion injustificada de consumos");
            fraudefluidoscb.Items.Add("Excesos y Bajas de presión");
            fraudefluidoscb.Items.Add("Prog. Vigilancia especial C. problema");
            fraudefluidoscb.Items.Add("Otros");
            fraudefluidoscb.Items.Add("N/A");

            cortescb.Items.Add("Solicitud del usuario");
            cortescb.Items.Add("Defraudacion fluidos");
            cortescb.Items.Add("Racionamiento");
            cortescb.Items.Add("Necesidad del servicio");
            cortescb.Items.Add("Programado");
            cortescb.Items.Add("Otros");
            cortescb.Items.Add("N/A");

            reconexionescb.Items.Add("Asignacion de cupo");
            reconexionescb.Items.Add("Solicitud del usuario");
            reconexionescb.Items.Add("Derecho de peticion");
            reconexionescb.Items.Add("Proceso de reclamacion");
            reconexionescb.Items.Add("Otros");
            reconexionescb.Items.Add("N/A");

            violacionescb.Items.Add("Sí");
            violacionescb.Items.Add("No");
            violacionescb.Items.Add("N/A");

            autoproteccioncb.Items.Add("Alerta Penetracion Violenta");
            autoproteccioncb.Items.Add("Descargas electricas");
            autoproteccioncb.Items.Add("Desconexión");
            autoproteccioncb.Items.Add("Impactos");
            autoproteccioncb.Items.Add("Traslados");
            autoproteccioncb.Items.Add("Otros");
            autoproteccioncb.Items.Add("N/A");

            alertadesviacionescb.Items.Add("Consumo > normal");
            alertadesviacionescb.Items.Add("Consumo < normal");
            alertadesviacionescb.Items.Add("Presión > normal");
            alertadesviacionescb.Items.Add("Presion < normal");
            alertadesviacionescb.Items.Add("Flujo > normal");
            alertadesviacionescb.Items.Add("Flujo < normal");
            alertadesviacionescb.Items.Add("Otros");
            alertadesviacionescb.Items.Add("N/A");

            revisionesinternascb.Items.Add("Programacion por zonas");
            revisionesinternascb.Items.Add("Cambios en patron de consumo");
            revisionesinternascb.Items.Add("Consumo cero");
            revisionesinternascb.Items.Add("Alerta Supervisor");
            revisionesinternascb.Items.Add("Alerta Usuario");
            revisionesinternascb.Items.Add("Otros");
            revisionesinternascb.Items.Add("N/A");

            evaluacionpromedioscb.Items.Add("Realizado");
            evaluacionpromedioscb.Items.Add("No Realizado");
            evaluacionpromedioscb.Items.Add("Por realizar");
            evaluacionpromedioscb.Items.Add("Otros");
            evaluacionpromedioscb.Items.Add("N/A");

            ingresodatoscb.Items.Add("Datos del propietario");
            ingresodatoscb.Items.Add("Datos del Medidor");
            ingresodatoscb.Items.Add("Datos de Novedades Anteriores");
            ingresodatoscb.Items.Add("Datos de Consumos Anteriores");
            ingresodatoscb.Items.Add("Todos los datos asociados con el medidor");
            ingresodatoscb.Items.Add("Otros");
            ingresodatoscb.Items.Add("N/A");

            reclamacionescb.Items.Add("Asignacion de cupo");
            reclamacionescb.Items.Add("Solicitud del usuario");
            reclamacionescb.Items.Add("Derecho de peticion");
            reclamacionescb.Items.Add("Proceso de reclamacion");
            reclamacionescb.Items.Add("Otros");
            reclamacionescb.Items.Add("N/A");

        }



        
        

        private void Registro_Load(object sender, EventArgs e)
        {
            //comboBox2.Items.Add("Hola");
            List<String> columnData = new List<String>();

            using (SqlConnection cone = conexion.conectarbd())
            {
                
                string query = "SELECT ID_MEDIDOR FROM MEDIDOR";
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
            }
            imedidor.DataSource = columnData;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarNovedades novedad = new AgregarNovedades();

            //novedad.usuarios = textusuario.Text;
            //novedad.nombres = textnombre.Text;
            //novedad.contraseñas = textcontra.Text;
            //novedad.correos = textcorreo.Text;

            //novedad.fechaingreso = fechaingnove.Text;
            //novedad.horaingresonovedad = horaingresonove.Text;
            //novedad.fechaingreso = fecha.Text;
            novedad.fechaingreso=fingnovedad.Text;
            novedad.horaingresonovedad = horaingnov.Text;
            //novedad.horaingresonovedad = horaingresonove.Text;
            novedad.idmedidor = imedidor.Text;
            novedad.revisionesinternas = revisionesinternascb.Text;
            novedad.cortes = cortescb.Text;
            novedad.reconexiones = reconexionescb.Text;
            novedad.fraudefluidos = fraudefluidoscb.Text;
            novedad.reclamaciones = reclamacionescb.Text;
            novedad.violaciones = violacionescb.Text;
            novedad.autoproteccion = autoproteccioncb.Text;
            novedad.evaluaciondepromedios = evaluacionpromedioscb.Text;
            novedad.ingresodatosprimeravez = ingresodatoscb.Text;
            novedad.campo1 = campo1.Text;
            novedad.campo2 = campo2.Text;
            novedad.campo3 = campo3.Text;
            novedad.campo4 = campo4.Text;
            novedad.campo5 = campo5.Text;
        



            //novedad.idnovedad = idnovedad.Text;
            //novedad.idmedidor = idmedidor.Text;
            //novedad.departamento=departamento.Text
            //novedad.revisionesinternas = revisionesinternas.Text;
            //novedad.cortes = cortes.Text;
            //novedad.reconexiones = reconexiones.Text;
            //novedad.fraudefluidos = fraudefluido.Text;
            //novedad.reclamaciones = reclamaciones.Text;
            //novedad.autoproteccion = autoproteccion.Text;
            //novedad.evaluaciondepromedios = evaluacionpromedios.Text;
            //novedad.ingresodatosprimeravez = ingresodatosprimeravez.Text;
            //novedad.campo1 = campo1.Text;
            //novedad.campo2 = campo2.Text;
            //novedad.campo3 = campo3.Text;
            //novedad.campo4 = campo4.Text;
            //novedad.campo5 = campo5.Text;

            int resul = Registroo.agregarN(novedad);

            if (resul == 1)
            {
                MessageBox.Show("Datos guardados Correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                string query2 = "SELECT PREDIO.DEPARTAMENTO, MEDIDOR.ID_MEDIDOR FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + imedidor.Text + "'";
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

                string query3 = "SELECT PREDIO.MUNICIPIO FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + imedidor.Text + "'";
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

                string query4 = "SELECT PREDIO.ZONA FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + imedidor.Text + "'";
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

                string query5 = "SELECT PREDIO.LOCALIDAD FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + imedidor.Text + "'";
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

                string query6 = "SELECT PREDIO.BARRIO FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + imedidor.Text + "'";
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

                string query7 = "SELECT PREDIO.BARRIO FROM PREDIO, MEDIDOR WHERE PREDIO.ID_PREDIO=MEDIDOR.ID_PREDIO AND MEDIDOR.ID_MEDIDOR='" + imedidor.Text + "'";
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

            }
        }
    }
}
