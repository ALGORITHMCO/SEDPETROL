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

        // Predio

        public string idpredio { get; set; }
        public string idpropietario { get; set; }
        public string idchip { get; set; }
        public string matriculainmobiliaria { get; set; }
        public string direccion { get; set; }
        public string departamento { get; set; }
        public string municipio { get; set; }
        public string localidad { get; set; }
        public string barrio { get; set; }
        public string estrato { get; set; }
        public string claseuso { get; set; }
        public string unidadhabitacional { get; set; }
        public string unidadnohabitacional { get; set; }
        public string zona { get; set; }
        public string ciclo { get; set; }
        public string ruta { get; set; }

        public IngresoDatosMedidor() { }

        public IngresoDatosMedidor(String pidmedidor, String pcuentacontrato, String pnumeromedidor, String pmarca, String ptipo, String pultimalectura, String plecturaanterior, String pconsumom3, String pdiametro, String pcampo1, String pcampo2, String pcampo3, String pcampo4, String pcampo5, String pidpredio ,String pidpropietario, String pidchip, String pmatriculainmobiliaria, String pdireccion, String pdepartamento, String pmunicipio, String plocalidad, String pbarrio, String pestrato, String pclaseuso, String punidadhabitacional, String punidadnohabitacional, String pzona, String pciclo, String pruta)
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

            this.idpredio = pidpredio;
            this.idpropietario = pidpropietario;
            this.idchip = pidchip;
            this.matriculainmobiliaria = pmatriculainmobiliaria;
            this.direccion = pdireccion;
            this.departamento = pdepartamento;
            this.municipio = pmunicipio;
            this.localidad = plocalidad;
            this.barrio = pbarrio;
            this.estrato = pestrato;
            this.claseuso = pclaseuso;
            this.unidadhabitacional = punidadhabitacional;
            this.unidadnohabitacional = punidadnohabitacional;
            this.zona = pzona;
            this.ciclo = pciclo;
            this.ruta = pruta;



        }
    }
}
    