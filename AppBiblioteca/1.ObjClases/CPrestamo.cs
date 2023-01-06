using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesGenerales;
namespace AppBiblioteca
{
    public class CPrestamo : CObjeto
    {
        private string aIdPrestamo;
        private string aFechaPrestamo;
        private string aFechaDevolucion;
        private string aIdLector;
        private string aIdLibro;
        protected internal static CListaObjetos LibPrestamos = new CListaObjetos();

        public CPrestamo()
        {

        }

        public CPrestamo(string pIdPrestamo, string pFechaPrestamo, string pFechaDevolucion, 
            string pIdLector, string pIdLibro):base(pIdPrestamo)
        {
            aIdPrestamo = pIdPrestamo;
            aFechaPrestamo = pFechaPrestamo;
            aFechaDevolucion = pFechaDevolucion;
            aIdLector = pIdLector;
            aIdLibro = pIdLibro;
        }
        #region ====================================================== PROPIEDADES ======================================================
        public string IdPrestamo
        {
            get { return aIdPrestamo; }
            set { aIdPrestamo = value; }
        }
        public string FechaPrestamo
        {
            get { return aFechaPrestamo; }
            set { aFechaPrestamo = value; }
        }
        public string FechaDevolucion
        {
            get { return aFechaDevolucion; }
            set { aFechaDevolucion = value; }
        }
        public string IdLector
        {
            get { return aIdLector; }
            set { aIdLector = value; }
        }
        public string IdLibro
        {
            get { return aIdLibro; }
            set { aIdLibro = value; }
        }

        #endregion
        public override void Leer()
        {
            Console.WriteLine(" ============ INTRODUCIR DATOS DE PRESTAMO ============");
            Console.WriteLine("Introducir ID de prestamo: ");
            Id = Console.ReadLine();
            Console.WriteLine("Introducir fecha de prestamo: ");
            FechaPrestamo = Console.ReadLine();
            Console.WriteLine("Introducir fecha de devolucion: ");
            FechaDevolucion = Console.ReadLine();
            Console.WriteLine("Introducir Id de lector: ");
            IdLector = Console.ReadLine();
            Console.WriteLine("Introducir Id de libro: ");
            IdLibro = Console.ReadLine();

        }
        public override void Mostrar()
        {
            base.Mostrar();
        }

        public override void Escribir()
        {
            Console.WriteLine();
            Console.WriteLine("           DATOS DE OBJETO");
            Console.WriteLine("======================================");
            Console.WriteLine("Identificador prestamo : " + Id);
            Console.WriteLine("Fecha de prestamo      : " + aFechaPrestamo);
            Console.WriteLine("Fecha de devolucion    : " + aFechaDevolucion);
            Console.WriteLine("Identificador lector   : " + aIdLector);
            Console.WriteLine("Identificador libro    : " + aIdLibro);
            Console.WriteLine("======================================");
        }
    }
}
