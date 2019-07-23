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

            municipio.Items.Add("Almeida");
            municipio.Items.Add("Arcabuco");
            municipio.Items.Add("Aquitania");
            municipio.Items.Add("Belen");
            municipio.Items.Add("Berbeo");
            municipio.Items.Add("Beteitiva");
            municipio.Items.Add("Boavita");
            municipio.Items.Add("Bogotá");
            municipio.Items.Add("Boyaca");
            municipio.Items.Add("Briceño");
            municipio.Items.Add("Buenavista");
            municipio.Items.Add("Busbanza");
            municipio.Items.Add("Caldas");
            municipio.Items.Add("Campohermoso");
            municipio.Items.Add("Cerinza");
            municipio.Items.Add("Chinavita");
            municipio.Items.Add("Chiquinquira");
            municipio.Items.Add("Chiquiza");
            municipio.Items.Add("Chiscas");
            municipio.Items.Add("Chita");
            municipio.Items.Add("Chitaraque");
            municipio.Items.Add("Chivata");
            municipio.Items.Add("Chivor");
            municipio.Items.Add("Cienega");
            municipio.Items.Add("Combita");
            municipio.Items.Add("Coper");
            municipio.Items.Add("Corrales");
            municipio.Items.Add("Covarachia");
            municipio.Items.Add("Cubara");
            municipio.Items.Add("Cucaita");
            municipio.Items.Add("Cuitiva");
            municipio.Items.Add("Duitama");
            municipio.Items.Add("El Cocuy");
            municipio.Items.Add("El Espino");
            municipio.Items.Add("Firavitoba");
            municipio.Items.Add("Floresta");
            municipio.Items.Add("Gachantiva");
            municipio.Items.Add("Gameza");
            municipio.Items.Add("Garagoa");
            municipio.Items.Add("Guateque");
            municipio.Items.Add("Gsican");
            municipio.Items.Add("Guacamayas");
            municipio.Items.Add("Guayata");
            municipio.Items.Add("Iza");
            municipio.Items.Add("Jenesano");
            municipio.Items.Add("Jerico");
            municipio.Items.Add("La Uvita");
            municipio.Items.Add("La Victoria");
            municipio.Items.Add("Labranzagrande");
            municipio.Items.Add("Macanal");
            municipio.Items.Add("Maripi");
            municipio.Items.Add("Miraflores");
            municipio.Items.Add("Mongua");
            municipio.Items.Add("Mongui");
            municipio.Items.Add("Moniquira");
            municipio.Items.Add("Motavita");
            municipio.Items.Add("Muzo");
            municipio.Items.Add("Nobsa");
            municipio.Items.Add("Oicata");
            municipio.Items.Add("Otanche");
            municipio.Items.Add("Pachavita");
            municipio.Items.Add("Paez");
            municipio.Items.Add("Paipa");
            municipio.Items.Add("Pajarito");
            municipio.Items.Add("Panqueba");
            municipio.Items.Add("Pauna");
            municipio.Items.Add("Paya");
            municipio.Items.Add("Paz De Rio");
            municipio.Items.Add("Pesca");
            municipio.Items.Add("Pisba");
            municipio.Items.Add("Puerto Boyaca");
            municipio.Items.Add("Quipama");
            municipio.Items.Add("Ramiriqui");
            municipio.Items.Add("Raquira");
            municipio.Items.Add("Rondon");
            municipio.Items.Add("Saboya");
            municipio.Items.Add("Sachica");
            municipio.Items.Add("Samaca");
            municipio.Items.Add("San Eduardo");
            municipio.Items.Add("San Jose De Pare");
            municipio.Items.Add("San Luis De Gaceno");
            municipio.Items.Add("San Mateo");
            municipio.Items.Add("San Miguel De Sema");
            municipio.Items.Add("San Pablo De Borbur");
            municipio.Items.Add("Santa Maria");
            municipio.Items.Add("Santa Rosa De Viterbo");
            municipio.Items.Add("Santa Sofia");
            municipio.Items.Add("Santana");
            municipio.Items.Add("Sativanorte");
            municipio.Items.Add("Sativasur");
            municipio.Items.Add("Siachoque");
            municipio.Items.Add("Soata");
            municipio.Items.Add("Socha");

            municipio.Items.Add("Sogamoso");
            municipio.Items.Add("Somondoco");
            municipio.Items.Add("Sora");
            municipio.Items.Add("Soraca");
            municipio.Items.Add("Sotaquira");
            municipio.Items.Add("Susacon");
            municipio.Items.Add("Sutamarchan");
            municipio.Items.Add("Sutatenza");
            municipio.Items.Add("Tasco");
            municipio.Items.Add("Tenza");
            municipio.Items.Add("Tibana");
            municipio.Items.Add("Tibasosa");
            municipio.Items.Add("Tinjaca");
            municipio.Items.Add("Tipacoque");
            municipio.Items.Add("Toca");
            municipio.Items.Add("Togsi");
            municipio.Items.Add("Topaga");
            municipio.Items.Add("Tota");
            municipio.Items.Add("Tunja");
            municipio.Items.Add("Tunungua");
            municipio.Items.Add("Turmeque");
            municipio.Items.Add("Tuta");
            municipio.Items.Add("Tutaza");
            municipio.Items.Add("Ventaquemada");
            municipio.Items.Add("Villa De Leyva");
            municipio.Items.Add("Viracacha");
            municipio.Items.Add("Zetaquira");
            municipio.Items.Add("Agua De Dios");
            municipio.Items.Add("Alban");
            municipio.Items.Add("Anapoima");
            municipio.Items.Add("Anolaima");
            municipio.Items.Add("Apulo");
            municipio.Items.Add("Arbelaez");
            municipio.Items.Add("Beltran");
            municipio.Items.Add("Bituima");
            municipio.Items.Add("Bojaca");
            municipio.Items.Add("Cabrera");
            municipio.Items.Add("Cachipay");
            municipio.Items.Add("Cajica");
            municipio.Items.Add("Caparrapi");
            municipio.Items.Add("Caqueza");
            municipio.Items.Add("Carmen De Carupa");
            municipio.Items.Add("Chaguani");
            municipio.Items.Add("Chia");
            municipio.Items.Add("Chipaque");
            municipio.Items.Add("Choachi");
            municipio.Items.Add("Choconta");
            municipio.Items.Add("Cogua");
            municipio.Items.Add("Cota");
            municipio.Items.Add("Cucunuba");
            municipio.Items.Add("El Colegio");
            municipio.Items.Add("El Peñon"); 
            municipio.Items.Add("El Rosal");
            municipio.Items.Add("Facatativa");
            municipio.Items.Add("Fomeque");
            municipio.Items.Add("Fosca");
            municipio.Items.Add("Funza");
            municipio.Items.Add("Fuquene");
            municipio.Items.Add("Fusagasuga");
            municipio.Items.Add("Gachala");
            municipio.Items.Add("Gachancipa");
            municipio.Items.Add("Gacheta");
            municipio.Items.Add("Gama");
            municipio.Items.Add("Girardot");
            municipio.Items.Add("Granada");
            municipio.Items.Add("Guacheta");
            municipio.Items.Add("Guaduas");
            municipio.Items.Add("Guasca");
            municipio.Items.Add("Guataqui");
            municipio.Items.Add("Guatavita");
            municipio.Items.Add("Guayabal De Siquima");
            municipio.Items.Add("Guayabetal");
            municipio.Items.Add("Gutierrez");
            municipio.Items.Add("Jerusalen");
            municipio.Items.Add("Junin");
            municipio.Items.Add("La Calera");
            municipio.Items.Add("La Mesa");
            municipio.Items.Add("La Palma");
            municipio.Items.Add("La Peña");
            municipio.Items.Add("La Vega");
            municipio.Items.Add("Lenguazaque");
            municipio.Items.Add("Macheta");
            municipio.Items.Add("Madrid");
            municipio.Items.Add("Manta");
            municipio.Items.Add("Medina");
            municipio.Items.Add("Mosquera");
            municipio.Items.Add("Nariño");
            municipio.Items.Add("Nemocon");
            municipio.Items.Add("Nilo");
            municipio.Items.Add("Nimaima");
            municipio.Items.Add("Nocaima");
            municipio.Items.Add("Pacho");
            municipio.Items.Add("Paime");
            municipio.Items.Add("Pandi");
            municipio.Items.Add("Paratebueno");
            municipio.Items.Add("Pasca");
            municipio.Items.Add("Puerto Salgar");
            municipio.Items.Add("Puli");
            municipio.Items.Add("Quebradanegra");
            municipio.Items.Add("Quetame");
            municipio.Items.Add("Quipile");
            municipio.Items.Add("Ricaurte");
            municipio.Items.Add("San Antonio Del Tequendama");
            municipio.Items.Add("San Bernardo");
            municipio.Items.Add("San Cayetano");
            municipio.Items.Add("San Francisco");
            municipio.Items.Add("San Juan De Rio Seco");
            municipio.Items.Add("Sasaima");
            municipio.Items.Add("Sesquile");
            municipio.Items.Add("Sibate");



            localidad.Items.Add("Usaquen");
            localidad.Items.Add("Chapinero");
            localidad.Items.Add("Santa Fe");
            localidad.Items.Add("San Cristobal");
            localidad.Items.Add("Usme");
            localidad.Items.Add("Tunjuelito");
            localidad.Items.Add("Bosa");
            localidad.Items.Add("Kennedy");
            localidad.Items.Add("Fontibon");
            localidad.Items.Add("Engativa");
            localidad.Items.Add("Suba");
            localidad.Items.Add("Barrios Unidos ");
            localidad.Items.Add("Teusaquillo");
            localidad.Items.Add("Los Martires");
            localidad.Items.Add("Antonio Nariño");
            localidad.Items.Add("Pte Aranda");
            localidad.Items.Add("La Candelaria");
            localidad.Items.Add("Rafael Uribe Uribe");
            localidad.Items.Add("Ciudad Bolivar");
            localidad.Items.Add("Sumapaz");

            barrio.Items.Add("Modelia");
            barrio.Items.Add("Colina Campestre");
            barrio.Items.Add("La Soledad");
            barrio.Items.Add("Usaquen");
            barrio.Items.Add("La Floresta");
            barrio.Items.Add("Alamos");
            barrio.Items.Add("Las ferias");
            barrio.Items.Add("Minuto de Dios");
            barrio.Items.Add("Santa Isabel");
            barrio.Items.Add("Venecia");
            barrio.Items.Add("Castilla");
            barrio.Items.Add("Prado de veraniego");
            barrio.Items.Add("Rosales");
            barrio.Items.Add("Country");
            barrio.Items.Add("La Calleja");
            barrio.Items.Add("Chico");
            barrio.Items.Add("Patio Bonito");
            barrio.Items.Add("Timiza");
            barrio.Items.Add("Castilla");
            barrio.Items.Add("Sotileza");
            barrio.Items.Add("Galerias");
            barrio.Items.Add("La Macarena");
            


        }

        int a;
        String b;
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

                string query1 = "SELECT ID_MEDIDOR FROM MEDIDOR WHERE ID_MEDIDOR=(SELECT MAX(ID_MEDIDOR) FROM MEDIDOR)";
                using (SqlCommand command = new SqlCommand(query1, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            //a = Convert.ToString(reader.GetInt32(0));
                            a = reader.GetInt32(0);
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

                //string query3 = "SELECT MEDIDOR.NU_MEDIDOR FROM MEDIDOR WHERE MEDIDOR.ID MEDIDOR='" + a +"'";

                //using (SqlCommand command = new SqlCommand(query3, cone))
                //{
                //    using (SqlDataReader reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            //columnData.Add(reader.GetString(0));

                //            //label25.Text = Convert.ToString(reader.GetInt32(0)+1);
                //            label25.Text= reader.GetValue(0).ToString();
                //        }
                //    }
                //}

                string query4 = "SELECT MEDIDOR.NU_MEDIDOR FROM MEDIDOR WHERE MEDIDOR.ID_MEDIDOR='" + a + "'";
                using (SqlCommand command = new SqlCommand(query4, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            label25.Text = reader.GetValue(0).ToString();
                            //label25.Text= Convert.ToString(reader.GetInt32(0) + 1);
                        }
                    }
                }
            }
            //marca.DataSource = columnData;


            idpropietario.DataSource= columnData;
            b = label25.Text;
            int number;
            int.TryParse(b, out number);
            number = number + 1;
            label25.Text = number.ToString();
            cuentacontrato.Text ="";
            
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
            departamento.Text = "";
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
        private void panelContenedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
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
                medidor.numeromedidor = label25.Text;
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

                medidor.idpredio = label23.Text;
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

                if (idm != cuentacontrato.Text)
                {
                    if (!String.IsNullOrEmpty(cuentacontrato.Text) && !String.IsNullOrEmpty(marca.Text) && !String.IsNullOrEmpty(tipo.Text) && !String.IsNullOrEmpty(ultimalectura.Text) && !String.IsNullOrEmpty(lecturaanterior.Text) && !String.IsNullOrEmpty(ultimalectura.Text))
                    {
                        int resul1 = Registroo.ingresarPredio(medidor);
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
                            departamento.Text = "";
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
                else
                {

                    MessageBox.Show("Esta cuenta contrato ya esta asociada a un medidor", "ERROR AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
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
            medidor.numeromedidor = label25.Text;
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

            medidor.idpredio = label23.Text;
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
            if (!String.IsNullOrEmpty(cuentacontrato.Text) && !String.IsNullOrEmpty(marca.Text) && !String.IsNullOrEmpty(tipo.Text) && !String.IsNullOrEmpty(ultimalectura.Text) && !String.IsNullOrEmpty(lecturaanterior.Text) && !String.IsNullOrEmpty(ultimalectura.Text))
            {
                    int resul1 = Registroo.ingresarPredio(medidor);
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
                    departamento.Text = "";
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

        private void matriculainmobiliaria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
