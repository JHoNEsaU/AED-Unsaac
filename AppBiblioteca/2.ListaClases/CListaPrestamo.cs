using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClasesGenerales;

namespace AppBiblioteca
{
    public class CListaPrestamo : CListaObjetos
    {
        #region *********************** METODOS ************************

        #region ==================== CONSTRUCTORES =======================
        public CListaPrestamo() : base()
        {
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ====================   OTROS     =======================

        // ==============================================================
        public void AgregarPrestamo()
        {
            // ----- Crear objeto Libro y leer sus datos 
            CPrestamo prestamo = new CPrestamo();
            prestamo.Leer();
            if (CControlGeneral.controlDevolucion.ListaDevolucion.BuscarDevolucionID(prestamo.Id) == null)
            {
                // ----- Agregar objeto a la Lista de Libros
                Agregar(prestamo);

                // ----- Eliminar Prestamo
                CControlGeneral.controlDevolucion.ListaDevolucion.Listado.Eliminar(CControlGeneral.controlDevolucion.ListaDevolucion.BuscarDevolucionID(prestamo.Id));
            }
            else
            {
                Console.WriteLine("Devolucion no encontrada");
            }
            
        }

        public CPrestamo BuscarPrestamoID(string ID)
        {

            // ----- Determinar Indice o ubicacion del libro
            int I = Indice(ID);
            if (I >= 0)
            {
                CPrestamo OLibro = (Listado.Iesimo(I) as CPrestamo);
                return OLibro;
            }
            else
                // ----- Objeto no existe en el listado, por tanto poner mensaje de error 
                return null;
        }

        // ==============================================================
        public void BuscarPrestamo()
        {
            // ----- Leer el identificador de libro que se desea buscar
            Console.WriteLine();
            Console.Write("Ingrese el identificador de Lector: ");
            string Id = Console.ReadLine();
            // ----- Determinar Indice o ubicacion del libro
            int I = Indice(Id);
            if (I >= 0)
            {
                CPrestamo OLibro = (Listado.Iesimo(I) as CPrestamo);
                OLibro.Mostrar();
            }
            else
                // ----- Objeto no existe en el listado, por tanto poner mensaje de error 
                Console.WriteLine(Id + " No existe en la lista...");
        }

        public void EliminarPrestamo()
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
            // ----- Poner Titulo
            Console.WriteLine();
            Console.WriteLine("========================================================================");
            Console.WriteLine("                          RELACION DE PRESTAMOS");
            Console.WriteLine("========================================================================");
            Console.WriteLine("Id".PadRight(20) + "Fecha de Prestamo".PadRight(20) + "Fecha de Devolucion".PadRight(20) + "Id de Lector".PadRight(20) + "Id de Libro".PadRight(20));
            Console.WriteLine("------------------------------------------------------------------------");
            RecorrerListado();
        }
        // ======================================================
        public void ListarPrestamo()
        {
            // ----- Asignar null al delegado 
            deProcesarObjeto = null;
            // ----- Mostrar la lista de libros 
            SeleccionarLibros();
        }

        // ======================================================
        public void ListaPrestamosFechaDeterminada()
        {
            // ----- Leer la fecha
            Console.WriteLine("");
            Console.WriteLine("Ingrese la fecha  ASI -----> (dd/MM/AA): ");
            string fecha = Console.ReadLine();

            // ----- Asignar método al delegado 
            deProcesarObjeto = delegate (Object O)
            {
                CPrestamo prestamo = O as CPrestamo;
                if (prestamo.FechaPrestamo.Equals(fecha)) prestamo.Escribir();
            };
            // ----- Mostrar la lista de libros de este autor
            SeleccionarLibros();
        }

        public void ListarPrestamosFecha(CListaObjetos lista)
        {
            // ----- Leer el autor
            Console.WriteLine("");
            Console.Write("Ingrese la fecha: ");
            string Fecha = Console.ReadLine();

            // ----- Asignar método al delegado 
            deProcesarObjeto = delegate (Object O)
            {
                CPrestamo OPrestamo = O as CPrestamo;
                if (OPrestamo.FechaPrestamo == Fecha)
                    OPrestamo.Escribir();
            };
            // ----- Mostrar la lista de libros de este autor
            SeleccionarLibros();
        }



        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************
    }
}
