using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class FacturaPropietario
    {

        public String ID_FACTURAS { get; set; }
        public String ID_MEDIDOR { get; set; }
        public String EMPRESA { get; set; }
        public String FACTURA_SP_NO { get; set; }
        public String CONSUMOM3 { get; set; }
        public String PERIODO1 { get; set; }
        public String PERIODO2 { get; set; }
        public String PERIODO3 { get; set; }
        public String PERIODO4 { get; set; }
        public String PERIODO5 { get; set; }
        public String PERIODO6 { get; set; }
        public String CONSUMO_PROMEDIO { get; set; }
        public String PERIODO_A_FACTURAR { get; set; }
        public String FACTURADO_CON { get; set; }
        public String DESCARGUE_FUENTE { get; set; }
        public String TOTAL_A_PAGAR { get; set; }
        public String FECHA_PAGO_OPORTUNO { get; set; }
        public String FECHA_LIMITE_PAGO { get; set; }

        public String ID_PROPIETARIO { get; set; }
        public String TIPO_IDENTIFICACION { get; set; }
        public String NU_IDENTIFICACION { get; set; }
        public String NOMBRE_PROPIETARIO { get; set; }
        public String PORC_PROPIEDAD { get; set; }
        public String CALIDAD_PROPIETARIO { get; set; }



        public FacturaPropietario() { }

        public FacturaPropietario(String pID_FACTURAS, String pID_MEDIDOR, String pEMPRESA, String pFACTURA_SP_NO, String pCONSUMOM3, 
            String pPERIODO1, String pPERIODO2, String pPERIODO3, String pPERIODO4, String pPERIODO5, String pPERIODO6,
           String pCONSUMO_PROMEDIO, String pPERIODO_A_FACTURAR, String pFACTURADO_CON, String pDESCARGUE_FUENTE, String pTOTAL_A_PAGAR, String pFECHA_PAGO_OPORTUNO,
           String pFECHA_LIMITE_PAGO, String pID_PROPIETARIO, String pTIPO_IDENTIFICACION, String pNU_IDENTIFICACION,
           String pNOMBRE_PROPIETARIO, String pPORC_PROPIEDAD, String pCALIDAD_PROPIETARIO)
        {
           
            this.ID_FACTURAS = pID_FACTURAS;
            this.ID_MEDIDOR = pID_MEDIDOR;
            this.EMPRESA = pEMPRESA;
            this.FACTURA_SP_NO = pFACTURA_SP_NO;
            this.CONSUMOM3 = pCONSUMOM3;
            this.PERIODO1 = pPERIODO1;
            this.PERIODO2 = pPERIODO2;
            this.PERIODO3 = pPERIODO3;
            this.PERIODO4 = pPERIODO4;
            this.PERIODO5 = pPERIODO5;
            this.PERIODO6 = pPERIODO6;
            this.CONSUMO_PROMEDIO = pCONSUMO_PROMEDIO; 
            this.PERIODO_A_FACTURAR = pPERIODO_A_FACTURAR;
            this.FACTURADO_CON = pFACTURADO_CON;
            this.DESCARGUE_FUENTE = pDESCARGUE_FUENTE; 
            this.TOTAL_A_PAGAR = pTOTAL_A_PAGAR; 
            this.FECHA_PAGO_OPORTUNO = pFECHA_PAGO_OPORTUNO;
            this.FECHA_LIMITE_PAGO = pFECHA_LIMITE_PAGO;

            this.ID_PROPIETARIO = pID_PROPIETARIO;
            this.TIPO_IDENTIFICACION = pTIPO_IDENTIFICACION;
            this.NU_IDENTIFICACION = pNU_IDENTIFICACION;
            this.NOMBRE_PROPIETARIO = pNOMBRE_PROPIETARIO;
            this.PORC_PROPIEDAD = pPORC_PROPIEDAD;
            this.CALIDAD_PROPIETARIO = pCALIDAD_PROPIETARIO;
        }
    }
    }

