using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_8
{
    [Serializable]
    class Recreacional
    {
        string name, rut, horario, particularidad;
        public Recreacional()
        {

        }
        public Recreacional(string aname, string arut, string ahorario)
        {
            name = aname;
            rut = arut;
            horario = ahorario;
        }
        public string inforecreacional()
        {
            return "nombre dueno: " + name + " numero identificador: " + rut + " horario: " + horario;
        }


    }
}
