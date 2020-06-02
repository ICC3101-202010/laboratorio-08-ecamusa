using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_8
{
    [Serializable]
    class Cine
    {
        string name, rut, horario, particularidad;
        public Cine()
        {

        }
        public Cine(string aname, string arut, string ahorario, string aparticularidad)
        {
            name = aname;
            rut = arut;
            horario = ahorario;
            particularidad = aparticularidad;
        }
        public string infocine()
        {
            return "nombre dueno: " + name + " numero identificador: " + rut + " horario: " + horario + " numero de salas: " + particularidad;
        }

    }
}
