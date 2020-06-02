using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_8
{
    [Serializable]
    class Restaurantes
    {
        string name, rut, horario, particularidad;
        public Restaurantes()
        {

        }
        public Restaurantes(string aname, string arut, string ahorario, string aparticularidad)
        {
            name = aname;
            rut = arut;
            horario = ahorario;
            particularidad = aparticularidad;
        }
        public string inforestaurante()
        {
            return "nombre dueno: " + name + " numero identificador: " + rut + " horario: " + horario + " mesas exlusivas: " + particularidad;
        }
    }
}
