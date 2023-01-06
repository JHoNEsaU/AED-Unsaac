using System;
using System.Collections.Generic;
using System.Text;
using ClasesGenerales;

namespace AppBiblioteca
{
    class CLector : CObjeto
    {
        //public string idLector; // ---> Heredando ID de CObjeto
        public string apellidos;
        public string nombres;
        public string direccion;
        public string sexo;
        public string edad;
        public CLector()
        {

        }
        public CLector(string PidLector, string Papellidos, string Pnombres, string Pdireccion, string Psexo, string Pedad): base(PidLector)
        {
        
            apellidos = Papellidos;
            nombres = Pnombres;
            direccion = Pdireccion;
            sexo = Psexo;
            edad = Pedad;
        }
        #region ====================================================== PROPIEDADES ======================================================
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        #endregion
        public override void Leer()
        {
            Console.WriteLine(" ============ INTRODUCIR DATOS DE LECTOR ============");
            Console.WriteLine("Introducir ID de Lector: ");
            Id = Console.ReadLine();
            Console.WriteLine("Introducir apellidos: ");
            Apellidos = Console.ReadLine();
            Console.WriteLine("Introducir nombres: ");
            Nombres = Console.ReadLine();
            Console.WriteLine("Introducir direccion: ");
            Direccion = Console.ReadLine();
            Console.WriteLine("Introducir sexo: ");
            Sexo = Console.ReadLine();
            Console.WriteLine("Introducir edad: ");
            Edad = Console.ReadLine();
        }
        public override void Mostrar()
        {
            Console.WriteLine(Id.PadRight(20) + Apellidos.PadRight(20) + Nombres.PadRight(20) + Direccion.PadRight(20) + Sexo.PadRight(20) + Edad.PadRight(20));
        }

        public override void Escribir()
        {
            Console.WriteLine();
            Console.WriteLine("           DATOS DE OBJETO");
            Console.WriteLine("======================================");
            Console.WriteLine("Identificador: " + Id);
            Console.WriteLine("Apellidos    : " + apellidos);
            Console.WriteLine("Nombres      : " + nombres);
            Console.WriteLine("Direccion    : " + direccion);
            Console.WriteLine("Sexo         : " + sexo);
            Console.WriteLine("Edad         : " + edad);
            Console.WriteLine("======================================");
        }
    }
}
