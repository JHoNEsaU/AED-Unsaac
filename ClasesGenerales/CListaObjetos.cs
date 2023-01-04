using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibTADS;

namespace ClasesGenerales
{
    public delegate void DelegadoProcesarObjeto(object O);
    public delegate bool DelegadoSeleccionarObjeto(object O);
    public class CListaObjetos : CLista
    {
        #region *********************** ATRIBUTOS ************************
        private CLista aListado;
        // ----- Delegado para procesar los objetos de la lista
        public DelegadoProcesarObjeto deProcesarObjeto = null;
        // ----- Delegado para seleccionar los objetos de la lista
        public DelegadoSeleccionarObjeto deSeleccionarObjeto = null;

        #endregion *********************** ATRIBUTOS ************************

        #region *********************** METODOS ************************

        #region ==================== CONSTRUCTORES =======================
        public CListaObjetos()
        {
            aListado = new CLista();
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ==================== PROPIEDADES =======================
        public CLista Listado
        {
            get { return aListado; }
            set { aListado = value; }
        }
        #endregion ==================== PROPIEDADES =======================

        #region ====================   OTROS     =======================
        // ==============================================================
        public void Agregar(CObjeto Objeto)
        {
            // ----- Verificar que objeto no exista en la lista
            if (Indice(Objeto) < 0)
                Listado.Agregar(Objeto);
            else
                // ----- Objeto ya existe en el listado, por tanto poner mensaje de error 
                Console.WriteLine(Objeto.Id + " ya existe en la lista, por tanto, no será agregado...");
        }

        // ==============================================================
        public int Indice(Object Objeto)
        {
            return Listado.Ubicacion(Objeto);
        }

        // ==============================================================
        public void Consultar(object pId)
        {
            // ----- Determinar Indice o ubicacion del Identificador
            int I = Indice(pId);
            if (I >= 0)
            {
                CObjeto Objeto = (Listado.Iesimo(I) as CObjeto);
                Objeto.Mostrar();
            }
            else
                // ----- Objeto no existe en el listado, por tanto poner mensaje de error 
                Console.WriteLine(pId + " No existe en la lista...");
        }

        // ==============================================================
        public virtual void ProcesarObjeto(Object O)
        {
            CObjeto Objeto = O as CObjeto;
            Objeto.Escribir();
        }

        // ==============================================================
        public ArrayList GenerarSubLista()
        {
            // ----- Generar lista vacia
            ArrayList Aux = new ArrayList();
            // ----- Recorrer la lista y seleccionar objetos para la sublista
            for (int K = 0; K < Listado.Longitud(); K++)
                // ----- Procesar K-ésimo Objeto
                if ((deSeleccionarObjeto == null) || (deSeleccionarObjeto(Listado.Ubicacion(K))))
                    Aux.Add(Listado.Ubicacion(K));
            // ----- Retornar sub lista
            return Aux;
        }

        // ==============================================================
        public void RecorrerListado()
        {
            // ----- Recorrer listado para procesar cada objeto de la lista
            for (int K = 0; K < Listado.Longitud(); K++)
                // ----- Procesar K-ésimo Objeto
                if (deProcesarObjeto != null)
                    deProcesarObjeto(Listado.Ubicacion(K));
                else
                    ProcesarObjeto(Listado.Ubicacion(K));
        }

        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************

    }
}