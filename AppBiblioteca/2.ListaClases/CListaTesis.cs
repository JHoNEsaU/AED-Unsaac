using System;
using System.Collections.Generic;
using System.Text;
using ClasesGenerales;
using EstDatos;
namespace AppBiblioteca
{
    public class CListaTesis : CListaObjetos
    {

        #region *********************** METODOS ************************

        #region ==================== CONSTRUCTORES =======================
        public CListaTesis() : base()
        {
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ====================   OTROS     =======================

        // ============================================================== AGREGAR TESIS VERIFICANDO SI EXISTE O NO ESTA
        public void AgregarTesis()
        {
            // ----- Crear objeto Libro y leer sus datos 
            CTesis tesis = new CTesis();
            tesis.Leer();
            int I = Indice(tesis.Id);
            if(I == 0)
            {
                // ----- Agregar objeto a la Lista de Tesis
                Agregar(tesis);
                Console.WriteLine("Se agrego correctamente el elemento");
            }
            else
            {
                Console.WriteLine("Ya existe elemento");
            }
            
            
        }

        // ============================================================== BUSCAR TESIS 
        public void BuscarTesis()
        {
            // ----- Leer el identificador de libro que se desea buscar
            Console.WriteLine();
            Console.Write("Ingrese el identificador de Lector: ");
            string Id = Console.ReadLine();
            // ----- Determinar Indice o ubicacion del libro
            int I = Indice(Id);
            if (I > 0)
            {
                CTesis OLibro = (Listado.Iesimo(I) as CTesis);
                OLibro.Escribir();
            }
            else
                // ----- Objeto no existe en el listado, por tanto poner mensaje de error 
                Console.WriteLine(Id + " No existe en la lista...");
        }

        //====================================================== ELIMINAR TESIS DE LISTA
        public void EliminarTesis()
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
        public void ListadoTesis()
        {
            //// ----- Poner Titulo
            //Console.WriteLine();
            //Console.WriteLine("========================================================================");
            //Console.WriteLine("                          RELACION DE TESIS");
            //Console.WriteLine("========================================================================");
            //Console.WriteLine("Id Tesis".PadRight(15) + "Titulo".PadRight(15) + "Autor".PadRight(15) + "Año".PadRight(15) + "Area".PadRight(15) +" Asesor".PadRight(15));
            //Console.WriteLine("------------------------------------------------------------------------");
            RecorrerListado();
            
        }
        // ====================================================== LISTAR TESIS
        public void ListarTesis()
        {
            // ----- Asignar null al delegado 
            deProcesarObjeto = null;
            // ----- Mostrar la lista de libros 
            ListadoTesis();
        }
        public void mostrar()
        {

            ListarTesis();
        }

        
        // ====================================================== LISTAR TESIS DE UN AREA Y ANIO EN ADELANTE 
        public void ListarTesisAreaAnioAdelante()
        {
            // ----- Leer el autor
            Console.WriteLine("");
            Console.Write("Ingrese el Area: ");
            string Area = Console.ReadLine();
            Console.Write("Ingrese el Año: ");
            int Anio = int.Parse(Console.ReadLine());
            Console.Write("======= Tesis del area de {0} desde el año {1} =========", Area, Anio);
            // ----- Asignar método al delegado 
            deProcesarObjeto = delegate (Object O)
            {
                CTesis OTesis = O as CTesis;
                if (OTesis.Area == Area && int.Parse(OTesis.Anio) >= Anio)
                    OTesis.Escribir();
            };
            // ----- Mostrar la lista de libros de este autor
            RecorrerListado();
        }

        // ====================================================== LISTAR TESIS DE ASESOR EN ESPECIFICO
        public void ListaTesisAsesorEspecifico()
        {
            // ----- Leer la fecha
            Console.WriteLine("");
            Console.WriteLine("Ingrese asesor ");
            string asesor = Console.ReadLine();
            bool noHay = true;
            Console.WriteLine("");
            // ----- Asignar método al delegado 
            deProcesarObjeto = delegate (Object O)
            {
                CTesis tesis = O as CTesis;
                if (tesis.Asesor == asesor) {
                    noHay = false;
                    tesis.Escribir();
                }
                
            };
            // ----- Mostrar la lista de libros de este autor
            ListadoTesis();
            if (noHay) Console.WriteLine("Asesor no encontrado");
        }

        // ========================================================
        // -- Metodo listar 3 docentes con mayor numero de tesis aseroradas
        public void Listar3DocentesMayoresTesisAsesoradas()
        {

            CLista Docentes = new CLista();
            CLista Ocurrencias = new CLista();
            deProcesarObjeto = delegate (Object O)
            {
                CTesis OTesis = O as CTesis;
                if (Docentes.Ubicacion(OTesis.Asesor) == 0)
                {
                    Docentes.Agregar(OTesis.Asesor);
                    Ocurrencias.Agregar(1);
                }
                else
                {
                    int I = Docentes.Ubicacion(OTesis.Asesor);
                    int Os = (int)Ocurrencias.Iesimo(I);
                    Ocurrencias.Reemplazar(Os + 1, I);
                }
            };
            RecorrerListado();
            Console.WriteLine("");
            Console.WriteLine("===== 3 Docentes con mayores tesis asesoradas =====");
            int i = 0;
            while (i < 3)
            {
                int mayor = 0;
                for (int j = 1; j < Docentes.Longitud() + 1; j++)
                {
                    int Os = (int)Ocurrencias.Iesimo(j);
                    if (Os > mayor)
                    {
                        mayor = j;
                    }
                }
                Console.WriteLine("Docente: " + Docentes.Iesimo(mayor) + " con " + Ocurrencias.Iesimo(mayor) + " tesis asesoradas");
                Docentes.Eliminar(mayor);
                Ocurrencias.Eliminar(mayor);
                i++;
            }
            Console.WriteLine("");


        }

        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************
    }
}
