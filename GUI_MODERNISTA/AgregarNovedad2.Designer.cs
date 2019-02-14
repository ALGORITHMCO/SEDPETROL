namespace GUI_MODERNISTA
{
    partial class AgregarNovedad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fechaingreso = new System.Windows.Forms.TextBox();
            this.lfechaingreso = new System.Windows.Forms.Label();
            this.lhoraingreso = new System.Windows.Forms.Label();
            this.horaingreso = new System.Windows.Forms.TextBox();
            this.lidnovedad = new System.Windows.Forms.Label();
            this.idnovedad = new System.Windows.Forms.TextBox();
            this.lidmedidor = new System.Windows.Forms.Label();
            this.idmedidor = new System.Windows.Forms.TextBox();
            this.ldepartamento = new System.Windows.Forms.Label();
            this.departamento = new System.Windows.Forms.TextBox();
            this.lciudad = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.lreconexiones = new System.Windows.Forms.Label();
            this.reconexiones = new System.Windows.Forms.TextBox();
            this.lcortes = new System.Windows.Forms.Label();
            this.cortes = new System.Windows.Forms.TextBox();
            this.lfraudefluido = new System.Windows.Forms.Label();
            this.fraudefluido = new System.Windows.Forms.TextBox();
            this.lbarrio = new System.Windows.Forms.Label();
            this.barrio = new System.Windows.Forms.TextBox();
            this.llocalidad = new System.Windows.Forms.Label();
            this.localidad = new System.Windows.Forms.TextBox();
            this.lzona = new System.Windows.Forms.Label();
            this.zona = new System.Windows.Forms.TextBox();
            this.lrevisionesinternas = new System.Windows.Forms.Label();
            this.revisionesinternas = new System.Windows.Forms.TextBox();
            this.lalertadesv = new System.Windows.Forms.Label();
            this.alertadesv = new System.Windows.Forms.TextBox();
            this.lautoproteccion = new System.Windows.Forms.Label();
            this.autoproteccion = new System.Windows.Forms.TextBox();
            this.lviolaciones = new System.Windows.Forms.Label();
            this.violaciones = new System.Windows.Forms.TextBox();
            this.lcampo1 = new System.Windows.Forms.Label();
            this.campo1 = new System.Windows.Forms.TextBox();
            this.lingresodatosprimeravez = new System.Windows.Forms.Label();
            this.ingresodatosprimeravez = new System.Windows.Forms.TextBox();
            this.levaluacionpromedios = new System.Windows.Forms.Label();
            this.evaluacionpromedios = new System.Windows.Forms.TextBox();
            this.lcampo4 = new System.Windows.Forms.Label();
            this.campo4 = new System.Windows.Forms.TextBox();
            this.lcampo3 = new System.Windows.Forms.Label();
            this.campo3 = new System.Windows.Forms.TextBox();
            this.lcampo2 = new System.Windows.Forms.Label();
            this.campo2 = new System.Windows.Forms.TextBox();
            this.lcampo5 = new System.Windows.Forms.Label();
            this.campo5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fechaingreso
            // 
            this.fechaingreso.Location = new System.Drawing.Point(82, 44);
            this.fechaingreso.Name = "fechaingreso";
            this.fechaingreso.Size = new System.Drawing.Size(197, 22);
            this.fechaingreso.TabIndex = 0;
            this.fechaingreso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lfechaingreso
            // 
            this.lfechaingreso.AutoSize = true;
            this.lfechaingreso.Location = new System.Drawing.Point(329, 44);
            this.lfechaingreso.Name = "lfechaingreso";
            this.lfechaingreso.Size = new System.Drawing.Size(98, 17);
            this.lfechaingreso.TabIndex = 1;
            this.lfechaingreso.Text = "Fecha Ingreso";
            this.lfechaingreso.Click += new System.EventHandler(this.label1_Click);
            // 
            // lhoraingreso
            // 
            this.lhoraingreso.AutoSize = true;
            this.lhoraingreso.Location = new System.Drawing.Point(329, 72);
            this.lhoraingreso.Name = "lhoraingreso";
            this.lhoraingreso.Size = new System.Drawing.Size(90, 17);
            this.lhoraingreso.TabIndex = 3;
            this.lhoraingreso.Text = "Hora Ingreso";
            // 
            // horaingreso
            // 
            this.horaingreso.Location = new System.Drawing.Point(82, 72);
            this.horaingreso.Name = "horaingreso";
            this.horaingreso.Size = new System.Drawing.Size(197, 22);
            this.horaingreso.TabIndex = 2;
            // 
            // lidnovedad
            // 
            this.lidnovedad.AutoSize = true;
            this.lidnovedad.Location = new System.Drawing.Point(329, 100);
            this.lidnovedad.Name = "lidnovedad";
            this.lidnovedad.Size = new System.Drawing.Size(80, 17);
            this.lidnovedad.TabIndex = 5;
            this.lidnovedad.Text = "Id Novedad";
            // 
            // idnovedad
            // 
            this.idnovedad.Location = new System.Drawing.Point(82, 100);
            this.idnovedad.Name = "idnovedad";
            this.idnovedad.Size = new System.Drawing.Size(197, 22);
            this.idnovedad.TabIndex = 4;
            // 
            // lidmedidor
            // 
            this.lidmedidor.AutoSize = true;
            this.lidmedidor.Location = new System.Drawing.Point(329, 128);
            this.lidmedidor.Name = "lidmedidor";
            this.lidmedidor.Size = new System.Drawing.Size(74, 17);
            this.lidmedidor.TabIndex = 7;
            this.lidmedidor.Text = "Id Medidor";
            this.lidmedidor.Click += new System.EventHandler(this.label4_Click);
            // 
            // idmedidor
            // 
            this.idmedidor.Location = new System.Drawing.Point(82, 128);
            this.idmedidor.Name = "idmedidor";
            this.idmedidor.Size = new System.Drawing.Size(197, 22);
            this.idmedidor.TabIndex = 6;
            this.idmedidor.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ldepartamento
            // 
            this.ldepartamento.AutoSize = true;
            this.ldepartamento.Location = new System.Drawing.Point(329, 156);
            this.ldepartamento.Name = "ldepartamento";
            this.ldepartamento.Size = new System.Drawing.Size(98, 17);
            this.ldepartamento.TabIndex = 9;
            this.ldepartamento.Text = "Departamento";
            // 
            // departamento
            // 
            this.departamento.Location = new System.Drawing.Point(82, 156);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(197, 22);
            this.departamento.TabIndex = 8;
            // 
            // lciudad
            // 
            this.lciudad.AutoSize = true;
            this.lciudad.Location = new System.Drawing.Point(329, 184);
            this.lciudad.Name = "lciudad";
            this.lciudad.Size = new System.Drawing.Size(52, 17);
            this.lciudad.TabIndex = 11;
            this.lciudad.Text = "Ciudad";
            this.lciudad.Click += new System.EventHandler(this.label6_Click);
            // 
            // ciudad
            // 
            this.ciudad.Location = new System.Drawing.Point(82, 184);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(197, 22);
            this.ciudad.TabIndex = 10;
            // 
            // lreconexiones
            // 
            this.lreconexiones.AutoSize = true;
            this.lreconexiones.Location = new System.Drawing.Point(329, 352);
            this.lreconexiones.Name = "lreconexiones";
            this.lreconexiones.Size = new System.Drawing.Size(97, 17);
            this.lreconexiones.TabIndex = 23;
            this.lreconexiones.Text = "Reconexiones";
            // 
            // reconexiones
            // 
            this.reconexiones.Location = new System.Drawing.Point(82, 352);
            this.reconexiones.Name = "reconexiones";
            this.reconexiones.Size = new System.Drawing.Size(197, 22);
            this.reconexiones.TabIndex = 22;
            // 
            // lcortes
            // 
            this.lcortes.AutoSize = true;
            this.lcortes.Location = new System.Drawing.Point(329, 324);
            this.lcortes.Name = "lcortes";
            this.lcortes.Size = new System.Drawing.Size(49, 17);
            this.lcortes.TabIndex = 21;
            this.lcortes.Text = "Cortes";
            // 
            // cortes
            // 
            this.cortes.Location = new System.Drawing.Point(82, 324);
            this.cortes.Name = "cortes";
            this.cortes.Size = new System.Drawing.Size(197, 22);
            this.cortes.TabIndex = 20;
            // 
            // lfraudefluido
            // 
            this.lfraudefluido.AutoSize = true;
            this.lfraudefluido.Location = new System.Drawing.Point(329, 296);
            this.lfraudefluido.Name = "lfraudefluido";
            this.lfraudefluido.Size = new System.Drawing.Size(95, 17);
            this.lfraudefluido.TabIndex = 19;
            this.lfraudefluido.Text = "Fraude Fluido";
            // 
            // fraudefluido
            // 
            this.fraudefluido.Location = new System.Drawing.Point(82, 296);
            this.fraudefluido.Name = "fraudefluido";
            this.fraudefluido.Size = new System.Drawing.Size(197, 22);
            this.fraudefluido.TabIndex = 18;
            // 
            // lbarrio
            // 
            this.lbarrio.AutoSize = true;
            this.lbarrio.Location = new System.Drawing.Point(329, 268);
            this.lbarrio.Name = "lbarrio";
            this.lbarrio.Size = new System.Drawing.Size(46, 17);
            this.lbarrio.TabIndex = 17;
            this.lbarrio.Text = "Barrio";
            // 
            // barrio
            // 
            this.barrio.Location = new System.Drawing.Point(82, 268);
            this.barrio.Name = "barrio";
            this.barrio.Size = new System.Drawing.Size(197, 22);
            this.barrio.TabIndex = 16;
            // 
            // llocalidad
            // 
            this.llocalidad.AutoSize = true;
            this.llocalidad.Location = new System.Drawing.Point(329, 240);
            this.llocalidad.Name = "llocalidad";
            this.llocalidad.Size = new System.Drawing.Size(69, 17);
            this.llocalidad.TabIndex = 15;
            this.llocalidad.Text = "Localidad";
            this.llocalidad.Click += new System.EventHandler(this.label11_Click);
            // 
            // localidad
            // 
            this.localidad.Location = new System.Drawing.Point(82, 240);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(197, 22);
            this.localidad.TabIndex = 14;
            // 
            // lzona
            // 
            this.lzona.AutoSize = true;
            this.lzona.Location = new System.Drawing.Point(329, 212);
            this.lzona.Name = "lzona";
            this.lzona.Size = new System.Drawing.Size(41, 17);
            this.lzona.TabIndex = 13;
            this.lzona.Text = "Zona";
            // 
            // zona
            // 
            this.zona.Location = new System.Drawing.Point(82, 212);
            this.zona.Name = "zona";
            this.zona.Size = new System.Drawing.Size(197, 22);
            this.zona.TabIndex = 12;
            // 
            // lrevisionesinternas
            // 
            this.lrevisionesinternas.AutoSize = true;
            this.lrevisionesinternas.Location = new System.Drawing.Point(861, 100);
            this.lrevisionesinternas.Name = "lrevisionesinternas";
            this.lrevisionesinternas.Size = new System.Drawing.Size(132, 17);
            this.lrevisionesinternas.TabIndex = 31;
            this.lrevisionesinternas.Text = "Revisiones Internas";
            // 
            // revisionesinternas
            // 
            this.revisionesinternas.Location = new System.Drawing.Point(614, 100);
            this.revisionesinternas.Name = "revisionesinternas";
            this.revisionesinternas.Size = new System.Drawing.Size(197, 22);
            this.revisionesinternas.TabIndex = 30;
            // 
            // lalertadesv
            // 
            this.lalertadesv.AutoSize = true;
            this.lalertadesv.Location = new System.Drawing.Point(861, 72);
            this.lalertadesv.Name = "lalertadesv";
            this.lalertadesv.Size = new System.Drawing.Size(215, 17);
            this.lalertadesv.TabIndex = 29;
            this.lalertadesv.Text = "Alerta desviaciones significativas";
            // 
            // alertadesv
            // 
            this.alertadesv.Location = new System.Drawing.Point(614, 72);
            this.alertadesv.Name = "alertadesv";
            this.alertadesv.Size = new System.Drawing.Size(197, 22);
            this.alertadesv.TabIndex = 28;
            // 
            // lautoproteccion
            // 
            this.lautoproteccion.AutoSize = true;
            this.lautoproteccion.Location = new System.Drawing.Point(861, 44);
            this.lautoproteccion.Name = "lautoproteccion";
            this.lautoproteccion.Size = new System.Drawing.Size(103, 17);
            this.lautoproteccion.TabIndex = 27;
            this.lautoproteccion.Text = "Autoproteccion";
            // 
            // autoproteccion
            // 
            this.autoproteccion.Location = new System.Drawing.Point(614, 44);
            this.autoproteccion.Name = "autoproteccion";
            this.autoproteccion.Size = new System.Drawing.Size(197, 22);
            this.autoproteccion.TabIndex = 26;
            // 
            // lviolaciones
            // 
            this.lviolaciones.AutoSize = true;
            this.lviolaciones.Location = new System.Drawing.Point(329, 380);
            this.lviolaciones.Name = "lviolaciones";
            this.lviolaciones.Size = new System.Drawing.Size(80, 17);
            this.lviolaciones.TabIndex = 25;
            this.lviolaciones.Text = "Violaciones";
            this.lviolaciones.Click += new System.EventHandler(this.label16_Click);
            // 
            // violaciones
            // 
            this.violaciones.Location = new System.Drawing.Point(82, 380);
            this.violaciones.Name = "violaciones";
            this.violaciones.Size = new System.Drawing.Size(197, 22);
            this.violaciones.TabIndex = 24;
            // 
            // lcampo1
            // 
            this.lcampo1.AutoSize = true;
            this.lcampo1.Location = new System.Drawing.Point(861, 184);
            this.lcampo1.Name = "lcampo1";
            this.lcampo1.Size = new System.Drawing.Size(64, 17);
            this.lcampo1.TabIndex = 37;
            this.lcampo1.Text = "Campo 1";
            // 
            // campo1
            // 
            this.campo1.Location = new System.Drawing.Point(614, 184);
            this.campo1.Name = "campo1";
            this.campo1.Size = new System.Drawing.Size(197, 22);
            this.campo1.TabIndex = 36;
            // 
            // lingresodatosprimeravez
            // 
            this.lingresodatosprimeravez.AutoSize = true;
            this.lingresodatosprimeravez.Location = new System.Drawing.Point(861, 156);
            this.lingresodatosprimeravez.Name = "lingresodatosprimeravez";
            this.lingresodatosprimeravez.Size = new System.Drawing.Size(172, 17);
            this.lingresodatosprimeravez.TabIndex = 35;
            this.lingresodatosprimeravez.Text = "Ingreso datos primera vez";
            // 
            // ingresodatosprimeravez
            // 
            this.ingresodatosprimeravez.Location = new System.Drawing.Point(614, 156);
            this.ingresodatosprimeravez.Name = "ingresodatosprimeravez";
            this.ingresodatosprimeravez.Size = new System.Drawing.Size(197, 22);
            this.ingresodatosprimeravez.TabIndex = 34;
            // 
            // levaluacionpromedios
            // 
            this.levaluacionpromedios.AutoSize = true;
            this.levaluacionpromedios.Location = new System.Drawing.Point(861, 128);
            this.levaluacionpromedios.Name = "levaluacionpromedios";
            this.levaluacionpromedios.Size = new System.Drawing.Size(168, 17);
            this.levaluacionpromedios.TabIndex = 33;
            this.levaluacionpromedios.Text = "Evaluación de Promedios";
            // 
            // evaluacionpromedios
            // 
            this.evaluacionpromedios.Location = new System.Drawing.Point(614, 128);
            this.evaluacionpromedios.Name = "evaluacionpromedios";
            this.evaluacionpromedios.Size = new System.Drawing.Size(197, 22);
            this.evaluacionpromedios.TabIndex = 32;
            // 
            // lcampo4
            // 
            this.lcampo4.AutoSize = true;
            this.lcampo4.Location = new System.Drawing.Point(861, 268);
            this.lcampo4.Name = "lcampo4";
            this.lcampo4.Size = new System.Drawing.Size(64, 17);
            this.lcampo4.TabIndex = 43;
            this.lcampo4.Text = "Campo 4";
            // 
            // campo4
            // 
            this.campo4.Location = new System.Drawing.Point(614, 268);
            this.campo4.Name = "campo4";
            this.campo4.Size = new System.Drawing.Size(197, 22);
            this.campo4.TabIndex = 42;
            // 
            // lcampo3
            // 
            this.lcampo3.AutoSize = true;
            this.lcampo3.Location = new System.Drawing.Point(861, 240);
            this.lcampo3.Name = "lcampo3";
            this.lcampo3.Size = new System.Drawing.Size(64, 17);
            this.lcampo3.TabIndex = 41;
            this.lcampo3.Text = "Campo 3";
            // 
            // campo3
            // 
            this.campo3.Location = new System.Drawing.Point(614, 240);
            this.campo3.Name = "campo3";
            this.campo3.Size = new System.Drawing.Size(197, 22);
            this.campo3.TabIndex = 40;
            // 
            // lcampo2
            // 
            this.lcampo2.AutoSize = true;
            this.lcampo2.Location = new System.Drawing.Point(861, 212);
            this.lcampo2.Name = "lcampo2";
            this.lcampo2.Size = new System.Drawing.Size(64, 17);
            this.lcampo2.TabIndex = 39;
            this.lcampo2.Text = "Campo 2";
            // 
            // campo2
            // 
            this.campo2.Location = new System.Drawing.Point(614, 212);
            this.campo2.Name = "campo2";
            this.campo2.Size = new System.Drawing.Size(197, 22);
            this.campo2.TabIndex = 38;
            // 
            // lcampo5
            // 
            this.lcampo5.AutoSize = true;
            this.lcampo5.Location = new System.Drawing.Point(861, 296);
            this.lcampo5.Name = "lcampo5";
            this.lcampo5.Size = new System.Drawing.Size(64, 17);
            this.lcampo5.TabIndex = 45;
            this.lcampo5.Text = "Campo 5";
            // 
            // campo5
            // 
            this.campo5.Location = new System.Drawing.Point(614, 296);
            this.campo5.Name = "campo5";
            this.campo5.Size = new System.Drawing.Size(197, 22);
            this.campo5.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 42);
            this.button1.TabIndex = 46;
            this.button1.Text = "Agregar Novedad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AgregarNovedad
            // 
            this.ClientSize = new System.Drawing.Size(1127, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lcampo5);
            this.Controls.Add(this.campo5);
            this.Controls.Add(this.lcampo4);
            this.Controls.Add(this.campo4);
            this.Controls.Add(this.lcampo3);
            this.Controls.Add(this.campo3);
            this.Controls.Add(this.lcampo2);
            this.Controls.Add(this.campo2);
            this.Controls.Add(this.lcampo1);
            this.Controls.Add(this.campo1);
            this.Controls.Add(this.lingresodatosprimeravez);
            this.Controls.Add(this.ingresodatosprimeravez);
            this.Controls.Add(this.levaluacionpromedios);
            this.Controls.Add(this.evaluacionpromedios);
            this.Controls.Add(this.lrevisionesinternas);
            this.Controls.Add(this.revisionesinternas);
            this.Controls.Add(this.lalertadesv);
            this.Controls.Add(this.alertadesv);
            this.Controls.Add(this.lautoproteccion);
            this.Controls.Add(this.autoproteccion);
            this.Controls.Add(this.lviolaciones);
            this.Controls.Add(this.violaciones);
            this.Controls.Add(this.lreconexiones);
            this.Controls.Add(this.reconexiones);
            this.Controls.Add(this.lcortes);
            this.Controls.Add(this.cortes);
            this.Controls.Add(this.lfraudefluido);
            this.Controls.Add(this.fraudefluido);
            this.Controls.Add(this.lbarrio);
            this.Controls.Add(this.barrio);
            this.Controls.Add(this.llocalidad);
            this.Controls.Add(this.localidad);
            this.Controls.Add(this.lzona);
            this.Controls.Add(this.zona);
            this.Controls.Add(this.lciudad);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.ldepartamento);
            this.Controls.Add(this.departamento);
            this.Controls.Add(this.lidmedidor);
            this.Controls.Add(this.idmedidor);
            this.Controls.Add(this.lidnovedad);
            this.Controls.Add(this.idnovedad);
            this.Controls.Add(this.lhoraingreso);
            this.Controls.Add(this.horaingreso);
            this.Controls.Add(this.lfechaingreso);
            this.Controls.Add(this.fechaingreso);
            this.Name = "AgregarNovedad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fechaingreso;
        private System.Windows.Forms.Label lfechaingreso;
        private System.Windows.Forms.Label lhoraingreso;
        private System.Windows.Forms.TextBox horaingreso;
        private System.Windows.Forms.Label lidnovedad;
        private System.Windows.Forms.TextBox idnovedad;
        private System.Windows.Forms.Label lidmedidor;
        private System.Windows.Forms.TextBox idmedidor;
        private System.Windows.Forms.Label ldepartamento;
        private System.Windows.Forms.TextBox departamento;
        private System.Windows.Forms.Label lciudad;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.Label lreconexiones;
        private System.Windows.Forms.TextBox reconexiones;
        private System.Windows.Forms.Label lcortes;
        private System.Windows.Forms.TextBox cortes;
        private System.Windows.Forms.Label lfraudefluido;
        private System.Windows.Forms.TextBox fraudefluido;
        private System.Windows.Forms.Label lbarrio;
        private System.Windows.Forms.TextBox barrio;
        private System.Windows.Forms.Label llocalidad;
        private System.Windows.Forms.TextBox localidad;
        private System.Windows.Forms.Label lzona;
        private System.Windows.Forms.TextBox zona;
        private System.Windows.Forms.Label lrevisionesinternas;
        private System.Windows.Forms.TextBox revisionesinternas;
        private System.Windows.Forms.Label lalertadesv;
        private System.Windows.Forms.TextBox alertadesv;
        private System.Windows.Forms.Label lautoproteccion;
        private System.Windows.Forms.TextBox autoproteccion;
        private System.Windows.Forms.Label lviolaciones;
        private System.Windows.Forms.TextBox violaciones;
        private System.Windows.Forms.Label lcampo1;
        private System.Windows.Forms.TextBox campo1;
        private System.Windows.Forms.Label lingresodatosprimeravez;
        private System.Windows.Forms.TextBox ingresodatosprimeravez;
        private System.Windows.Forms.Label levaluacionpromedios;
        private System.Windows.Forms.TextBox evaluacionpromedios;
        private System.Windows.Forms.Label lcampo4;
        private System.Windows.Forms.TextBox campo4;
        private System.Windows.Forms.Label lcampo3;
        private System.Windows.Forms.TextBox campo3;
        private System.Windows.Forms.Label lcampo2;
        private System.Windows.Forms.TextBox campo2;
        private System.Windows.Forms.Label lcampo5;
        private System.Windows.Forms.TextBox campo5;
        private System.Windows.Forms.Button button1;
    }
}