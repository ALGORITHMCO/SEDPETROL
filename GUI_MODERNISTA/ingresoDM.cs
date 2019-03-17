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
            //marca.DataSource = columnData;
            
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

            int resul = Registroo.ingresarMedidor(medidor);

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

        
    }
}
