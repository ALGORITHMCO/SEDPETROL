using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class AgregarNovedades
    {

        //public int Id { get; set; }
        //public String nombres { get; set; }
        //public String usuarios { get; set; }
        //public String correos { get; set; }
        //public String contraseñas { get; set; }

        public string fechaingreso { get; set; }
        public string horaingresonovedad { get; set; }
        public int idnovedad { get; set; }
        public string idmedidor { get; set; }
        public string departamento { get; set; }
        //public string ciudad { get; set; }
        //public string zona { get; set; }
        //public string localidad { get; set; }
        //public string barrio { get; set; }
        public string revisionesinternas { get; set; }
        public string cortes { get; set; }
        public string reconexiones { get; set; }
        public string fraudefluidos { get; set; }
        public string violaciones { get; set; }
        public string autoproteccion { get; set; }
        public string alertasdesviacionessignificativas { get; set; }
        public string evaluaciondepromedios { get; set; }
        public string ingresodatosprimeravez { get; set; }
        public string reclamaciones { get; set; }
        public string campo1 { get; set; }
        public string campo2 { get; set; }
        public string campo3 { get; set; }
        public string campo4 { get; set; }
        public string campo5 { get; set; }

        public AgregarNovedades() { }


        //public AgregarNovedades(int pId, String pnombres, String pusuarios, String pcorreos, String pcontraseñas)
        //{
        //    this.Id = pId;
        //    this.usuarios = pusuarios;
        //    this.nombres = pnombres;
        //    this.contraseñas = pcontraseñas;
        //    this.correos = pcorreos;

        //}novedades.idmedidor, novedades.fechaingreso, novedades.horaingresonovedad, novedades.revisionesinternas, novedades.cortes, novedades.reconexiones, novedades.fraudefluidos, novedades.reclamaciones, novedades.violaciones, novedades.autoproteccion,novedades.evaluaciondepromedios, novedades.ingresodatosprimeravez,novedades.campo1, novedades.campo2, novedades.campo3, novedades.campo4, novedades.campo5), conee);

        public AgregarNovedades(String pfechaingreso, String phoraingresonovedad, int pidnovedad, String pidmedidor, String previsionesinternas, String pcortes, String preconexiones, String pfraudefluidos, String preclamaciones, String pviolaciones, String pautoproteccion, String pevaluaciondepromedios, String pingresodatosprimeravez, String pcampo1, String pcampo2, String pcampo3, String pcampo4, String pcampo5)
        {
            this.fechaingreso = pfechaingreso; 
            this.horaingresonovedad = phoraingresonovedad;
            this.idnovedad = pidnovedad;
            this.idmedidor = pidmedidor;
            this.revisionesinternas = previsionesinternas;

            //    this.ciudad = pciudad;
            //    this.zona = pzona;    
            //    this.localidad = plocalidad;
            //    this.barrio = pbarrio;
            this.fraudefluidos = pfraudefluidos;
            this.cortes = pcortes;
            this.reconexiones = preconexiones;
            this.violaciones = pviolaciones;
            this.autoproteccion = pautoproteccion;
            //this.alertasdesviacionessignificativas = palertasdesviacionessignificativas;
            this.revisionesinternas = previsionesinternas;
            this.evaluaciondepromedios = pevaluaciondepromedios;
            this.ingresodatosprimeravez = pingresodatosprimeravez;
            this.reclamaciones = preclamaciones;
            this.campo1 = pcampo1;
            this.campo2 = pcampo2;
            this.campo3 = pcampo3;
            this.campo4 = pcampo4;
            this.campo5 = pcampo5;
        }

    //public AgregarNovedades(String pfechaingreso, String phoraingresonovedad, String pidnovedad, String pidmedidor, String pdepartamento, String pciudad, String pzona, String plocalidad, String pbarrio, String pfraudefluidos, String pfraudedefluidos, String pcortes, String preconexiones, String pviolaciones, String pautoproteccion, String palertasdesviacionessignificativas, String previsionesinternas, String pevaluaciondepromedios, String pingresodatosprimeravez, String preclamaciones, String pcampo1, String pcampo2, String pcampo3, String pcampo4, String pcampo5)
    //{
    //    this.fechaingreso = pfechaingreso;
    //    this.horaingresonovedad = phoraingresonovedad;
    //    this.idnovedad = pidnovedad;
    //    this.idmedidor = pidmedidor;
    //    this.departamento = pdepartamento;
    //    this.ciudad = pciudad;
    //    this.zona = pzona;
    //    this.localidad = plocalidad;
    //    this.barrio = pbarrio;
    //    this.fraudefluidos = pfraudefluidos;
    //    this.cortes = pcortes;
    //    this.reconexiones = preconexiones;
    //    this.violaciones = pviolaciones;
    //    this.autoproteccion = pautoproteccion;
    //    this.alertasdesviacionessignificativas = palertasdesviacionessignificativas;
    //    this.revisionesinternas = previsionesinternas;
    //    this.evaluaciondepromedios= pevaluaciondepromedios;
    //    this.ingresodatosprimeravez = pingresodatosprimeravez;
    //    this.reclamaciones = preclamaciones;
    //    this.campo1 = pcampo1;
    //    this.campo2 = pcampo2;
    //    this.campo3 = pcampo3;
    //    this.campo4 = pcampo4;
    //    this.campo5 = pcampo5;
    //}

}
}
