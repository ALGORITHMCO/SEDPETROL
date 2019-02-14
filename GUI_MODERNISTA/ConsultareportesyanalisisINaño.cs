using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class ConsultareportesyanalisisINaño : UserControl
    {

        public String fechainicio;
        public String fechafin;
        public String variable;
        public String departamento;
        public String ciudad;
        public String zona;
        public String localidad;
        public String barrio;
        public String idmedidor;
        

        public ConsultareportesyanalisisINaño()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Consultareportesyanalisis datos = new Consultareportesyanalisis();
            datos.FechaInicio = fechainicio;
            datos.FechaFin = fechafin;
            datos.variableaconsultar = variable;
            datos.departamento = departamento;
            datos.ciudad = ciudad;
            datos.zona = zona;
            datos.localidad = localidad;
            datos.barrio = barrio;
            datos.ID_MEDIDOR = idmedidor;
            dataGridView1.DataSource = Registroo.analisisyreportesAÑO(datos);

            if (dataGridView1.RowCount == 0)
            {

                MessageBox.Show("NO SE ENCONTRERON DATOS", "INTENTE DE NUEVO", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
