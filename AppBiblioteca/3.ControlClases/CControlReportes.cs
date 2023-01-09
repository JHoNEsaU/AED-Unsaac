using System;
using System.Collections.Generic;
using System.Text;

namespace AppBiblioteca
{
    public class CControlReportes
    {
        // ====================================================== SUB MENU DE CONTROL DEVOLUCION
        public static  void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("*                  CONTROL DE REPORTES                *");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("1.- Lista de préstamos en una fecha determinada");
            Console.WriteLine("2.- Lista de tesis de un asesor específico");
            Console.WriteLine("3.- Lista de tesis que no se devolvieron");
            Console.WriteLine("4.- Lista de tesis de un área considerando un año especifico hacia adelante");
            Console.WriteLine("5.- Lista de docentes con mayor número de tesis asesoradas");
            Console.WriteLine("6.- Salir");
        }

        // ====================================================== INICIAR SUB MENU
        public static void Ejecutar()
        {
            // ----- Procesar opciones y Menu
            int Opcion;
            do
            {

                Menu();
                // ----- Leer Opcion 
                Console.Write("Ingresa Opcion: ");

                Opcion = CControlGeneral.leerOpcion();
                Console.WriteLine("");
                Console.Clear();
                switch (Opcion)
                {
                    case 1:
                        CControlGeneral.controlPrestamo.ListaPrestamo.ListarPrestamo();
                        break;
                    case 2:
                        CControlGeneral.controlPrestamo.ListaPrestamo.ListaPrestamosFechaDeterminada();
                        break;
                    case 3:
                        CControlGeneral.controlTesis.ListaTesis.ListarTesisAreaAnioAdelante();
                        break;
                    case 4:
                        CControlGeneral.controlTesis.ListaTesis.ListaTesisAsesorEspecifico();
                        break;
                    case 5:
                        CControlGeneral.controlTesis.ListaTesis.Listar3DocentesMayoresTesisAsesoradas();
                        break;


                } // -- fin de switch 
            } while (Opcion < 6);
        }
    }
}
