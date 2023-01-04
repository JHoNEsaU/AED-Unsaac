using System;
using System.Collections.Generic;
using System.Text;

namespace EstDatos
{
    class CTesis
    {
        public string idTesis;
        public string titulo;
        public string autor;
        public string anio;
        public string area;
        public string asesor;

        public CTesis(string PidTesis, string Ptitulo, string Pautor, string Panio,string Parea, string Pasesor)
        {
            idTesis = PidTesis;
            titulo = Ptitulo;
            autor = Pautor;
            anio = Panio;
            area = Parea;
            asesor = Pasesor;
        }


    }
}
