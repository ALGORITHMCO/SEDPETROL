using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class analisisyreportesID
    {


        public String ID_VARIABLES { get; set; }
        public String ID_CONTROL { get; set; }
        public String ID_MEDIDOR { get; set; }
        public String FECHA { get; set; }
        public String HORA { get; set; }
        public String VARIABLE { get; set; }
        public String DEPARTAMENTO { get; set; }
        public String ZONA { get; set; }
        public String DIRECION { get; set; }
        public String ESTRATO { get; set; }

        public analisisyreportesID() { }

        public analisisyreportesID(String pID_INFENTRADA, String pID_MEDIDOR, String pID_MEDIDOR1, String pREVISIONES_INTERNAS, String pCORTES_SERVICIO, String pRECONEXION, String pDEFRAUDACION_FLUIDOS, String pRECLAMACIONES, String pCAMBIO_DE_USO,
            String pESTRATO)
        {
            this.ID_VARIABLES = pID_INFENTRADA;
            this.ID_CONTROL = pID_MEDIDOR;
            this.ID_MEDIDOR = pID_MEDIDOR1;
            this.FECHA = pREVISIONES_INTERNAS;
            this.HORA = pCORTES_SERVICIO;
            this.VARIABLE = pRECONEXION;
            this.DEPARTAMENTO = pDEFRAUDACION_FLUIDOS;
            this.ZONA= pRECLAMACIONES;
            this.DIRECION = pCAMBIO_DE_USO;
            this.ESTRATO = pESTRATO;
        }
    }
}
