using System;
using System.Collections.Generic;
using System.Text;
using ClasesGenerales;

namespace AppBiblioteca
{
    public class CListaLector : CListaObjetos
    {
        #region *********************** METODOS ************************

        #region ==================== CONSTRUCTORES =======================
        public CListaLector() : base()
        {

        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ====================   OTROS     =======================

        // ============================================================== AGREGAR LECTOR  VERIFICANDO SI EXISTE O NO ESTA ==============================================================
        public void AgregarLector()
        {
            // ----- Crear objeto Libro y leer sus datos 
            CLector lector = new CLector();
            lector.Leer();
            int I = Indice(lector);
            if(I == 0)
            {
                // ----- Agregar objeto a la Lista de Lectores
                Agregar(lector);
                Console.WriteLine("Se agrego correctamente el Elemento");
            }
            else
            {
                Console.WriteLine("Ya existe elemento");
            }
            
           
        }

        // ============================================================== BUSCAR LECTOR EN LISTA ==============================================================
        public void BuscarLector()
        {
            // ----- Leer el identificador de libro que se desea buscar
            Console.WriteLine();
            Console.Write("Ingrese el identificador de Lector: ");
            string Id = Console.ReadLine();
            // ----- Determinar Indice o ubicacion del Lectores
            int I = Indice(Id);
            if (I > 0)
            {
                CLector lector = (Listado.Iesimo(I) as CLector);
                lector.Escribir();
            }
            else
                // ----- Objeto no existe en el listado, por tanto poner mensaje de error 
                Console.WriteLine(Id + " No existe en la lista...");
        }
        // ============================================================== ELIMINAR LECTOR DE LISTA ==============================================================
        public void EliminarLector()
        {
            // ----- Leer el identificador de Lectores que se desea buscar
            Console.WriteLine();
            Console.Write("Ingrese el identificador de Lector: ");
            string Id = Console.ReadLine();
            // ----- Determinar Indice o ubicacion del Lectores
            int I = Indice(Id);
            if (I > 0)
            {
                Listado.Eliminar(I);
                Console.Write("Se elimino correctamente el Elemento ");
            }
            else
                // ----- Objeto no existe en el listado, por tanto poner mensaje de error 
                Console.WriteLine(Id + " No existe en la lista ");
        }
        // ======================================================
        public void SeleccionarLibros()
        {
            //// ----- Poner Titulo
            //Console.WriteLine();
            //Console.WriteLine("========================================================================");
            //Console.WriteLine("                          RELACION DE LECTORES                           ");
            //Console.WriteLine("========================================================================");
            //Console.WriteLine("Id Lector".PadRight(20) + "Apellidos".PadRight(20) + "Nombres".PadRight(20) + "Direccion".PadRight(20) + "Sexo".PadRight(20) + "Edad".PadRight(20));
            //Console.WriteLine("------------------------------------------------------------------------");
            RecorrerListado();
        }
        // ====================================================== LISTAR LECTOR
        public void ListarLector()
        {
            // ----- Asignar null al delegado 
            deProcesarObjeto = null;
            // ----- Mostrar la lista de Lectores 
            SeleccionarLibros();
        }



        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************
    }
}

