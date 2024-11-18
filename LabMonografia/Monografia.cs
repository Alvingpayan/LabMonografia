using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMonografia
{
    internal class Monografia
    {
        public int IdMonografia { get; set; }
        public string TituloMonografia { get; set; }
        public DateTime FechaDeDefensa {  get; set; }
        public double NotaDeDefensa { get; set; }
        public double TiempoOtorgado {  get; set; }
        public double TiempoDeDefensa { get; set; }
        public double TiempoDeQyA {  get; set; }
        public int IdProfesor {  get; set; }
        public string Carnet {  get; set; }
  
        public DateTime FechaCreacion { get; set; }= DateTime.Now;
        public List<string> CarnetEstudiantes { get; internal set; }
    }
}
