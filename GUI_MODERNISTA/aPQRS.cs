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
    public partial class aPQRS : Form
    {

        String idmedidor;
        public aPQRS()
        {
            InitializeComponent();
            fingPQRS.Text = DateTime.Now.ToShortDateString();
            horaingPQRS.Text = DateTime.Now.ToShortTimeString();

            using (SqlConnection cone = conexion.conectarbd()) { 
            string query1 = "SELECT ID_PQRS FROM  PQRS WHERE ID_PQRS=(SELECT MAX(ID_PQRS) FROM PQRS)";
            using (SqlCommand command = new SqlCommand(query1, cone))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //columnData.Add(reader.GetString(0));
                        
                        label6.Text=Convert.ToString(reader.GetInt32(0)+1);
                    }
                }
            }
            }



            tipodesolicitud.Items.Add("Reclamo");
            tipodesolicitud.Items.Add("Facturación");
            tipodesolicitud.Items.Add("Sugerencia");
            tipodesolicitud.Items.Add("Derecho de Petición");
            tipodesolicitud.Items.Add("Recurso de Reposición");
            tipodesolicitud.Items.Add("Recurso de Reposición (en apelación)");
            tipodesolicitud.Items.Add("Otros");
            tipodesolicitud.Items.Add("N/A");

            consultaestadoPQRS.Items.Add("Aceptada");
            consultaestadoPQRS.Items.Add("Rechazada");
            consultaestadoPQRS.Items.Add("Incompleta");
            consultaestadoPQRS.Items.Add("En curso");
            consultaestadoPQRS.Items.Add("Desistimiento");
            consultaestadoPQRS.Items.Add("Otros");
            consultaestadoPQRS.Items.Add("N/A");

            dañopresentadoen.Items.Add("Medidor");
            dañopresentadoen.Items.Add("Acometida");
            dañopresentadoen.Items.Add("Red de Distribición");
            dañopresentadoen.Items.Add("Otros");
            dañopresentadoen.Items.Add("N/A");

        }



        
        

        private void Registro_Load(object sender, EventArgs e)
        {
            //comboBox2.Items.Add("Hola");
            List<String> columnData = new List<String>();

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

            List<String> columnData1 = new List<String>();

            //using (SqlConnection cone = conexion.conectarbd())
            //{

            //    string query1 = "SELECT Id FROM  Usuarios";
            //    using (SqlCommand command = new SqlCommand(query1, cone))
            //    {
            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                //columnData.Add(reader.GetString(0));
            //                columnData1.Add(reader.GetValue(0).ToString());
            //            }
            //        }
            //    }
            //}
            //iusuario.DataSource = columnData1;
            nmedidor.Text = "";
            departamento.Text = "";
            ciudad.Text = "";
            zona.Text = "";
            localidad.Text = "";
            barrio.Text = "";
            npeticionario.Text = "";
            identificacion.Text = "";
            direccion.Text = "";
            telefonofijo.Text = "";
            celular.Text = "";
            correo.Text = "";
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarPQRS PQRS = new AgregarPQRS();

            PQRS.idmedidor = idmedidor;
            PQRS.fechaingreso = fingPQRS.Text;
            PQRS.horaingreso = horaingPQRS.Text;
            PQRS.nombrepeticionario = npeticionario.Text;
            PQRS.identificacion = identificacion.Text;
            PQRS.direccion = direccion.Text;
            PQRS.telefonofijo = telefonofijo.Text;
            PQRS.celular = celular.Text;
            PQRS.correoelectronico = correo.Text;
            PQRS.descripciónPQRS = descripcionPQRS.Text;
            PQRS.tipodesolicitud = tipodesolicitud.Text;
            PQRS.dañopresentado = dañopresentadoen.Text;
            PQRS.consultaestadoPQRS = consultaestadoPQRS.Text;
            PQRS.campo1 = campo1.Text;
            PQRS.campo2 = campo2.Text;
            PQRS.campo3 = campo3.Text;
            PQRS.campo4 = campo4.Text;
            PQRS.campo5 = campo5.Text;


            if (!String.IsNullOrEmpty(nmedidor.Text) && !String.IsNullOrEmpty(npeticionario.Text) && !String.IsNullOrEmpty(descripcionPQRS.Text) && !String.IsNullOrEmpty(tipodesolicitud.Text) && !String.IsNullOrEmpty(dañopresentadoen.Text) && !String.IsNullOrEmpty(consultaestadoPQRS.Text))
            { 
            //if (nmedidor.Text !="" & iusuario.Text != "") {
                int resul = Registroo.agregarPQRS(PQRS);
                if (resul == 1)
            {
                MessageBox.Show("Datos guardados Correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nmedidor.Text = "";
                    departamento.Text = "";
                    ciudad.Text = "";
                    zona.Text = "";
                    localidad.Text = "";
                    barrio.Text = "";
                    npeticionario.Text = "";
                    identificacion.Text = "";
                    direccion.Text = "";
                    telefonofijo.Text = "";
                    celular.Text = "";
                    correo.Text = "";
                    descripcionPQRS.Text = "";
                    tipodesolicitud.Text = "";
                    dañopresentadoen.Text = "";
                    consultaestadoPQRS.Text = "";
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
            else {  
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


        private void nmedidor_SelectedIndexChanged(object sender, EventArgs e)
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
                            idmedidor = reader.GetValue(0).ToString();
                        }
                    }
                }
            }

        }


      

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dañopresentadoen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                AgregarPQRS PQRS = new AgregarPQRS();

                PQRS.idmedidor = idmedidor;
                PQRS.fechaingreso = fingPQRS.Text;
                PQRS.horaingreso = horaingPQRS.Text;
                PQRS.nombrepeticionario = npeticionario.Text;
                PQRS.identificacion = identificacion.Text;
                PQRS.direccion = direccion.Text;
                PQRS.telefonofijo = telefonofijo.Text;
                PQRS.celular = celular.Text;
                PQRS.correoelectronico = correo.Text;
                PQRS.descripciónPQRS = descripcionPQRS.Text;
                PQRS.tipodesolicitud = tipodesolicitud.Text;
                PQRS.dañopresentado = dañopresentadoen.Text;
                PQRS.consultaestadoPQRS = consultaestadoPQRS.Text;
                PQRS.campo1 = campo1.Text;
                PQRS.campo2 = campo2.Text;
                PQRS.campo3 = campo3.Text;
                PQRS.campo4 = campo4.Text;
                PQRS.campo5 = campo5.Text;


                if (!String.IsNullOrEmpty(nmedidor.Text) && !String.IsNullOrEmpty(npeticionario.Text) && !String.IsNullOrEmpty(descripcionPQRS.Text) && !String.IsNullOrEmpty(tipodesolicitud.Text) && !String.IsNullOrEmpty(dañopresentadoen.Text) && !String.IsNullOrEmpty(consultaestadoPQRS.Text))
                {
                    //if (nmedidor.Text !="" & iusuario.Text != "") {
                    int resul = Registroo.agregarPQRS(PQRS);
                    if (resul == 1)
                    {
                        MessageBox.Show("Datos guardados Correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nmedidor.Text = "";
                        departamento.Text = "";
                        ciudad.Text = "";
                        zona.Text = "";
                        localidad.Text = "";
                        barrio.Text = "";
                        npeticionario.Text = "";
                        identificacion.Text = "";
                        direccion.Text = "";
                        telefonofijo.Text = "";
                        celular.Text = "";
                        correo.Text = "";
                        descripcionPQRS.Text = "";
                        tipodesolicitud.Text = "";
                        dañopresentadoen.Text = "";
                        consultaestadoPQRS.Text = "";
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
        }
    }
}
