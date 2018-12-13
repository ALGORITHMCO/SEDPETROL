using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class Consultareportesyanalisis
    {

        public String FechaInicio { get; set; }
        public String FechaFin { get; set; }
        public String variableaconsultar { get; set; }
        public String departamento { get; set; }
        public String ciudad { get; set; }
        public String zona { get; set; }
        public String localidad { get; set; }
        public String barrio { get; set; }
        public String ID_MEDIDOR { get; set; }
        



        public Consultareportesyanalisis() { }

        public Consultareportesyanalisis(String pFechaInicio, String pFechaFin, String pvariableaconsultar, String pdepartamento, String pciudad, 
            String pzona, String plocalidad, String pbarrio, String pID_MEDIDOR)
        {
           
            this.FechaInicio = pFechaInicio;
            this.FechaFin = pFechaFin;
            this.variableaconsultar = pvariableaconsultar;
            this.departamento = pdepartamento;
            this.ciudad = pciudad;
            this.zona = pzona;
            this.localidad = plocalidad;
            this.barrio = pbarrio;
            this.ID_MEDIDOR = pID_MEDIDOR;
           
        }
    }
    }

