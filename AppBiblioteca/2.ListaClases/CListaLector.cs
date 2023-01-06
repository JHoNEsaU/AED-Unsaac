using System;
using System.Collections.Generic;
using System.Text;
using ClasesGenerales;

namespace AppBiblioteca
{
    internal class CListaLector : CListaObjetos
    {
        #region *********************** METODOS ************************

        #region ==================== CONSTRUCTORES =======================
        public CListaLector() : base()
        {
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ====================   OTROS     =======================

        // ==============================================================
        public void AgregarLibro()
        {
            // ----- Crear objeto Libro y leer sus datos 
            CLector lector = new CLector();
            lector.Leer();
            // ----- Agregar objeto a la Lista de Libros
            Agregar(lector);
        }

        // ==============================================================
        public void ConsultarLibro()
        {
            // ----- Leer el identificador de libro que se desea buscar
            Console.WriteLine();
            Console.Write("Ingrese el identificador de Lector: ");
            string Id = Console.ReadLine();
            // ----- Determinar Indice o ubicacion del libro
            int I = Indice(Id);
            if (I >= 0)
            {
                CLector OLibro = (Listado[I] as CLector);
                OLibro.Mostrar();
            }
            else
                // ----- Objeto no existe en el listado, por tanto poner mensaje de error 
                Console.WriteLine(Id + " No existe en la lista...");
        }
        // ======================================================
        public void SeleccionarLibros()
        {
            // ----- Poner Titulo
            Console.WriteLine();
            Console.WriteLine("========================================================================");
            Console.WriteLine("                          RELACION DE LIBROS");
            Console.WriteLine("========================================================================");
            Console.WriteLine("Id".PadRight(10) + "Titulo".PadRight(30) + "Autor".PadRight(20) + "Año".PadLeft(5) + " Especialidad".PadRight(15));
            Console.WriteLine("------------------------------------------------------------------------");
            RecorrerListado();
        }
        // ======================================================
        public void ListarLibros()
        {
            // ----- Asignar null al delegado 
            deProcesarObjeto = null;
            // ----- Mostrar la lista de libros 
            SeleccionarLibros();
        }

        // ======================================================
        public void SeleccionarLibrosAutor()
        {
            // ----- Leer el autor
            Console.WriteLine("");
            Console.Write("Ingrese el Autor: ");
            string Autor = Console.ReadLine();

            // ----- Asignar método al delegado 
            deProcesarObjeto = delegate (Object O)
            {
                CLector OLibro = O as CLector;
                if (OLibro.Autor.Equals(Autor))
                    OLibro.Escribir();
            };
            // ----- Mostrar la lista de libros de este autor
            SeleccionarLibros();
        }

        // ======================================================
        public void SeleccionarLibrosEspecialidad()
        {
            // ----- Leer el especialidad
            Console.WriteLine("");
            Console.Write("Ingrese la Especialidad: ");
            string Especialidad = Console.ReadLine();

            // ----- Asignar método al delegado 
            deProcesarObjeto = delegate (Object O)
            {
                CLibro OLibro = O as CLibro;
                if (OLibro.Especialidad.Equals(Especialidad))
                    OLibro.Escribir();
            };
            // ----- Mostrar la lista de libros de esta especialidad
            SeleccionarLibros();
        }

        // ======================================================
        public void SeleccionarLibrosAnio()
        {
            // ----- Leer el Año
            Console.WriteLine("");
            Console.Write("Ingrese el Año: ");
            int Anio = int.Parse(Console.ReadLine());

            // ----- Mostrar la lista de libros de este año

            // ----- Asignar método al delegado 
            deProcesarObjeto = delegate (Object O)
            {
                CLibro OLibro = O as CLibro;
                if (OLibro.Anio == Anio)
                    OLibro.Escribir();
            };
            // ----- Mostrar la lista de libros de esta especialidad
            SeleccionarLibros();
        }




        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************
    }
}

