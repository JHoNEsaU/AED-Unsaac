using System;
using System.Collections.Generic;
using System.Text;

namespace AppBiblioteca
{
    public class CControlTesis
    {
        #region *********************** ATRIBUTOS ************************
        private CListaTesis aListaTesis;
        #endregion *********************** ATRIBUTOS ************************

        #region *********************** METODOS ************************

        #region ==================== CONSTRUCTORES =======================
        public CControlTesis()
        {
            aListaTesis = new CListaTesis();
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ==================== PROPIEDADES =======================
        public CListaTesis ListaTesis
        {
            get { return aListaTesis; }
            set { aListaTesis = value; }
        }
        #endregion ==================== PROPIEDADES =======================

        #region ====================   OTROS     =======================

        // ====================================================== SUB MENU DE CONTROL TESIS
        public void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("************************************************************");
            Console.WriteLine("*                        CONTROL DE TESIS                  *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("1.- Agregar Tesis");
            Console.WriteLine("2.- Eliminar Tesis");
            Console.WriteLine("3.- Listar Tesis");
            Console.WriteLine("4.- Buscar Tesis");
            Console.WriteLine("5.- Listar tesis de un area y anio en especifico");
            Console.WriteLine("6.- Listar Tesis de asesor en especifico");
            Console.WriteLine("7.- Listar 3 docentes con mayor numero de tesis aseroradas");
            Console.WriteLine("8.- Salir");
        }

        // ====================================================== INICIAR SUB MENU
        public void Ejecutar()
        {
            // ----- Procesar opciones y Menu
            int Opcion;
            do
            {
                Console.Clear();
                Menu();
                // ----- Leer Opcion 
                Console.Write("Ingresa Opcion: ");
                Opcion = CControlGeneral.leerOpcion();
                Console.WriteLine("");
                switch (Opcion)
                {
                    case 1:
                        ListaTesis.AgregarTesis();
                        break;
                    case 2:
                        ListaTesis.EliminarTesis();
                        break;
                    case 3:
                        ListaTesis.ListarTesis();
                        break;
                    case 4:
                        ListaTesis.BuscarTesis();
                        break;
                    case 5:
                        ListaTesis.ListarTesisAreaAnioAdelante();
                        break;
                    case 6:
                        ListaTesis.ListaTesisAsesorEspecifico();
                        break;
                    case 7:
                        ListaTesis.Listar3DocentesMayoresTesisAsesoradas();
                        break;

                } // -- fin de switch 
            } while (Opcion < 8);
        }
        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************
    }
}
