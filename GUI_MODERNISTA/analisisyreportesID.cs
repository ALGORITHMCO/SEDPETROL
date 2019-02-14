using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class analisisyreportesID
    {


       
        public String FECHA { get; set; }
        public String VARIABLE { get; set; }
       

        public analisisyreportesID() { }

        public analisisyreportesID(String pID_INFENTRADA, String pID_MEDIDOR, String pID_MEDIDOR1, String pREVISIONES_INTERNAS, String pCORTES_SERVICIO, String pRECONEXION, String pDEFRAUDACION_FLUIDOS, String pRECLAMACIONES, String pCAMBIO_DE_USO,
            String pESTRATO)
        {
            
            this.FECHA = pREVISIONES_INTERNAS;
           
            this.VARIABLE = pRECONEXION;
           
        }
    }
}
