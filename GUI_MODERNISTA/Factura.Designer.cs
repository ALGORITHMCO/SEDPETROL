namespace GUI_MODERNISTA
{
    partial class Factura
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
            this.label1 = new System.Windows.Forms.Label();
            this.contrato = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.year = new System.Windows.Forms.TextBox();
            this.monthEnd = new System.Windows.Forms.TextBox();
            this.monthStart = new System.Windows.Forms.TextBox();
            this.Año = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(967, 654);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contrato";
            // 
            // contrato
            // 
            this.contrato.Location = new System.Drawing.Point(1056, 651);
            this.contrato.Name = "contrato";
            this.contrato.Size = new System.Drawing.Size(100, 22);
            this.contrato.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1197, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 12);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1288, 627);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(815, 651);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 22);
            this.year.TabIndex = 4;
            // 
            // monthEnd
            // 
            this.monthEnd.Location = new System.Drawing.Point(595, 651);
            this.monthEnd.Name = "monthEnd";
            this.monthEnd.Size = new System.Drawing.Size(100, 22);
            this.monthEnd.TabIndex = 5;
            // 
            // monthStart
            // 
            this.monthStart.Location = new System.Drawing.Point(356, 652);
            this.monthStart.Name = "monthStart";
            this.monthStart.Size = new System.Drawing.Size(100, 22);
            this.monthStart.TabIndex = 6;
            // 
            // Año
            // 
            this.Año.AutoSize = true;
            this.Año.Location = new System.Drawing.Point(758, 654);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(33, 17);
            this.Año.TabIndex = 7;
            this.Año.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 654);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 654);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desde";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 691);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Año);
            this.Controls.Add(this.monthStart);
            this.Controls.Add(this.monthEnd);
            this.Controls.Add(this.year);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contrato);
            this.Controls.Add(this.label1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contrato;
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox monthEnd;
        private System.Windows.Forms.TextBox monthStart;
        private System.Windows.Forms.Label Año;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}