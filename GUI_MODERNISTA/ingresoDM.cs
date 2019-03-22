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
    public partial class ingresoDM : Form
    {

        String idmedidor;
        String idpredio;
        String idm;
        public ingresoDM()
        {


            InitializeComponent();
            fingnovedad.Text = DateTime.Now.ToShortDateString();
            horaingnov.Text = DateTime.Now.ToShortTimeString();

            tipo.Items.Add("Velo015C");
            tipo.Items.Add("Velo030C");
            tipo.Items.Add("Velo060C");
            tipo.Items.Add("Velo090C");
            

            marca.Items.Add("Aquasoft");
            marca.Items.Add("Watertech");

            diametro.Items.Add("1/4''");
            departamento.Items.Add("Amazonas");
            departamento.Items.Add("Antioquia");
            departamento.Items.Add("Arauca");
            departamento.Items.Add("Atlantico");
            departamento.Items.Add("Bolivar");
            departamento.Items.Add("Boyacá");
            departamento.Items.Add("Caldas");
            departamento.Items.Add("Caqueta");
            departamento.Items.Add("Casanare");
            departamento.Items.Add("Cauca");
            departamento.Items.Add("Cesar");
            departamento.Items.Add("Choco");
            departamento.Items.Add("Cundinamarca");
            departamento.Items.Add("Cordoba");
            departamento.Items.Add("Guainia");
            departamento.Items.Add("Guaviare");
            departamento.Items.Add("Huila");
            departamento.Items.Add("La Guajira");
            departamento.Items.Add("Magdalena");
            departamento.Items.Add("Meta");
            departamento.Items.Add("Nariño");
            departamento.Items.Add("Norte de Santander");
            departamento.Items.Add("Putumayo");
            departamento.Items.Add("Quindio");
            departamento.Items.Add("Risaralda");
            departamento.Items.Add("San Andres y Providencia");
            departamento.Items.Add("Santander");
            departamento.Items.Add("Sucre");
            departamento.Items.Add("Tolima");
            departamento.Items.Add("Valle del Cauca");
            departamento.Items.Add("Vaupes");
            departamento.Items.Add("Vichada");




        }


        private void Registro_Load(object sender, EventArgs e)
        {
            //comboBox2.Items.Add("Hola");
            List<String> columnData = new List<String>();

            using (SqlConnection cone = conexion.conectarbd())
            {
                
                string query = "SELECT ID_PROPIETARIO FROM PROPIETARIO";
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

                string query1 = "SELECT ID_MEDIDOR FROM ALIMENTACION_HISTORICA WHERE ID_MEDIDOR=(SELECT MAX(ID_MEDIDOR) FROM ALIMENTACION_HISTORICA)";
                using (SqlCommand command = new SqlCommand(query1, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));

                            label22.Text = Convert.ToString(reader.GetInt32(0) + 1);
                        }
                    }
                }

                string query2 = "SELECT ID_PREDIO FROM PREDIO WHERE ID_PREDIO=(SELECT MAX(ID_PREDIO) FROM PREDIO)";
                using (SqlCommand command = new SqlCommand(query2, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));

                            label23.Text = Convert.ToString(reader.GetInt32(0) + 1);
                        }
                    }
                }


            }
            //marca.DataSource = columnData;

            idpropietario.DataSource= columnData;
            cuentacontrato.Text ="";
            numeromedidor.Text = "";
            marca.Text = "";
            tipo.Text = "";
            ultimalectura.Text = "";
            lecturaanterior.Text = "";
            consumom3.Text = "";
            diametro.Text = "";
            campo1.Text = "";
            campo2.Text = "";
            campo3.Text = "";
            campo4.Text = "";
            campo5.Text = "";
            idpropietario.Text = "";
            idchip.Text = "";
            matriculainmobiliaria.Text = "";
            direccion.Text = "";
            municipio.Text = "";
            localidad.Text = "";
            barrio.Text = "";
            estrato.Text = "";
            claseuso.Text = "";
            unidadhab.Text = "";
            unidadnohab.Text = "";
            zona.Text = "";
            ciclo.Text = "";
            ruta.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresoDatosMedidor medidor = new IngresoDatosMedidor();

            //novedad.usuarios = textusuario.Text;
            //novedad.nombres = textnombre.Text;
            //novedad.contraseñas = textcontra.Text;
            //novedad.correos = textcorreo.Text;

            //novedad.fechaingreso = fechaingnove.Text;
            //novedad.horaingresonovedad = horaingresonove.Text;
            //novedad.fechaingreso = fecha.Text;

            medidor.idmedidor = idmedidor;
            medidor.cuentacontrato = cuentacontrato.Text;
            medidor.numeromedidor = numeromedidor.Text;
            //novedad.horaingresonovedad = horaingresonove.Text;
            medidor.marca = marca.Text;
            medidor.tipo = tipo.Text;
            medidor.ultimalectura = ultimalectura.Text;
            medidor.lecturaanterior = lecturaanterior.Text;
            medidor.consumom3 = consumom3.Text;
            medidor.diametro = diametro.Text;
            medidor.campo1 = campo1.Text;
            medidor.campo2 = campo2.Text;
            medidor.campo3 = campo3.Text;
            medidor.campo4 = campo4.Text;
            medidor.campo5 = campo5.Text;

            medidor.idpredio = idpredio;
            medidor.idpropietario = idpropietario.Text;
            medidor.idchip = idchip.Text;
            medidor.matriculainmobiliaria = matriculainmobiliaria.Text;
            medidor.direccion = direccion.Text;
            medidor.departamento = departamento.Text;
            medidor.municipio = municipio.Text;
            medidor.localidad = localidad.Text;
            medidor.barrio = barrio.Text;
            medidor.estrato = estrato.Text;
            medidor.claseuso = claseuso.Text;
            medidor.unidadhabitacional = unidadhab.Text;
            medidor.unidadnohabitacional = unidadnohab.Text;
            medidor.zona = zona.Text;
            medidor.ciclo = ciclo.Text;
            medidor.ruta = ruta.Text;
            using (SqlConnection cone = conexion.conectarbd())
            {
                string query1 = "SELECT MEDIDOR.CUENTA_CONTRATO FROM MEDIDOR WHERE MEDIDOR.NU_MEDIDOR='" + numeromedidor.Text + "'";
                using (SqlCommand command = new SqlCommand(query1, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                          
                            idm = reader.GetValue(0).ToString();
                            
                        }
                    }
                }
            }

            if (idm!=cuentacontrato.Text)
            { 
            if (!String.IsNullOrEmpty(cuentacontrato.Text) && !String.IsNullOrEmpty(numeromedidor.Text) && !String.IsNullOrEmpty(marca.Text) && !String.IsNullOrEmpty(tipo.Text) && !String.IsNullOrEmpty(ultimalectura.Text) && !String.IsNullOrEmpty(lecturaanterior.Text) && !String.IsNullOrEmpty(ultimalectura.Text))
            { 
                int resul = Registroo.ingresarMedidor(medidor);

            if (resul == 1)
            {
                MessageBox.Show("Datos guardados Correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cuentacontrato.Text = "";
                    numeromedidor.Text = "";
                    marca.Text = "";
                    tipo.Text = "";
                    ultimalectura.Text = "";
                    lecturaanterior.Text = "";
                    consumom3.Text = "";
                    diametro.Text = "";
                    campo1.Text = "";
                    campo2.Text = "";
                    campo3.Text = "";
                    campo4.Text = "";
                    campo5.Text = "";
                    idpropietario.Text = "";
                    idchip.Text = "";
                    matriculainmobiliaria.Text = "";
                    direccion.Text = "";
                    municipio.Text = "";
                    localidad.Text = "";
                    barrio.Text = "";
                    estrato.Text = "";
                    claseuso.Text = "";
                    unidadhab.Text = "";
                    unidadnohab.Text = "";
                    zona.Text = "";
                    ciclo.Text = "";
                    ruta.Text = "";

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
            else {

                MessageBox.Show("Esta cuenta contrato ya esta asociada a un medidor", "ERROR AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBox2.Items.Add("Hola");


            
        }

        
    }
}
