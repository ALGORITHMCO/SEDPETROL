<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿
=======
=======
>>>>>>> parent of 01c744a... Merge branch 'master' of https://github.com/ALGORITHMCO/SEDPETROL
=======
>>>>>>> parent of 01c744a... Merge branch 'master' of https://github.com/ALGORITHMCO/SEDPETROL
=======
>>>>>>> parent of 01c744a... Merge branch 'master' of https://github.com/ALGORITHMCO/SEDPETROL
﻿using System;
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
    public partial class inicioadministrador: Form
    {
        public inicioadministrador()
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
           // AbrirFormHija(new Login());
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            
        }

        private void bousuarios_Click(object sender, EventArgs e)
        {
            Loginn formaSiguiente = new Loginn();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void panelContenedor_Resize(object sender, EventArgs e)
        {
           

          
        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 01c744a... Merge branch 'master' of https://github.com/ALGORITHMCO/SEDPETROL
=======
>>>>>>> parent of 01c744a... Merge branch 'master' of https://github.com/ALGORITHMCO/SEDPETROL
        private void panelContenedor_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyValue == (char)Keys.Enter) {
                if (TextBox1.Text != "admi1" && TextBox2.Text != "admi1")
                {
                    // si funciono esta madre
                    MessageBox.Show("Usuario o contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    portaladministrador formaSiguiente = new portaladministrador();
                    this.Hide(); //oculta la forma actual
                    formaSiguiente.Show();
                }// muestra la forma2
            }
        }
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> parent of 01c744a... Merge branch 'master' of https://github.com/ALGORITHMCO/SEDPETROL
=======
>>>>>>> parent of 01c744a... Merge branch 'master' of https://github.com/ALGORITHMCO/SEDPETROL
=======
>>>>>>> parent of 01c744a... Merge branch 'master' of https://github.com/ALGORITHMCO/SEDPETROL

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "admi1" && TextBox2.Text != "admi1")
            {  
                // si funciono esta madre
                MessageBox.Show("Usuario o contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                portaladministrador formaSiguiente = new portaladministrador();
                this.Hide(); //oculta la forma actual
                formaSiguiente.Show();
            }// muestra la forma2
        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    }
}
>>>>>>> parent of 96aa6a1... cambios
=======
=======
>>>>>>> parent of 01c744a... Merge branch 'master' of https://github.com/ALGORITHMCO/SEDPETROL
=======
>>>>>>> parent of 01c744a... Merge branch 'master' of https://github.com/ALGORITHMCO/SEDPETROL

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> parent of 01c744a... Merge branch 'master' of https://github.com/ALGORITHMCO/SEDPETROL
=======
>>>>>>> parent of 01c744a... Merge branch 'master' of https://github.com/ALGORITHMCO/SEDPETROL
=======
>>>>>>> parent of 01c744a... Merge branch 'master' of https://github.com/ALGORITHMCO/SEDPETROL
