namespace GUI_MODERNISTA
{
    partial class RegistroIn
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textcorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textcontra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(588, 510);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "REGISTRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(435, 359);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "USUARIO:";
            // 
            // textusuario
            // 
            this.textusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textusuario.Location = new System.Drawing.Point(555, 351);
            this.textusuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(336, 28);
            this.textusuario.TabIndex = 19;
            this.textusuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.panelContenedor_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(435, 316);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "NOMBRE:";
            // 
            // textnombre
            // 
            this.textnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnombre.Location = new System.Drawing.Point(555, 303);
            this.textnombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(336, 28);
            this.textnombre.TabIndex = 17;
            this.textnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.panelContenedor_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(648, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "USUARIOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(436, 454);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "CORREO:";
            // 
            // textcorreo
            // 
            this.textcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcorreo.Location = new System.Drawing.Point(555, 454);
            this.textcorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textcorreo.Name = "textcorreo";
            this.textcorreo.Size = new System.Drawing.Size(336, 28);
            this.textcorreo.TabIndex = 24;
            this.textcorreo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.panelContenedor_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(435, 410);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "CONTRASEÑA:";
            // 
            // textcontra
            // 
            this.textcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcontra.Location = new System.Drawing.Point(555, 401);
            this.textcontra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textcontra.Name = "textcontra";
            this.textcontra.Size = new System.Drawing.Size(336, 28);
            this.textcontra.TabIndex = 22;
            this.textcontra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.panelContenedor_KeyDown);
            // 
            // RegistroIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImage = global::GUI_MODERNISTA.Properties.Resources.fondo_azul_04;
            this.ClientSize = new System.Drawing.Size(1208, 722);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textcorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textcontra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroIn";
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textcorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textcontra;
    }
}