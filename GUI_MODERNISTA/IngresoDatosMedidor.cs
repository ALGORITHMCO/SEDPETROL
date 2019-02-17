using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class IngresoDatosMedidor
    {
        public string idmedidor { get; set; }
        public string cuentacontrato { get; set; }
        public string numeromedidor { get; set; }
        public string marca { get; set; }
        public string tipo { get; set; }
        public string ultimalectura { get; set; }
        public string lecturaanterior { get; set; }
        public string consumom3 { get; set; }
        public string diametro { get; set; }
        public string campo1 { get; set; }
        public string campo2 { get; set; }
        public string campo3 { get; set; }
        public string campo4 { get; set; }
        public string campo5 { get; set; }
        public IngresoDatosMedidor() { }

        public IngresoDatosMedidor(String pidmedidor, String pcuentacontrato, String pnumeromedidor, String pmarca, String ptipo, String pultimalectura, String plecturaanterior, String pconsumom3, String pdiametro, String pcampo1, String pcampo2, String pcampo3, String pcampo4, String pcampo5)
        {
            this.idmedidor = pidmedidor;
            this.cuentacontrato = pcuentacontrato;
            this.numeromedidor = pnumeromedidor;    
            this.marca = pmarca;
            this.tipo = ptipo;            
            this.ultimalectura = pultimalectura;
            this.lecturaanterior = plecturaanterior;
            this.consumom3 = pconsumom3;
            this.diametro = pdiametro;
            this.campo1 = pcampo1;
            this.campo2 = pcampo2;
            this.campo3 = pcampo3;
            this.campo4 = pcampo4;
            this.campo5 = pcampo5;


        }
    }
}
    