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
    public partial class portaladministrador : Form
    {
        public String cuenta; 
        public static string cuen; 
        public portaladministrador()
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
            AbrirFormHija(new alertasaguasno());
            submenu2.Visible = false;
            SubmenuReportes.Visible = false;
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {

            AbrirFormHija(new reportesyanalisisINID());
            SubmenuReportes.Visible = false;
        }

        private void btnrptcompra_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new reportesyanalisisINIDmes());
            SubmenuReportes.Visible = false;
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new reportesyanalisisINIDaño());
            SubmenuReportes.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void AbrirFormHija(object formhija)
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
            if(SubmenuReportes.Visible == true)
            {
                SubmenuReportes.Visible = false; 
            }
            else
            {
                SubmenuReportes.Visible = true; 
            }

            submenu2.Visible = false;

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            
            AbrirFormHija(new reportesyanalisisINID());
        }

        private void BTNventas_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;

            if (submenu2.Visible == true)
            {
                submenu2.Visible = false;
            }
            else
            {
                submenu2.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //submenu2.Visible = false;
            //SubmenuReportes.Visible = false;
            //AbrirFormHija(new ConsultaFacturaPropietario());
            Factura factura = new Factura();
            factura.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Inicioo formaSiguiente = new Inicioo();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void button4_Click(object sender, EventArgs e)
        {

            submenu2.Visible = false;
            SubmenuReportes.Visible = false;
            AbrirFormHija(new aNovedad());
        }

        private void button5_Click(object sender, EventArgs e)
        {

            submenu2.Visible = false;
            SubmenuReportes.Visible = false;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            AbrirFormHija(new reportesyanalisisINzonas());
            submenu2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new reportesyanalisisINzonasaño());
            submenu2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new reportesyanalisisINzonasmes());
            submenu2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new aPQRS());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new ingresoDM());
        }
    }
}
