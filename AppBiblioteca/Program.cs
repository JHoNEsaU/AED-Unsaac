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
            // ============= INICIANDO POROGRAMA ===========================
            CDatos.EJECUTARDATOS();
            CControlGeneral controlGeneral = new CControlGeneral();
            controlGeneral.EJECUTARPRINCIPAL();

        }
    }
}
