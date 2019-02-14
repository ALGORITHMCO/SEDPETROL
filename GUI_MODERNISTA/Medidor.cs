using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class Medidor
    {

        public String ID_MEDIDOR { get; set; }
        public String ID_PREDIO { get; set; }
        public String CUENTA_CONTRATO { get; set; }
        public String NU_MEDIDOR { get; set; }
        public String TIPO { get; set; }
        public String MARCA { get; set; }
        public String ULTIMA_LECTURA { get; set; }
        public String LECTURA_ANTERIOR { get; set; }
        public String CONSUMOM3 { get; set; }

        public Medidor() { }

        public Medidor(String pID_MEDIDOR, String pID_PREDIO, String pCUENTA_CONTRATO, String pNU_MEDIDOR, String pTIPO, String pMARCA, String pULTIMA_LECTURA, String pLECTURA_ANTERIOR, String pCONSUMOM3)
        {
            this.ID_MEDIDOR = pID_MEDIDOR;
            this.ID_PREDIO = pID_PREDIO;
            this.CUENTA_CONTRATO = pCUENTA_CONTRATO;
            this.NU_MEDIDOR = pNU_MEDIDOR;
            this.TIPO = pTIPO;
            this.MARCA = pMARCA;
            this.ULTIMA_LECTURA = pULTIMA_LECTURA;
            this.LECTURA_ANTERIOR = pLECTURA_ANTERIOR;
            this.CONSUMOM3= pCONSUMOM3;
        }
    }
}
