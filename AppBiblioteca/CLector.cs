using System;
using System.Collections.Generic;
using System.Text;

namespace EstDatos
{
    class CLector
    {
        public string idLector;
        public string apellidos;
        public string nombres;
        public string direccion;
        public string sexo;
        public string edad;

        public CLector(string PidLector, string Papellidos, string Pnombres, string Pdireccion, string Psexo, string Pedad)
        {
            idLector = PidLector;
            apellidos = Papellidos;
            nombres = Pnombres;
            direccion = Pdireccion;
            sexo = Psexo;
            edad = Pedad;
        }
    }
}
