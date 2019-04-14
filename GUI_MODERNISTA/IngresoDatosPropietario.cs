using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class IngresoDatosPropietario
    {
        public string idpropietario { get; set; }
        public string tipoidentificacion { get; set; }
        public string numeroidentificacion { get; set; }
        public string nombrepropietario { get; set; }
        public string porcentajepropiedad { get; set; }
        public string calidadpropietario { get; set; }
        public string cuentacontrato { get; set; }
        public string estado { get; set; }
        
        public string campo1 { get; set; }
        public string campo2 { get; set; }
        public string campo3 { get; set; }
        public string campo4 { get; set; }
        public string campo5 { get; set; }
        public IngresoDatosPropietario() { }

        public IngresoDatosPropietario(String pidpropietario, String ptipoidentificacion, String pnumeroidentificacion, String pnombrepropietario, String pporcentajepropiedad, String pcalidadpropietario, String pcuentacontrato, String pestado, String pcampo1, String pcampo2, String pcampo3, String pcampo4, String pcampo5)
        {
            this.idpropietario = pidpropietario;
            this.tipoidentificacion = ptipoidentificacion;
            this.numeroidentificacion = pnumeroidentificacion;    
            this.porcentajepropiedad = pporcentajepropiedad;
            this.calidadpropietario = pcalidadpropietario;            
            this.cuentacontrato = pcuentacontrato;
            this.estado = pestado;     
            this.campo1 = pcampo1;
            this.campo2 = pcampo2;
            this.campo3 = pcampo3;
            this.campo4 = pcampo4;
            this.campo5 = pcampo5;


        }
    }
}
    