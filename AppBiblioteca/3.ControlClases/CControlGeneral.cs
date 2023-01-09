using System;
using System.Collections.Generic;
using System.Text;
using ClasesGenerales;

namespace AppBiblioteca
{
    public class CControlGeneral
    {
        // ===================================== INICIALIZANDO CONTROLES DE CLASE =====================================
        public static CControlLector controlLector = new CControlLector();
        public static CControlPrestamo controlPrestamo = new CControlPrestamo();
        public static CControlTesis  controlTesis = new CControlTesis();
        public static CControlDevolucion controlDevolucion = new CControlDevolucion();
        public CControlPrestamo ControlPrestamo
        {
            get { return controlPrestamo; }
        }
        // ====================================================== MENU DE CONTROL GENERAL
        public void MENU()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("**********************************************");
            Console.WriteLine("*         CONTROL DE MENU PRINCIPAL          *");
            Console.WriteLine("**********************************************");
            Console.WriteLine("1.- Operacion Tesis");
            Console.WriteLine("2.- Operacion Lectores");
            Console.WriteLine("3.- Operacion Prestamos");
            Console.WriteLine("4.- Operacion Devoluciones");
            Console.WriteLine("5.- Operaciones de Reportes");
            Console.WriteLine("6.- Salir");
        }

        // ==================================================== LEER OPCION VALIDANDO
        static public int leerOpcion()
        {
            int opcion = 0;
            try
            {
                opcion = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
              
                Console.Write("Introducir input correctamente : " );
                leerOpcion();
                Console.Clear();
            }
            return opcion;
        }

        // ====================================================== INICIAR MENU PRINCIPAL
        public void EJECUTARPRINCIPAL()
        {
            // ----- Procesar opciones y Menu
            int Opcion;
            do
            {
                Console.Clear();
                MENU();
                // ----- Leer Opcion 
                Console.Write("Ingresa Opcion: ");
                Opcion = leerOpcion();
                Console.WriteLine("");
                switch (Opcion)
                {
                    case 1:
                        controlTesis.Ejecutar();
                        break;
                    case 2:
                        controlLector.Ejecutar();
                        break;
                    case 3:
                        controlPrestamo.Ejecutar();
                        break;
                    case 4:
                        controlDevolucion.Ejecutar();
                        break;
                    case 5:
                        CControlReportes.Ejecutar();
                        break;

                } // -- fin de switch 
            } while (Opcion < 5);
        }
    }
}
