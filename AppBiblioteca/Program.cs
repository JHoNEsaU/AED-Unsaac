using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            //CControlGeneral controlGeneral = new CControlGeneral();
            //controlGeneral.EJECUTARPRINCIPAL();
            CListaTesis a = new CListaTesis();
            a.AgregarTesis();
            a.AgregarTesis();
            a.Listado.Ubicacion(a.Listado.Iesimo(1));
            a.mostrar();

        }
    }
}
