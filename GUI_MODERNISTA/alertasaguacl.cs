using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class alertasaguacl
    {

        public String ID_MEDIDOR { get; set; }
        public String FECHAINGRESO { get; set; }
        public String HORAINGRESO { get; set; }
        public String VOLUMENINGRESADO { get; set; }
        public String SUMATORIACONSUMOLEGAL { get; set; }
        public String DIFERENCIA { get; set; }
        public String PERDIDASTECNICAS { get; set; }
        public String PERDIDASCOMERCIALES { get; set; }
        public String ACCIONESFRAUDULENTAS { get; set; }
        public String MEDIDORESMANIPULADOS { get; set; }
        public String MICROMEDICION { get; set; }
        public String CLASE_DE_USO { get; set; }
        public String CAMPO1 { get; set; }
        public String CAMPO2 { get; set; }
        public String CAMPO3 { get; set; }
        public String CAMPO4 { get; set; }
        public String CAMPO5 { get; set; }

        public alertasaguacl() { }

        public alertasaguacl(String pID_MEDIDOR, String p, String p0, String p1, String p2, String p3, String p4, String p5, String p6, String p7, String p8, String p9, String p10, String p11, String p12, String p13, String p14)
        {
            this.ID_MEDIDOR = pID_MEDIDOR;
            this.FECHAINGRESO = p;
            this.HORAINGRESO = p0;
            this.VOLUMENINGRESADO = p1;
            this.SUMATORIACONSUMOLEGAL = p2;
            this.DIFERENCIA = p3;
            this.PERDIDASTECNICAS = p4;
            this.PERDIDASCOMERCIALES = p5;
            this.ACCIONESFRAUDULENTAS = p6;
            this.MEDIDORESMANIPULADOS = p7;
            this.MICROMEDICION = p8;
            this.CLASE_DE_USO = p9;
            this.CAMPO1 = p10;
            this.CAMPO2 = p11;
            this.CAMPO3 = p12;
            this.CAMPO4 = p13;
            this.CAMPO5 = p14;
        }
    }
}

