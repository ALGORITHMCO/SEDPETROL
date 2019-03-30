using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class IngresoDatosPredio
    {
        public string idpredio { get; set; }
        public string idpropietario { get; set; }
        public string idchip { get; set; }
        public string matriculainmobiliaria { get; set; }
        public string direccion { get; set; }
        public string departamento { get; set; }
        public string municipio{ get; set; }
        public string localidad { get; set; }
        public string barrio { get; set; }
        public string estrato { get; set; }

        public string claseuso { get; set; }
        public string unidadhabfam { get; set; }
        public string unidnohabfam { get; set; }
        public string zona { get; set; }
        public string ciclo { get; set; }
        public string ruta { get; set; }
        public IngresoDatosPredio() { }

        public IngresoDatosPredio(String pidpredio, String pidpropietario, String pidchip, String pmatriculainmobiliaria, String pdireccion, String pdepartamento, String pmunicipio, String plocalidad, String pbarrio, String pestrato, String pclaseuso, String punidadhabfam, String punidnohabfam, String pzona, String pciclo, String pruta)
        {
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
            this.unidadhabfam= punidadhabfam;
            this.unidnohabfam = punidnohabfam;
            this.zona = pzona;
            this.ciclo = pciclo;
            this.ruta = pruta;



        }
    }
}
    