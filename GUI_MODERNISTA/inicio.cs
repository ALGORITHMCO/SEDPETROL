﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    public partial class inicio : Form
    {

        Panel panel; 
        public inicio(Panel p)
        {
            InitializeComponent();
            panel = p; 
        }

       

        private void inicio_Resize(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void panelContenedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                DatosRegis datos = new DatosRegis();
                datos.usuario = alphaBlendTextBox1.Text;
                datos.contraseña = alphaBlendTextBox2.Text;

                int resul = Registroo.login(datos);

                if (resul == 1)
                {
                    AbrirFormHija(new consulta());
                }
                else
                {

                    MessageBox.Show("Usuario o contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        private void button2_Click(object sender, EventArgs e)
        {

            DatosRegis datos = new DatosRegis();
            datos.usuario =alphaBlendTextBox1.Text;
            datos.contraseña = alphaBlendTextBox2.Text;

            int resul = Registroo.login(datos);

            if (resul == 1)
            {
                AbrirFormHija(new consulta());
            }
            else
            {
               
                    MessageBox.Show("Usuario o contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
           
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel.Controls.Add(fh);
            this.panel.Tag = fh;
            fh.Show();

        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void alphaBlendTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                DatosRegis datos = new DatosRegis();
                datos.usuario = alphaBlendTextBox1.Text;
                datos.contraseña = alphaBlendTextBox2.Text;

                int resul = Registroo.login(datos); 

                if (resul == 1)
                {
                    AbrirFormHija(new consulta());
                }
                else
                {

                    MessageBox.Show("Usuario o contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }
    }
}
