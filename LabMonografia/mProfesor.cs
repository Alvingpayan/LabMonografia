using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMonografia
{
    internal class mProfesor
    {
        public int IdMonografia {  get; set; }
        public int IdProfesor {  get; set; }
        public string Roll {  get; set; }
        public mProfesor (int IdMonografia ,int IdProfesor, string Roll)
        {
            IdMonografia = IdMonografia;
            IdProfesor = IdProfesor;
            Roll = Roll;
        }
    }
}
