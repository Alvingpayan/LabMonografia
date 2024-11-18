using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMonografia
{
    internal class Profesor
    {
        public int IdProfesor { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion {  get; set; }
        public string Telefono { get; set; }
        public DateTime AñoDeNacimiento { get; set; }
        public string Rol { get; internal set; }
    }
}
