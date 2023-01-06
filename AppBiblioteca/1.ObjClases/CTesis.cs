using System;
using System.Collections.Generic;
using System.Text;
using ClasesGenerales;

namespace AppBiblioteca
{
    class CTesis : CObjeto
    {
        public string idTesis;
        public string titulo;
        public string autor;
        public string anio;
        public string area;
        public string asesor;

        public CTesis()
        {

        }
        public CTesis(string PidTesis, string Ptitulo, string Pautor, string Panio,string Parea, string Pasesor)
        {
            idTesis = PidTesis;
            titulo = Ptitulo;
            autor = Pautor;
            anio = Panio;
            area = Parea;
            asesor = Pasesor;
        }

        #region ====================================================== PROPIEDADES ======================================================
        public string IdTesis
        {
            get { return Id; }
            set { Id = value; }
        }
        public string Titulo
        { 
            get {return titulo; }
            set { titulo= value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Asesor
        {
            get { return asesor; }
            set { asesor = value; }
        }
        #endregion

        public override void Leer()
        {
            Console.WriteLine(" ============ INTRODUCIR DATOS DE TESIS ============");
            Console.WriteLine("Introducir ID de Tesis: ");
            Id = Console.ReadLine();
            Console.WriteLine("Introducir titulo: ");
            Titulo = Console.ReadLine();
            Console.WriteLine("Introducir autor: ");
            Autor = Console.ReadLine();
            Console.WriteLine("Introducir anio: ");
            Anio = Console.ReadLine();
            Console.WriteLine("Introducir area: ");
            Area = Console.ReadLine();
            Console.WriteLine("Introducir asesor: ");
            Asesor = Console.ReadLine();
        }
        public override void Mostrar()
        {
            base.Mostrar();
        }

        public override void Escribir()
        {
            Console.WriteLine();
            Console.WriteLine("           DATOS DE TESIS");
            Console.WriteLine("======================================");
            Console.WriteLine("Identificador tesis : " + Id);
            Console.WriteLine("Titulo              : " + titulo);
            Console.WriteLine("Autor               : " + autor);
            Console.WriteLine("Anio                : " + anio);
            Console.WriteLine("Asesor              : " + asesor);
            Console.WriteLine("======================================");
        }

    }
}
