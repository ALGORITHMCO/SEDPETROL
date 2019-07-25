using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI_MODERNISTA
{
    public partial class portausuarios : Form
    {
        public String cuenta; 
        public static string cuen; 
        public portausuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click(null ,e);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            consulta formaSiguiente = new consulta();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void btnrptcompra_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            Loginn formaSiguiente = new Loginn();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            Inicioo formaSiguiente = new Inicioo();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            

        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
           AbrirFormHija(new Consultamedidor());
          

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            cuen = cuenta; 
            Consultamedidor medi = new Consultamedidor();
            medi.nucue = cuen;
            con.Text = cuen; 
            AbrirFormHija(new Consultamedidor());
        }

        private void BTNventas_Click(object sender, EventArgs e)
        {

            
            AbrirFormHija(new ConsultaAlimentacion());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Show();
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
