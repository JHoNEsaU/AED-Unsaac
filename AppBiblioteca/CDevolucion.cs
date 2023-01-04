using ClasesGenerales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    public class CDevolucion : CObjeto
    {
        private string IdDevolucion;
        private string FechaDevolucion;
        private string IdPrestamo;
        protected internal static CListaObjetos Devoluciones = new CListaObjetos();

        public CDevolucion(string pIdDevolucion, string pFechaDevolucion, string pIdPrestamo)
        {
            IdDevolucion = pIdDevolucion;
            FechaDevolucion = pFechaDevolucion;
            IdPrestamo = pIdPrestamo;
        }
        
    }
}
