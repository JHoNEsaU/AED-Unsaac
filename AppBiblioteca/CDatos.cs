using EstDatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppBiblioteca
{
    public class CDatos
    {
        public static void EJECUTARDATOS()
        {
            DatosTesis();
        }
        // ==============================================================================================================================
        public static void DatosLector()
        {
            CControlGeneral.controlLector.ListaLector.Agregar(new CLector());
        }
        // ==============================================================================================================================
        public static void DatosPrestamo()
        {
          
        }
        // ==============================================================================================================================
        public static void DatosTesis()
        {
            
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10001",
                "Análisis comparativo de mecanismos de Comunicación Cross Platform",
                "Juan Gustavo Hurtado Gómez",
                "2019",
                "Sistemas de Información",
                "Ana Rocío Cárdenas Maita"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10002",
                "Análisis de la calidad de los servicios Informáticos",
                "Judith Pablo Gómez",
                "2020",
                "Seguridad Informática",
                "Dennis iván Candia Oviedo"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10003",
                "Análisis de la calidad de los servicios Informáticos",
                "Alexander Contreras de Leon",
                "2020",
                "Ingeniería de Sistemas Informáticos",
                "Doris Sabina Aguirre Carbajal"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10004",
                "Análisis, diseño e implementación de los procesos de venta al personal",
                "Luisa Fernanda Gómez",
                "2020",
                "Ingeniería de Sistemas Informáticos",
                "Edwin Carrasco Poblete"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10005",
                "Aplicación de metodologías internacionales y buenas prácticas para la gestión de proyectos de Desarrollo de software",
                "Maria Estrada Portillo",
                "2020",
                "Gestión de proyectos de software",
                "Doris Sabina Aguirre Carbajal"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10006",
                "Arquitectura para el software de aseguramiento de calidad de los proyectos de software bajo el marco CMMI",
                "Mercedes Huaman de la Cruz",
                "2018",
                "Arquitectura de Software",
                "Efraina Gladys Cutipa Arapa"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10007",
                "Catálogo virtual con realidad aumentada",
                "Ana Graciela Huaman",
                "2018",
                "Soluciones y Proyecto de Tecnología",
                "Emilio Palomino Olivera"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10008",
                "AgroBusiness",
                "Esther Terrones Vasquez",
                "2017",
                "Gestión de Proyectos",
                "Enrique Gamarra Saldivar"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10009",
                "Diseño de la arquitectura de negocios y aplicaciones, y generación de requerimientos de TI para los productos de gestión interna de las fábricas de software",
                "Lucero Huaman Huaman",
                "2020",
                "Administración de redes, comunicaciones, hardware y software",
                "Harley Vera Olivera"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10010",
                "Diseño de una arquitectura orientada a servicios para un establecimiento de salud de nivel de complejidad I-3",
                "Luisa Fernanda Gómez",
                "2020",
                "Ingeniería de Sistemas Informáticos",
                "Henry Samuel Dueñas de la Cruz"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10011",
                "Desarrollo de videojuego con augmented reality",
                "Luisa Fernanda Gómez",
                "2010",
                "Ingeniería de Software",
                "Hernán Castañeda Chirinos"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10012",
                "Ensemble interactions sobre Cross-Platform",
                "Claudio Bustamante Toribio",
                "2010",
                "Ingeniería de Sistemas de la Información",
                "Karelia Medina Miranda"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10013",
                "Evaluación de la seguridad de los servicios informáticos",
                "Luis Alberto Gómez",
                "2020",
                "Seguridad Informática",
                "Lauro Enciso Rodas"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10014",
                "Mejoramiento de procesos de Datawarehouse",
                "Antonio Rivero Quispe",
                "2020",
                "Ingeniería de Sistemas de Información",
                "Nila Zonia Acurio Usca"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10015",
                "Modelo de gestión de proyectos de desarrollo de software",
                "Luis Alberto Gómez",
                "2020",
                "Gestión de proyectos de software",
                "Luis Beltrán Palma Ttito"));
            CControlGeneral.controlTesis.ListaTesis.Agregar(new CTesis(
                "T10016",
                "Propuesta planeamiento estratégico de tecnología y de sistemas de información QA SOFT",
                "Maycol Andrade Rodas",
                "2017",
                "Gestión de proyectos de software",
                "Nila Zonia Acurio Usca"));
            


        }
        // ==============================================================================================================================
        public void DatosDevolucion()
        {

            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10001", "01/05/2020", "P10001"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10002", "01/05/2020", "P10002"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10003", "01/05/2020", "P10003"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10004", "01/05/2020", "P10004"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10005", "01/05/2020", "P10005"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10006", "01/05/2020", "P10006"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10007", "01/05/2020", "P10007"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10008", "01/05/2020", "P10008"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10009", "01/05/2020", "P10009"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10010", "01/05/2020", "P10010"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10011", "01/05/2020", "P10011"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10012", "01/05/2020", "P10012"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10013", "01/05/2020", "P10013"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10014", "01/05/2020", "P10014"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10015", "01/05/2020", "P10015"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10016", "01/05/2020", "P10016"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10017", "01/05/2020", "P10017"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10018", "01/05/2020", "P10018"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10019", "01/05/2020", "P10019"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10020", "01/05/2020", "P10020"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10021", "01/05/2020", "P10021"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10022", "01/05/2020", "P10022"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10023", "01/05/2020", "P10023"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10024", "01/05/2020", "P10024"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10025", "01/05/2020", "P10025"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10026", "01/05/2020", "P10026"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10027", "01/05/2020", "P10027"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10028", "01/05/2020", "P10028"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10029", "01/05/2020", "P10029"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10030", "01/05/2020", "P10030"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10031", "01/05/2020", "P10031"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10032", "01/05/2020", "P10032"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10033", "01/05/2020", "P10033"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10034", "01/05/2020", "P10034"));
            CControlGeneral.controlDevolucion.ListaDevolucion.Agregar(new CDevolucion("D10035", "01/05/2020", "P10035"));

        }
    }

}
