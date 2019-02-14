using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class AlimentacionHistorica
    {


        public String ID_INFENTRADA { get; set; }
        public String ID_MEDIDOR { get; set; }
        public String REVISIONES_INTERNAS { get; set; }
        public String CORTES_SERVICIO { get; set; }
        public String RECONEXION { get; set; }
        public String DEFRAUDACION_FLUIDOS { get; set; }
        public String RECLAMACIONES { get; set; }
        public String CAMBIO_DE_USO { get; set; }

        public AlimentacionHistorica() { }

        public AlimentacionHistorica(String pID_INFENTRADA, String pID_MEDIDOR, String pREVISIONES_INTERNAS, String pCORTES_SERVICIO, String pRECONEXION, String pDEFRAUDACION_FLUIDOS, String pRECLAMACIONES, String pCAMBIO_DE_USO)
        {
            this.ID_INFENTRADA = pID_INFENTRADA;
            this.ID_MEDIDOR = pID_MEDIDOR;
            this.REVISIONES_INTERNAS = pREVISIONES_INTERNAS;
            this.CORTES_SERVICIO = pCORTES_SERVICIO;
            this.RECONEXION = pRECONEXION;
            this.DEFRAUDACION_FLUIDOS = pDEFRAUDACION_FLUIDOS;
            this.RECLAMACIONES = pRECLAMACIONES;
            this.CAMBIO_DE_USO = pCAMBIO_DE_USO;
        }
    }
}
