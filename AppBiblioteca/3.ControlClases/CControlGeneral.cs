using System;
using System.Collections.Generic;
using System.Text;
using ClasesGenerales;

namespace AppBiblioteca
{
    internal class CControlGeneral
    {
        CControlLector controlLector = new CControlLector();
        CControlPrestamo controlPrestamo = new CControlPrestamo();
        CControlTesis controlTesis = new CControlTesis();
        CControlDevolucion controlDevolucion = new CControlDevolucion();
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
            Console.WriteLine("5.- Salir");
        }
       
        public void EJECUTARPRINCIPAL()
        {
            // ----- Procesar opciones y Menu
            int Opcion;
            do
            {
                MENU();
                // ----- Leer Opcion 
                Console.Write("Ingresa Opcion: ");
                Opcion = int.Parse(Console.ReadLine());
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

                } // -- fin de switch 
            } while (Opcion < 5);
        }
    }
}
