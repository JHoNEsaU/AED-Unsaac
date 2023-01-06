using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesGenerales;

namespace AppBiblioteca
{
    public class CListaDevolucion : CListaObjetos
    {
        #region *********************** METODOS ************************

        #region ==================== CONSTRUCTORES =======================
        public CListaDevolucion() : base()
        {
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ====================   OTROS     =======================

        // ==============================================================
        public void AgregarDevolucion()
        {
            // ----- Crear objeto Libro y leer sus datos 
            CLector lector = new CLector();
            lector.Leer();
            // ----- Agregar objeto a la Lista de Libros
            Agregar(lector);
        }

        // ==============================================================
        public void ConsultarDevolucion()
        {
            // ----- Leer el identificador de libro que se desea buscar
            Console.WriteLine();
            Console.Write("Ingrese el identificador de Lector: ");
            string Id = Console.ReadLine();
            // ----- Determinar Indice o ubicacion del libro
            int I = Indice(Id);
            if (I >= 0)
            {
                CLector OLibro = (Listado.Iesimo(I) as CLector);
                OLibro.Mostrar();
            }
            else
                // ----- Objeto no existe en el listado, por tanto poner mensaje de error 
                Console.WriteLine(Id + " No existe en la lista...");
        }
        public void EliminarDevolucion()
        {
            // ----- Leer el identificador de libro que se desea buscar
            Console.WriteLine();
            Console.Write("Ingrese el identificador de Lector: ");
            string Id = Console.ReadLine();
            // ----- Determinar Indice o ubicacion del libro
            int I = Indice(Id);
            if (I >= 0)
            {
                Listado.Eliminar(I);
            }
            else
                // ----- Objeto no existe en el listado, por tanto poner mensaje de error 
                Console.WriteLine(Id + " No existe en la lista...");
        }
        // ======================================================
        public void SeleccionarLibros()
        {
            //// ----- Poner Titulo
            //Console.WriteLine();
            //Console.WriteLine("========================================================================");
            //Console.WriteLine("                          RELACION DE LIBROS");
            //Console.WriteLine("========================================================================");
            //Console.WriteLine("Id".PadRight(10) + "Titulo".PadRight(30) + "Autor".PadRight(20) + "Año".PadLeft(5) + " Especialidad".PadRight(15));
            //Console.WriteLine("------------------------------------------------------------------------");
            //RecorrerListado();
        }
        // ======================================================
        public void ListarDevoluciones()
        {
            // ----- Asignar null al delegado 
            deProcesarObjeto = null;
            // ----- Mostrar la lista de libros 
            SeleccionarLibros();
        }

        // ======================================================
        public void SeleccionarLibrosAutor()
        {
            //// ----- Leer el autor
            //Console.WriteLine("");
            //Console.Write("Ingrese el Autor: ");
            //string Autor = Console.ReadLine();

            //// ----- Asignar método al delegado 
            //deProcesarObjeto = delegate (Object O) {
            //    CLector OLibro = O as CLector;
            //    if (OLibro.Autor.Equals(Autor))
            //        OLibro.Escribir();
            //};
            //// ----- Mostrar la lista de libros de este autor
            //SeleccionarLibros();
        }

        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************

    }
}
