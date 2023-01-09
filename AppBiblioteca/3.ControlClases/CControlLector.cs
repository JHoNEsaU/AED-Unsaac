using System;
using System.Collections.Generic;
using System.Text;
using ClasesGenerales;

namespace AppBiblioteca
{
    public class CControlLector
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

        // ====================================================== SUB MENU DE CONTROL LECTOR 
        public void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("**************************************");
            Console.WriteLine("*       CONTROL DE LECTOR            *");
            Console.WriteLine("**************************************");
            Console.WriteLine("1.- Agergar Lector");
            Console.WriteLine("2.- Eliminar Lector");
            Console.WriteLine("3.- Listar Lectores");
            Console.WriteLine("4.- Buscar Lector");
            Console.WriteLine("5.- Salir");
        }

        // ====================================================== INICIAR SUB MENU
        public void Ejecutar()
        {
            // ----- Procesar opciones y Menu
            int Opcion;
            do
            {
          
                Menu();
                // ----- Leer Opcion 
                Console.Write("Ingresa Opcion: ");
                Opcion = CControlGeneral.leerOpcion();
                Console.WriteLine("");
                Console.Clear();
                switch (Opcion)
                {
                    case 1:
                        ListaLector.AgregarLector();
                        break;
                    case 2:
                        ListaLector.EliminarLector();
                        break;
                    case 3:
                        ListaLector.ListarLector();
                        break;
                    case 4:
                        ListaLector.BuscarLector();
                        break;
                    
                } // -- fin de switch 
            } while (Opcion < 5);
        }
        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************
    }
}
