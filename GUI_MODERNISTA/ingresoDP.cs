﻿using System;
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
    public partial class ingresoDP : Form
    {
        String idpropietario;
        public ingresoDP()
        {


            InitializeComponent();
            fingnovedad.Text = DateTime.Now.ToShortDateString();
            horaingnov.Text = DateTime.Now.ToShortTimeString();



            tipoIdentificacion.Items.Add("CC");
            tipoIdentificacion.Items.Add("CE");
            tipoIdentificacion.Items.Add("Otro");
            tipoIdentificacion.Items.Add("NIT");
            tipoIdentificacion.Items.Add("TP");
            tipoIdentificacion.Items.Add("TI");

            porcentajePropiedad.Items.Add("10");
            porcentajePropiedad.Items.Add("20");
            porcentajePropiedad.Items.Add("30");
            porcentajePropiedad.Items.Add("40");
            porcentajePropiedad.Items.Add("50");
            porcentajePropiedad.Items.Add("60");
            porcentajePropiedad.Items.Add("70");
            porcentajePropiedad.Items.Add("80");
            porcentajePropiedad.Items.Add("90");
            porcentajePropiedad.Items.Add("100");


            calidadPropietario.Items.Add("Propietario");
            calidadPropietario.Items.Add("Proseedor");
            calidadPropietario.Items.Add("Tenedor");
            calidadPropietario.Items.Add("Usufructuario");
            calidadPropietario.Items.Add("Perito");
            calidadPropietario.Items.Add("Sucesion");
            calidadPropietario.Items.Add("Comodato");
            calidadPropietario.Items.Add("Arrendatario");

            estado.Items.Add("Activo");
            estado.Items.Add("Inactivo");
            estado.Items.Add("Suspendido");
            estado.Items.Add("Otro");

        }



        
        

        private void Registro_Load(object sender, EventArgs e)
        {
            
            List<String> columnData = new List<String>();

            using (SqlConnection cone = conexion.conectarbd())
            {

                string query = "SELECT ID_PROPIETARIO FROM PROPIETARIO WHERE ID_PROPIETARIO=(SELECT MAX(ID_PROPIETARIO) FROM PROPIETARIO)";
                using (SqlCommand command = new SqlCommand(query, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            idpropietario1.Text = Convert.ToString(reader.GetInt32(0) + 1);
                        }
                    }
                }
            }
            ////marca.DataSource = columnData;
            tipoIdentificacion.Text = "";
            numeroIdentificacion.Text = "";
            nombrePropietario.Text = "";
            porcentajePropiedad.Text = "";
            calidadPropietario.Text = "";
            cuentaContrato.Text = "";
            estado.Text = "";
            campo1.Text = "";
            campo2.Text = "";
            campo3.Text = "";
            campo4.Text = "";
            campo5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresoDatosPropietario propietario = new IngresoDatosPropietario();

            propietario.idpropietario = idpropietario1.Text;
            propietario.tipoidentificacion = tipoIdentificacion.Text;
            propietario.numeroidentificacion = numeroIdentificacion.Text;
            propietario.nombrepropietario = nombrePropietario.Text;
            propietario.porcentajepropiedad = porcentajePropiedad.Text;
            propietario.calidadpropietario = calidadPropietario.Text;
            propietario.cuentacontrato = cuentaContrato.Text;
            propietario.estado = estado.Text;
            propietario.campo1 = campo1.Text;
            propietario.campo2 = campo2.Text;
            propietario.campo3 = campo3.Text;
            propietario.campo4 = campo4.Text;
            propietario.campo5 = campo5.Text;

            //if (!String.IsNullOrEmpty(tipoIdentificacion.Text) && !String.IsNullOrEmpty(numeroIdentificacion.Text) && !String.IsNullOrEmpty(nombrePropietario.Text) && !String.IsNullOrEmpty(porcentajePropiedad.Text) && !String.IsNullOrEmpty(calidadPropietario.Text) && !String.IsNullOrEmpty(cuentaContrato.Text))
            //{ 
            int resul = Registroo.ingresarPropietario(propietario);

            if (resul == 1)
            {
                MessageBox.Show("Datos guardados Correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tipoIdentificacion.Text = "";
                    numeroIdentificacion.Text = "";
                    nombrePropietario.Text = "";
                    porcentajePropiedad.Text = "";
                    calidadPropietario.Text = "";
                    cuentaContrato.Text = "";
                    estado.Text = "";
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
            //else
            //{
            //        MessageBox.Show("Debe llenar todos los campos", "ERROR AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        //}

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBox2.Items.Add("Hola");


            
        }

        
    }
}
