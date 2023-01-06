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
        public CListaTesis ListaLector
        {
            get { return aListaTesis; }
            set { aListaTesis = value; }
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
            Console.WriteLine("1.- Agregar Tesis");
            Console.WriteLine("2.- Eliminar Tesis");
            Console.WriteLine("3.- Listar Tesis");
            Console.WriteLine("4.- Buscar Tesis");
            Console.WriteLine("5.- Salir");
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
                        ListaLector.AgregarTesis();
                        break;
                    case 2:
                        ListaLector.EliminarTesis();
                        break;
                    case 3:
                        ListaLector.ListarTesis();
                        break;
                    case 4:
                        ListaLector.BuscarTesis();
                        break;

                } // -- fin de switch 
            } while (Opcion < 5);
        }
        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************
    }
}
