using System;
using System.Collections.Generic;
using System.Text;

namespace AppBiblioteca
{
    public class CControlDevolucion
    {
        #region *********************** ATRIBUTOS ************************
        private CListaDevolucion aListaDevolucion;
        #endregion *********************** ATRIBUTOS ************************

        #region *********************** METODOS ************************

        #region ==================== CONSTRUCTORES =======================
        public CControlDevolucion()
        {
            aListaDevolucion = new CListaDevolucion();
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ==================== PROPIEDADES =======================
        public CListaDevolucion ListaDevolucion
        {
            get { return aListaDevolucion; }
            set { aListaDevolucion = value; }
        }
        #endregion ==================== PROPIEDADES =======================

        #region ====================   OTROS     =======================

        // ======================================================
        public void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("**************************************");
            Console.WriteLine("*       CONTROL DE LECTOR            *");
            Console.WriteLine("**************************************");
            Console.WriteLine("1.- Agregar Devolucion");
            Console.WriteLine("2.- Eliminar Devolucion");
            Console.WriteLine("3.- Listar Devoluciones");
            Console.WriteLine("4.- Buscar Devolucion");
            Console.WriteLine("5.- Lista de tesis que no se devolvieron");
            Console.WriteLine("6.- Salir");
        }

        // ======================================================
        public void Ejecutar()
        {
            // ----- Procesar opciones y Menu
            int Opcion;
            do
            {
                Menu();
                // ----- Leer Opcion 
                Console.Write("Ingresa Opcion: ");

                Opcion = CControlGeneral.leerOpcion();Opcion = CControlGeneral.leerOpcion();
                Console.WriteLine("");
                switch (Opcion)
                {
                    case 1:
                        ListaDevolucion.AgregarDevolucion();
                        break;
                    case 2:
                        ListaDevolucion.EliminarDevolucion();
                        break;
                    case 3:
                        ListaDevolucion.ListarDevoluciones();
                        break;
                    case 4:
                        ListaDevolucion.BuscarDevolucion();
                        break;
                    case 5:
                        CControlGeneral.controlPrestamo.ListaPrestamo.ListarPrestamo();
                        break;


                } // -- fin de switch 
            } while (Opcion < 6);
        }
        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************
    }
}
