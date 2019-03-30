using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class AgregarPQRS
    {
        public string fechaingreso { get; set; }
        public string horaingreso { get; set; }
        public string idmedidor { get; set; }
        public string nombrepeticionario { get; set; }
        public string identificacion { get; set; }
        public string direccion { get; set; }
        public string telefonofijo{ get; set; }
        public string celular { get; set; }
        public string correoelectronico { get; set; }
        public int idPQRS { get; set; }
        public string descripciónPQRS { get; set; }
        public string tipodesolicitud { get; set; }
        public string consultaestadoPQRS { get; set; }
        public string dañopresentado { get; set; }
        public string campo1 { get; set; }
        public string campo2 { get; set; }
        public string campo3 { get; set; }
        public string campo4 { get; set; }
        public string campo5 { get; set; }


        public AgregarPQRS() { }

        public AgregarPQRS(String pfechaingreso, String phoraingreso, String pnombrepeticionario, String pidentificacion, String pdireccion, String ptelefonofijo, String pcelular, String pcorreoelectronico, String pidmedidor, int pidPQRS, String pdescripciónPQRS, String ptipodesolicitud, String pconsultaestadoPQRS, String pdañopresentado, String pcampo1, String pcampo2, String pcampo3, String pcampo4, String pcampo5)
        {

            this.fechaingreso = pfechaingreso;
            this.horaingreso = phoraingreso;
            this.idmedidor = pidmedidor;
            this.nombrepeticionario = pnombrepeticionario;
            this.identificacion = pidentificacion;
            this.direccion = pdireccion;
            this.telefonofijo = ptelefonofijo;
            this.celular = pcelular;
            this.correoelectronico = pcorreoelectronico;
            this.idPQRS = pidPQRS;            
            this.descripciónPQRS = pdescripciónPQRS;
            this.tipodesolicitud = ptipodesolicitud;
            this.consultaestadoPQRS = pconsultaestadoPQRS;
            this.dañopresentado = pdañopresentado;
            this.campo1 = pcampo1;
            this.campo2 = pcampo2;
            this.campo3 = pcampo3;
            this.campo4 = pcampo4;
            this.campo5 = pcampo5;


        }
    }
}
