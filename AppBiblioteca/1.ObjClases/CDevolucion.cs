﻿using ClasesGenerales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AppBiblioteca.ClasesObjLista
{
    public class CDevolucion : CObjeto
    {
        private string aIdDevolucion;
        private string aFechaDevolucion;
        private string aIdPrestamo;
        protected internal static CListaObjetos Devoluciones = new CListaObjetos();

        public CDevolucion(string pIdDevolucion, string pFechaDevolucion, string pIdPrestamo) : base(pIdDevolucion)
        {

            aIdDevolucion = pIdDevolucion;
            aFechaDevolucion = pFechaDevolucion;
            aIdPrestamo = pIdPrestamo;
        }
        public override void Leer()
        {
            base.Leer();
        }
        public override void Mostrar()
        {
            base.Mostrar();
        }

        public override void Escribir()
        {
            base.Escribir();
        }

    }
}