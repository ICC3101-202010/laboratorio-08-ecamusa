using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_8
{
    [Serializable]
    class Tienda
    {
        
        string name, rut, horario, particularidad;
        public Tienda()
        {

        }
        public Tienda(string aname,string arut, string ahorario, string aparticularidad)
        {
            name = aname;
            rut = arut;
            horario = ahorario;
            particularidad = aparticularidad;
        }
        public string infotienda()
        {
            return " nombre dueno: " + name + " numero identificador: " + rut + " horario: " + horario + " categoria: " + particularidad;
        }

    }
}
