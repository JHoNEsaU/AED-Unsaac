using System;
using System.Collections.Generic;
using System.Text;
using ClasesGenerales;

namespace EstDatos
{
    class CLector : CObjeto
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
        public override void Leer()
        {
            base.Leer();
        }
        public override void Mostrar()
        {
            base.Mostrar();
        }

        public override void Escribir()
        {
            base.Escribir();
        }
    }
}
