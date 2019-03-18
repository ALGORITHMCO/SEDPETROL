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
        Panel panel1;
        int idmedidor1;
        public aNovedad(Panel p)
        {
            panel1 = p;
            
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

            ingresodatoscb.Items.Add("Datos del Propietario");
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

            tipoReporte.Items.Add("Reporte y Análisis Predio Días");
            tipoReporte.Items.Add("Reporte y Análisis Predio Mes");
            tipoReporte.Items.Add("Reporte y Análisis Predio Año");
            tipoReporte.Items.Add("Reporte y Análisis Zona Días");
            tipoReporte.Items.Add("Reporte y Análisis Zona Mes");
            tipoReporte.Items.Add("Reporte y Análisis Zona Año");

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
            }
            nmedidor.DataSource = columnData;
            nmedidor.Text = "";
            idmedidor.Text= "";
            departamento.Text = "";
            ciudad.Text = "";
            zona.Text = "";
            localidad.Text = "";
            barrio.Text = "";
            fraudefluidoscb.Text = "";
            revisionesinternascb.Text = "";
            cortescb.Text = "";
            reconexionescb.Text = "";
            reclamacionescb.Text = "";
            violacionescb.Text = "";
            autoproteccioncb.Text = "";
            evaluacionpromedioscb.Text = "";
            ingresodatoscb.Text = "";
            campo1.Text = "";
            campo2.Text = "";
            campo3.Text = "";
            campo4.Text = "";
            campo5.Text = "";
            tipoReporte.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarNovedades novedad = new AgregarNovedades();

            novedad.fechaingreso = fingnovedad.Text;
            novedad.horaingresonovedad = horaingnov.Text;
            novedad.idmedidor = idmedidor.Text;
            novedad.nmedidor = nmedidor.Text;
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

           
            if (!String.IsNullOrEmpty(nmedidor.Text) && !String.IsNullOrEmpty(fraudefluidoscb.Text) && !String.IsNullOrEmpty(revisionesinternascb.Text) && !String.IsNullOrEmpty(cortescb.Text) && !String.IsNullOrEmpty(reconexionescb.Text) && !String.IsNullOrEmpty(reclamacionescb.Text) && !String.IsNullOrEmpty(violacionescb.Text) && !String.IsNullOrEmpty(autoproteccioncb.Text) && !String.IsNullOrEmpty(evaluacionpromedioscb.Text) && !String.IsNullOrEmpty(ingresodatoscb.Text))
 
            {
                int resul = Registroo.agregarN(novedad);
                if (resul == 1)
                {
                    MessageBox.Show("Datos guardados Correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nmedidor.Text = "";
                    departamento.Text = "";
                    ciudad.Text = "";
                    zona.Text = "";
                    localidad.Text = "";
                    barrio.Text = "";
                    fraudefluidoscb.Text = "";
                    revisionesinternascb.Text = "";
                    cortescb.Text = "";
                    reconexionescb.Text = "";
                    reclamacionescb.Text = "";
                    violacionescb.Text = "";
                    autoproteccioncb.Text = "";
                    evaluacionpromedioscb.Text = "";
                    ingresodatoscb.Text = "";
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

                





            }
        }

        private void ingresodatoscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ingresodatoscb.Text == "Datos del Medidor") {AbrirFormHija(new ingresoDM());}
            if (ingresodatoscb.Text == "Datos del Propietario") { AbrirFormHija(new ingresoDP());}
            if (ingresodatoscb.Text == "Datos de Consumos Anteriores") { tipoReporte.Visible = true;}
            if (ingresodatoscb.Text == "Todos los datos asociados con el medidor") {
                ingresoDMC DMC = new ingresoDMC();
                DMC.idmed = idmedidor.Text;
                AbrirFormHija(DMC);
                
            }

            
        }

        public void AbrirFormHija(object formhija)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();

        }

        private void tipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tipoReporte.Text == "Reporte y Análisis Predio Días") { AbrirFormHija(new reportesyanalisisINID()); }
            if (tipoReporte.Text == "Reporte y Análisis Predio Mes") { AbrirFormHija(new reportesyanalisisINIDmes()); }
            if (tipoReporte.Text == "Reporte y Análisis Predio Año") { AbrirFormHija(new reportesyanalisisINIDaño()); }
            if (tipoReporte.Text == "Reporte y Análisis Zona Días") {AbrirFormHija(new reportesyanalisisINzonas()); }
            if (tipoReporte.Text == "Reporte y Análisis Zona Mes") { AbrirFormHija(new reportesyanalisisINzonasmes());}
            if (tipoReporte.Text == "Reporte y Análisis Zona Año") { AbrirFormHija(new reportesyanalisisINzonasaño()); }
            
        }
    }
}
