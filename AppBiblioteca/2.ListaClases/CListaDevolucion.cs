﻿using System;
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
            CDevolucion devolucion = new CDevolucion();
            devolucion.Leer();
            // ----- Agregar objeto a la Lista de Libros
            if(CControlGeneral.controlPrestamo.ListaPrestamo.BuscarPrestamoID(devolucion.IdPrestamo) != null)
            {
                Agregar(devolucion);
                CControlGeneral.controlPrestamo.ListaPrestamo.Listado.Eliminar(CControlGeneral.controlPrestamo.ListaPrestamo.BuscarPrestamoID(devolucion.IdPrestamo));
                Console.Write("Se agrego correctamente el Elemento");
            }
            else
            {
                Console.WriteLine("Prestamo no encontrado");
            }
            

        }

        // ==============================================================
        public CDevolucion BuscarDevolucionID(string ID)
        {

            // ----- Determinar Indice o ubicacion del libro
            int I = Indice(ID);
            if (I > 0)
            {
                CDevolucion OLibro = (Listado.Iesimo(I) as CDevolucion);
                return OLibro;
            }
            else
                // ----- Objeto no existe en el listado, por tanto poner mensaje de error 
                return null;
        }
        public void BuscarDevolucion()
        {
            // ----- Leer el identificador de libro que se desea buscar
            Console.WriteLine();
            Console.Write("Ingrese el identificador de Lector: ");
            string Id = Console.ReadLine();
            // ----- Determinar Indice o ubicacion del libro
            int I = Indice(Id);
            if (I > 0)
            {
                CDevolucion OLibro = (Listado.Iesimo(I) as CDevolucion);
                OLibro.Escribir();
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
            if (I > 0)
            {
                Listado.Eliminar(I);
                Console.Write("Se elimino correctamente el Elemento ");
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
            //Console.WriteLine("                          RELACION DE DEVOLUCIONES");
            //Console.WriteLine("========================================================================");
            //Console.WriteLine("Id Devolucion".PadRight(20) + "Fecha de Devolucion".PadRight(20) + "Id de Prestamo".PadRight(20));
            //Console.WriteLine("------------------------------------------------------------------------");
            RecorrerListado();
        }
        // ======================================================
        public void ListarDevoluciones()
        {
            // ----- Asignar null al delegado 
            deProcesarObjeto = null;
            // ----- Mostrar la lista de libros 
            SeleccionarLibros();
        }


        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************

    }
}
