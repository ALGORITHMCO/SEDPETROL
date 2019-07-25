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
    public partial class ingresoCA : Form
    {

        String idmedidor;
        String idpredio;
        String idm;
        public ingresoCA()
        {
            InitializeComponent();
            fingnovedad.Text = DateTime.Now.ToShortDateString();
            horaingnov.Text = DateTime.Now.ToShortTimeString();

            facturadocon.Items.Add("Reajuste");
            facturadocon.Items.Add("Consumo Normal");
            facturadocon.Items.Add("Consumo Promedio");
            facturadocon.Items.Add("Reclamación");
            facturadocon.Items.Add("Mínimo Vital");
            facturadocon.Items.Add("Otros");
            facturadocon.Items.Add("N/A");

        }

        int a;
        String b;
        private void Registro_Load(object sender, EventArgs e)
        {
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

                string query2 = "SELECT ID_FACTURAS FROM FACTURAS WHERE ID_FACTURAS=(SELECT MAX(ID_FACTURAS) FROM FACTURAS)";
                using (SqlCommand command = new SqlCommand(query2, cone))
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

         

                string query4 = "SELECT MEDIDOR.NU_MEDIDOR FROM MEDIDOR WHERE MEDIDOR.ID_MEDIDOR='" + a + "'";
                using (SqlCommand command = new SqlCommand(query4, cone))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //columnData.Add(reader.GetString(0));
                            //label25.Text = reader.GetValue(0).ToString();
                            //label25.Text= Convert.ToString(reader.GetInt32(0) + 1);
                        }
                    }
                }
            }
            idmedidor1.DataSource = columnData;

            idfacturas.Text = "";
            idmedidor1.Text = "";
            empresa.Text = "";
            facturano.Text = "";
            consumo.Text = "";
            periodo1.Text = "";
            periodo2.Text = "";
            periodo3.Text = "";
            periodo4.Text = "";
            periodo5.Text = "";
            periodo6.Text = "";
            consumopromedio.Text = "";
            periodoafacturar.Text = "";
            facturadocon.Text = "";
            descarguefte.Text = "";
            totalapagar.Text = "";
            fechaltepago.Text = "";
            fechapagoo.Text = "";
            ctacontrato.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresoConsumosAnteriores consumos = new IngresoConsumosAnteriores();


            consumos.idmedidor = idmedidor1.Text;
            consumos.idfactura = idfacturas.Text;
            consumos.empresa = empresa.Text;
            consumos.facturaspno = idmedidor1.Text;
            consumos.consumom3 = consumo.Text;
            consumos.periodo1 = periodo2.Text;
            consumos.periodo2 = periodo3.Text;
            consumos.periodo3 = periodo4.Text;
            consumos.periodo4 = periodo5.Text;
            consumos.periodo5 = periodo6.Text;

            consumos.consumopromedio = consumopromedio.Text;
            consumos.periodoafacturar = periodoafacturar.Text;
            consumos.facturadocon = facturadocon.Text;
            consumos.descarguefuente = descarguefte.Text;
            consumos.totalapagar = totalapagar.Text;
            DateTime date = Convert.ToDateTime(fechaltepago.Text);
            DateTime date1 = Convert.ToDateTime(fechapagoo.Text);
            consumos.fechalimitepago = date;
            consumos.fechapagoportuno =date1;
            consumos.cuentacontrato = ctacontrato.Text;




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

            //if (idm != facturano.Text)
            //{
                //if (!String.IsNullOrEmpty(idfacturas.Text) && !String.IsNullOrEmpty(idmedidor1.Text) && !String.IsNullOrEmpty(empresa.Text) && !String.IsNullOrEmpty(facturano.Text) && !String.IsNullOrEmpty(consumo.Text) && !String.IsNullOrEmpty(periodo1.Text))
                //{
                    int resul = Registroo.ingresarCA(consumos);



                    if (resul == 1)
                    {
                        MessageBox.Show("Datos guardados Correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idfacturas.Text = "";
                        idmedidor1.Text = "";
                        empresa.Text = "";
                        facturano.Text = "";
                        consumo.Text = "";
                        periodo1.Text = "";
                        periodo2.Text = "";
                        periodo3.Text = "";
                        periodo4.Text = "";
                        periodo5.Text = "";
                        periodo6.Text = "";
                        consumopromedio.Text = "";
                        periodoafacturar.Text = "";
                        facturadocon.Text = "";
                        descarguefte.Text = "";
                        totalapagar.Text = "";
                        fechaltepago.Text = "";
                        fechapagoo.Text = "";
                        ctacontrato.Text = "";


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
        //        }
        //    else
        //    {
        //        MessageBox.Show("Debe llenar todos los campos", "ERROR AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}
            //else {

            //    MessageBox.Show("Esta cuenta contrato ya esta asociada a un medidor", "ERROR AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //}
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
