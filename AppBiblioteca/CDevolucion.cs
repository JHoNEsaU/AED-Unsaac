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

        public CDevolucion(string pIdDevolucion, string pFechaDevolucion, string pIdPrestamo):base(pIdDevolucion)
        {
            
            aIdDevolucion = pIdDevolucion;
            aFechaDevolucion = pFechaDevolucion;
            aIdPrestamo = pIdPrestamo;
        }
        
    }
}
