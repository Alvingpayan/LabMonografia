using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMonografia
{
    internal class mEstudiante
    {
        public int IdMonografia { get; set; }
        public string Carnet {  get; set; }
        public  mEstudiante (int idMonografia, string carnet)
        {
            IdMonografia = idMonografia;
            Carnet = carnet;
        }
    }
}
