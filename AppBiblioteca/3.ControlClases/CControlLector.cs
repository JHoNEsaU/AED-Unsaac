using System;
using System.Collections.Generic;
using System.Text;
using ClasesGenerales;

namespace AppBiblioteca._3.ControlClases
{
    internal class CControlLector
    {
        #region *********************** ATRIBUTOS ************************
        private CListaLector aListaLector;
        #endregion *********************** ATRIBUTOS ************************

        #region *********************** METODOS ************************

        #region ==================== CONSTRUCTORES =======================
        public CControlLector()
        {
            aListaLector = new CListaLector();
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ==================== PROPIEDADES =======================
        public CListaLector ListaLector
        {
            get { return aListaLector; }
            set { aListaLector = value; }
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
            Console.WriteLine("1.- Registrar Libro");
            Console.WriteLine("2.- Consultar Libro");
            Console.WriteLine("3.- Listar Libros");
            Console.WriteLine("4.- Seleccionar Libros de un Autor");
            Console.WriteLine("5.- Seleccionar Libros de una Especialidad");
            Console.WriteLine("6.- Seleccionar Libros de un Año");
            Console.WriteLine("7.- Salir");
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
                        ListaLector.AgregarLibro();
                        break;
                    case 2:
                        ListaLector.ConsultarLibro();
                        break;
                    case 3:
                        ListaLector.ListarLibros();
                        break;
                    case 4:
                        ListaLector.SeleccionarLibrosAutor();
                        break;
                    case 5:
                        ListaLector.SeleccionarLibrosEspecialidad();
                        break;
                    case 6:
                        ListaLector.SeleccionarLibrosAnio();
                        break;
                } // -- fin de switch 
            } while (Opcion < 7);
        }
        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************
    }
}
