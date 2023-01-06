using System;
using System.Collections.Generic;
using System.Text;

namespace AppBiblioteca
{
    internal class CControlPrestamo
    {
        #region *********************** ATRIBUTOS ************************
        private CListaPrestamo aListaPrestamo;
        #endregion *********************** ATRIBUTOS ************************

        #region *********************** METODOS ************************

        #region ==================== CONSTRUCTORES =======================
        public CControlPrestamo()
        {
            aListaPrestamo = new CListaPrestamo();
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ==================== PROPIEDADES =======================
        public CListaPrestamo ListaLector
        {
            get { return aListaPrestamo; }
            set { aListaPrestamo = value; }
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
            Console.WriteLine("1.- Agergar Prestamo");
            Console.WriteLine("2.- Eliminar Prestamo");
            Console.WriteLine("3.- Listar Prestamo");
            Console.WriteLine("4.- Buscar Prestamo");
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
                        ListaLector.AgregarPrestamo();
                        break;
                    case 2:
                        ListaLector.EliminarPrestamo();
                        break;
                    case 3:
                        ListaLector.ListarPrestamo();
                        break;
                    case 4:
                        ListaLector.BuscarPrestamo();
                        break;

                } // -- fin de switch 
            } while (Opcion < 5);
        }
        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************
    }
}
