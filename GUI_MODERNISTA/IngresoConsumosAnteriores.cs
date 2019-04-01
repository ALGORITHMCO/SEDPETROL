using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class IngresoConsumosAnteriores
    {
        public string idfactura { get; set; }
        public string idmedidor { get; set; }
        public string empresa { get; set; }
        public string facturaspno { get; set; }
        public string consumom3 { get; set; }
        public string periodo1 { get; set; }
        public string periodo2 { get; set; }
        public string periodo3 { get; set; }
        public string periodo4 { get; set; }
        public string periodo5 { get; set; }
        public string periodo6 { get; set; }
        public string consumopromedio { get; set; }
        public string periodoafacturar { get; set; }
        public string descarguefuente { get; set; }
        public string facturadocon { get; set; }
        public string totalapagar { get; set; }

        public DateTime fechapagoportuno { get; set;}
        public DateTime fechalimitepago { get; set;}

        //public string fechapagoportuno { get; set; }
        //public string fechalimitepago { get; set; }
        public string cuentacontrato{ get; set; }

        public IngresoConsumosAnteriores() { }

        public IngresoConsumosAnteriores(String pidfactura, String pidmedidor, String pempresa, String pfacturaspno, String pconsumom3, String pperiodo1, String pperiodo2, String pperiodo3, String pperiodo4, String pperiodo5, String pperiodo6, String pconsumopromedio, String pperiodoafacturar, String pdescarguefuente, String pfacturadocon, String ptotalapagar, DateTime pfechapagoportuno, DateTime pfechalimitepago, String pcuentacontrato)
        {
            this.idfactura = pidfactura;
            this.idmedidor = pidmedidor;
            this.empresa = pempresa;    
            this.facturaspno = pfacturaspno;
            this.consumom3 = pconsumom3;            
            this.periodo1 = pperiodo1;
            this.periodo2 = pperiodo2;     
            this.periodo3 = pperiodo3;
            this.periodo4 = pperiodo4;
            this.periodo5 = pperiodo5;
            this.periodo6 = pperiodo6;
            this.consumopromedio = pconsumopromedio;
            this.periodoafacturar = pperiodoafacturar;
            this.descarguefuente = pdescarguefuente;
            this.facturadocon = pfacturadocon;
            this.totalapagar = ptotalapagar;
            this.fechapagoportuno = pfechapagoportuno;
            this.fechalimitepago = pfechalimitepago;
            this.cuentacontrato = pcuentacontrato;



        }
    }
}
    