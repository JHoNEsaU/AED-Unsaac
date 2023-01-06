using ClasesGenerales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AppBiblioteca
{
    public class CDevolucion : CObjeto
    {
        private string aIdDevolucion;
        private string aFechaDevolucion;
        private string aIdPrestamo;
        protected internal static CListaObjetos Devoluciones = new CListaObjetos();

        public CDevolucion()
        {

        }

        public CDevolucion(string pIdDevolucion, string pFechaDevolucion, string pIdPrestamo):base(pIdDevolucion)
        {
            
            aIdDevolucion = pIdDevolucion;
            aFechaDevolucion = pFechaDevolucion;
            aIdPrestamo = pIdPrestamo;
        }
        #region ====================================================== PROPIEDADES ======================================================
        public string IdDevolucion
        {
            get { return Id; }
            set { Id = value; }
        }
        public string FechaDevolucion
        {
            get { return aFechaDevolucion; }
            set { aFechaDevolucion = value; }
        }
        public string IdPrestamo
        {
            get { return aIdPrestamo; }
            set { aIdPrestamo = value; }
        }
        #endregion
        public override void Leer()
        {
            Console.WriteLine(" ============ INTRODUCIR DATOS DE DEVOLUCION ============");
            Console.WriteLine("Introducir ID de devolucion: ");
            Id = Console.ReadLine();
            Console.WriteLine("Introducir fecha de devolucion: ");
            FechaDevolucion = Console.ReadLine();
            Console.WriteLine("Introducir ID prestamo: ");
            IdPrestamo = Console.ReadLine();
           
        }
        public override void Mostrar()
        {
            Console.WriteLine(Id.PadRight(20) + FechaDevolucion.PadRight(20) + IdPrestamo.PadRight(20));
        }

        public override void Escribir()
        {
            Console.WriteLine();
            Console.WriteLine("         DATOS DE DEVOLUCION");
            Console.WriteLine("======================================");
            Console.WriteLine("Identificador devolucion : " + Id);
            Console.WriteLine("Fecha de devolucion      : " + aFechaDevolucion);
            Console.WriteLine("Identificador prestamo   : " + aIdPrestamo);
            Console.WriteLine("======================================");
        }

    }
}
