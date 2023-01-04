using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibTADS;
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

        public CPrestamo(string pIdPrestamo, string pFechaPrestamo, string pFechaDevolucion, 
            string pIdLector, string pIdLibro):base(pIdPrestamo)
        {
            aIdPrestamo = pIdPrestamo;
            aFechaPrestamo = pFechaPrestamo;
            aFechaDevolucion = pFechaDevolucion;
            aIdLector = pIdLector;
            aIdLibro = pIdLibro;
        }
    }
}
