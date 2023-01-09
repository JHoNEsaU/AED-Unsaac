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

        // ============================================================== AGREGAR PRESTAMO VERIFICANDO SI EXISTE UN PRESTAMO, TAMBIEN UNA DEVOLUCION
        public void AgregarPrestamo()
        {
            // ----- Crear objeto Prestamo y leer sus datos 
            CPrestamo prestamo = new CPrestamo();
            prestamo.Leer();

            if (CControlGeneral.controlDevolucion.ListaDevolucion.BuscarDevolucionID(prestamo.Id) == null)
            {
                CTesis Aux = new CTesis();
                CLector AuxL = new CLector();
                AuxL.Id = prestamo.IdLector;
                Aux.Id = prestamo.IdLibro;
                int I = CControlGeneral.controlTesis.ListaTesis.Indice(Aux);
                int I2 = CControlGeneral.controlLector.ListaLector.Indice(AuxL);
                if (I == 0 && I2 == 0)
                {
                    Console.WriteLine("Datos Incorrectos ");
                }                else
                {
                    Agregar(prestamo);
                    Console.WriteLine("Elemento agregado correctamente");
                }
                // ----- Agregar objeto a la Lista de Prestamos

                

            }
            else
            {
                CTesis Aux = new CTesis();
                CLector AuxL = new CLector();
                AuxL.Id = prestamo.IdLector;
                Aux.Id = prestamo.IdLibro;
                int I = CControlGeneral.controlTesis.ListaTesis.Indice(Aux);
                int I2 = CControlGeneral.controlLector.ListaLector.Indice(AuxL);
                if (I == 0 && I2 == 0) 
                {
                    Console.WriteLine("Datos Incorrectos ");         
                }                else
                {
                    Agregar(prestamo);
                    // ----- Eliminar Prestamo
                    CControlGeneral.controlDevolucion.ListaDevolucion.Listado.Eliminar(CControlGeneral.controlDevolucion.ListaDevolucion.BuscarDevolucionID(prestamo.Id));
                    
                }
                
            }
            
        }
        // ============================================================ BUSCAR PRESTAMO POR ID ============================================================
        public CPrestamo BuscarPrestamoID(string ID)
        {

            // ----- Determinar Indice o ubicacion del Prestamo
            int I = Indice(ID);
            if (I > 0)
            {
                CPrestamo OLibro = (Listado.Iesimo(I) as CPrestamo);
                return OLibro;
            }
            else
                // ----- Objeto no existe en el listado, por tanto poner mensaje de error 
                return null;
        }

        // ============================================================== BUSCAR PRESTAMO ============================================================
        public void BuscarPrestamo()
        {
            // ----- Leer el identificador de prestamo que se desea buscar
            Console.WriteLine();
            Console.Write("Ingrese el identificador del Prestamo: ");
            string Id = Console.ReadLine();
            // ----- Determinar Indice o ubicacion del prestamo
            int I = Indice(Id);
            if (I > 0)
            {
                CPrestamo prestamo = (Listado.Iesimo(I) as CPrestamo);
                prestamo.Escribir();
            }
            else
                // ----- Objeto no existe en el listado, por tanto poner mensaje de error 
                Console.WriteLine(Id + " No existe en la lista...");
        }

        // ============================================================== ELIMUNAR PRESTAMO 
        public void EliminarPrestamo()
        {
            // ----- Leer el identificador de prestamo que se desea buscar
            Console.WriteLine();
            Console.Write("Ingrese el identificador del Prestamo: ");
            string Id = Console.ReadLine();
            // ----- Determinar Indice o ubicacion del prestamo
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
            //Console.WriteLine("                          RELACION DE PRESTAMOS");
            //Console.WriteLine("========================================================================");
            //Console.WriteLine("Id".PadRight(20) + "Fecha de Prestamo".PadRight(20) + "Fecha de Devolucion".PadRight(20) + "Id de Lector".PadRight(20) + "Id de Libro".PadRight(20));
            Console.WriteLine("------------------------------------------------------------------------");
            RecorrerListado();
        }
        // ====================================================== LISTADO DE PRESTAMOS 
        public void ListarPrestamo()
        {
            // ----- Asignar null al delegado 
            deProcesarObjeto = null;
            // ----- Mostrar la lista de Prestamo 
            SeleccionarLibros();
        }

        // ====================================================== LISTAR PRESTAMOS DE UNA FECHA DETERMINDA
        public void ListaPrestamosFechaDeterminada()
        {
            // ----- Leer la fecha
            Console.WriteLine("");
            Console.WriteLine("Ingrese la fecha  ASI -----> (dd/MM/AA): ");
            Console.WriteLine("");
            string fecha = Console.ReadLine();
            Console.WriteLine("======= Prestamos en la fecha {0} ========", fecha);
            // ----- Asignar método al delegado 
            bool noHay = true;
            deProcesarObjeto = delegate (Object O)
            {
                CPrestamo OPrestamo = O as CPrestamo;
                if (OPrestamo.FechaPrestamo == fecha)
                {
                    noHay = false;
                    OPrestamo.Escribir();
                }
                
            };
            // ----- Mostrar la lista de libros de este autor
            SeleccionarLibros();
            if (noHay) Console.WriteLine("No hay prestamos en la fecha especificada");
        }

        // ====================================================== LISTAR PRESTAMOS 




        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************
    }
}
