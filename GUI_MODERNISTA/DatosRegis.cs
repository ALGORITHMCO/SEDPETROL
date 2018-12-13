using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    class DatosRegis
    {
        public int Id { get; set; }
        public String nombre { get; set; }
        public String usuario { get; set; }
        public String correo { get; set; }
        public String contraseña { get; set; }

        public DatosRegis() { }

        public DatosRegis(int pId, String pnombre, String pusuario, String pcorreo, String pcontraseña)
        {
            this.Id = pId;
            this.nombre = pnombre;
            this.usuario = pusuario;
            this.correo = pcorreo;
            this.contraseña = pcontraseña;
        }
    }
}
