using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenerales
{
    public class CObjeto
    {
        #region *********************** ATRIBUTOS ************************
        private string aId;
        #endregion *********************** ATRIBUTOS ************************

        #region *********************** METODOS ************************

        #region ==================== CONSTRUCTORES =======================
        public CObjeto()
        {
            aId = "";
        }
        public CObjeto(string pId)
        {
            aId = pId;
        }
        #endregion ==================== CONSTRUCTORES =======================

        #region ==================== PROPIEDADES =======================
        public string Id
        {
            get { return aId; }
            set { aId = value; }
        }
        #endregion ==================== PROPIEDADES =======================

        #region ====================   OTROS     =======================
        // ================================================================
        public override string ToString()
        {
            return aId;
        }

        // ================================================================
        public override bool Equals(object Objeto)
        {
            return (Objeto.ToString() == ToString());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // ================================================================
        public virtual void Leer()
        {
            Console.Write("Identificador: ");
            aId = Console.ReadLine();
        }

        // ================================================================
        public virtual void Escribir()
        {
            Console.WriteLine(aId);
        }

        // ================================================================
        public virtual void Mostrar()
        {
            Console.WriteLine();
            Console.WriteLine("DATOS DE OBJETO");
            Console.WriteLine("================");
            Console.WriteLine("Identificador: " + aId);
        }
        #endregion ===================    OTROS     =======================

        #endregion *********************** METODOS ************************
    }
}