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
    public partial class aNovedad : Form
    {
        public aNovedad()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarNovedades novedad = new AgregarNovedades();

            //novedad.usuarios = textusuario.Text;
            //novedad.nombres = textnombre.Text;
            //novedad.contraseñas = textcontra.Text;
            //novedad.correos = textcorreo.Text;

            novedad.fechaingreso = fechaingnove.Text;
            novedad.horaingresonovedad = horaingresonove.Text;
            novedad.idmedidor = idmedidor.Text;
            novedad.revisionesinternas = revisionesinternas.Text;
            novedad.cortes = cortes.Text;
            novedad.reconexiones = reconexiones.Text;
            novedad.fraudefluidos = fraudefluido.Text;
            novedad.reclamaciones = reclamaciones.Text;
            novedad.violaciones = violaciones.Text;
            novedad.autoproteccion = autoproteccion.Text;
            novedad.evaluaciondepromedios = evaluacionpromedios.Text;
            novedad.ingresodatosprimeravez = ingresodatosprimeravez.Text;
            novedad.campo1 = campo1.Text;
            novedad.campo2 = campo2.Text;
            novedad.campo3 = campo3.Text;
            novedad.campo4 = campo4.Text;
            novedad.campo5 = campo5.Text;
        



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

            int resul = Registroo.agregarN(novedad);

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
    }
}