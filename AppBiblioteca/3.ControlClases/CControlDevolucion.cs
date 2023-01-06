using System;
using System.Collections.Generic;
using System.Text;

namespace AppBiblioteca
{
    internal class CControlDevolucion
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
        public CListaDevolucion ListaLector
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
            Console.WriteLine("5.- Salir");
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
                Opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                switch (Opcion)
                {
                    case 1:
                        ListaLector.AgregarDevolucion();
                        break;
                    case 2:
                        ListaLector.EliminarDevolucion();
                        break;
                    case 3:
                        ListaLector.ListarDevoluciones();
                        break;
                    case 4:
                        ListaLector.BuscarDevolucion();
                        break;

                } // -- fin de switch 
            } while (Opcion < 5);
        }
        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************
    }
}
