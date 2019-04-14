using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class ComportamientoServicio
    {
        public string idcomportamiento { get; set; }
        public string idmedidor { get; set; }
        public string fechaingreso { get; set; }
        public string horaingreso { get; set; }
        public string tiposalarmas { get; set; }
        public string saldo { get; set; }
        public string solicitudac { get; set; }
        public string calidadpropietario { get; set; }
        public string claseuso { get; set; }
        public string patronparametrosconsumos { get; set; }

        public string promedioflujomedidor { get; set; }
        public string diferenciaconsumopatron{ get; set; }
        public string alertadesvsignificativas { get; set; }
        public string maximasparamedidores { get; set; }
        public string marcamedexistente { get; set; }
        public string tipomedexistente{ get; set; }
        public string diametromedexistente{ get; set; }
        public string resultadorequerimiento{ get; set; }
        public string diametrosugeridomedidor{ get; set; }
        public string campo1 { get; set; }
        public string campo2 { get; set; }
        public string campo3 { get; set; }
        public string campo4 { get; set; }
        public string campo5 { get; set; }


        public ComportamientoServicio() { }

        public ComportamientoServicio(String pidcomportamiento, String pidmedidor, String ptiposalarmas, String phoraingreso, String pfechaingreso, String psaldo, String psolicitudac, String pcalidadpropietario, String pclaseuso, String ppatronparametrosconsumos, String ppromedioflujomedidor, String pdiferenciaconsumopatron, String palertadesvsignificativas, String pmaximasparamedidores, String pmarcamedexistente, String ptipomedexistente, String pdiametromedexistente, String presultadorequerimiento, String pdiametrosugeridomedidor, String pcampo1, String pcampo2, String pcampo3, String pcampo4, String pcampo5)
        {
            this.idcomportamiento= pidcomportamiento;
            this.idmedidor = pidmedidor;
            this.horaingreso = phoraingreso;
            this.fechaingreso = pfechaingreso;
            this.tiposalarmas = ptiposalarmas;    
            this.saldo = psaldo;
            this.solicitudac = psolicitudac;            
            this.calidadpropietario = pcalidadpropietario;
            this.claseuso = pclaseuso;
            this.patronparametrosconsumos = ppatronparametrosconsumos;
            this.promedioflujomedidor = ppromedioflujomedidor;
            this.diferenciaconsumopatron = pdiferenciaconsumopatron;
            this.alertadesvsignificativas = palertadesvsignificativas;
            this.maximasparamedidores = pmaximasparamedidores;
            this.marcamedexistente = pmarcamedexistente;
            this.tipomedexistente = ptipomedexistente;
            this.diametromedexistente = pdiametromedexistente;
            this.resultadorequerimiento = presultadorequerimiento;
            this.diametrosugeridomedidor = pdiametrosugeridomedidor;
            this.campo1 = pcampo1;
            this.campo2 = pcampo2;
            this.campo3 = pcampo3;
            this.campo4 = pcampo4;
            this.campo5 = pcampo5;


        }
    }
}
    