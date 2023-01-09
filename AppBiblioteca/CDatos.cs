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
            
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10001",
                "Análisis comparativo de mecanismos de Comunicación Cross Platform",
                "Juan Gustavo Hurtado Gómez",
                "2019",
                "Sistemas de Información",
                "Ana Rocío Cárdenas Maita"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10002",
                "Análisis de la calidad de los servicios Informáticos",
                "Judith Pablo Gómez",
                "2020",
                "Seguridad Informática",
                "Dennis iván Candia Oviedo"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10003",
                "Análisis de la calidad de los servicios Informáticos",
                "Alexander Contreras de Leon",
                "2020",
                "Ingeniería de Sistemas Informáticos",
                "Doris Sabina Aguirre Carbajal"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10004",
                "Análisis, diseño e implementación de los procesos de venta al personal",
                "Luisa Fernanda Gómez",
                "2020",
                "Ingeniería de Sistemas Informáticos",
                "Edwin Carrasco Poblete"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10005",
                "Aplicación de metodologías internacionales y buenas prácticas para la gestión de proyectos de Desarrollo de software",
                "Maria Estrada Portillo",
                "2020",
                "Gestión de proyectos de software",
                "Doris Sabina Aguirre Carbajal"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10006",
                "Arquitectura para el software de aseguramiento de calidad de los proyectos de software bajo el marco CMMI",
                "Mercedes Huaman de la Cruz",
                "2018",
                "Arquitectura de Software",
                "Efraina Gladys Cutipa Arapa"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10007",
                "Catálogo virtual con realidad aumentada",
                "Ana Graciela Huaman",
                "2018",
                "Soluciones y Proyecto de Tecnología",
                "Emilio Palomino Olivera"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10008",
                "AgroBusiness",
                "Esther Terrones Vasquez",
                "2017",
                "Gestión de Proyectos",
                "Enrique Gamarra Saldivar"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10009",
                "Diseño de la arquitectura de negocios y aplicaciones, y generación de requerimientos de TI para los productos de gestión interna de las fábricas de software",
                "Lucero Huaman Huaman",
                "2020",
                "Administración de redes, comunicaciones, hardware y software",
                "Harley Vera Olivera"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10010",
                "Diseño de una arquitectura orientada a servicios para un establecimiento de salud de nivel de complejidad I-3",
                "Luisa Fernanda Gómez",
                "2020",
                "Ingeniería de Sistemas Informáticos",
                "Henry Samuel Dueñas de la Cruz"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10011",
                "Desarrollo de videojuego con augmented reality",
                "Luisa Fernanda Gómez",
                "2010",
                "Ingeniería de Software",
                "Hernán Castañeda Chirinos"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10012",
                "Ensemble interactions sobre Cross-Platform",
                "Claudio Bustamante Toribio",
                "2010",
                "Ingeniería de Sistemas de la Información",
                "Karelia Medina Miranda"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10013",
                "Evaluación de la seguridad de los servicios informáticos",
                "Luis Alberto Gómez",
                "2020",
                "Seguridad Informática",
                "Lauro Enciso Rodas"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10014",
                "Mejoramiento de procesos de Datawarehouse",
                "Antonio Rivero Quispe",
                "2020",
                "Ingeniería de Sistemas de Información",
                "Nila Zonia Acurio Usca"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
                "T10015",
                "Modelo de gestión de proyectos de desarrollo de software",
                "Luis Alberto Gómez",
                "2020",
                "Gestión de proyectos de software",
                "Luis Beltrán Palma Ttito"));
            CControlGeneral.controlTesis.ListaLector.Agregar(new CTesis(
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
            
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10001", "2020/05/01", "P10001"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10002", "2020/05/02", "P10002"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10003", "2020/05/03", "P10003"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10004", "2020/05/04", "P10004"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10005", "2020/05/05", "P10005"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10006", "2020/05/06", "P10006"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10007", "2020/05/07", "P10007"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10008", "2020/05/08", "P10008"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10009", "2020/05/09", "P10009"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10010", "2020/05/10", "P10010"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10011", "2020/05/11", "P10011"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10012", "2020/05/12", "P10012"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10013", "2020/05/13", "P10013"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10014", "2020/05/14", "P10014"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10015", "2020/05/15", "P10015"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10016", "2020/05/16", "P10016"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10017", "2020/05/17", "P10017"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10018", "2020/05/18", "P10018"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10019", "2020/05/19", "P10019"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10020", "2020/05/20", "P10020"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10021", "2020/05/21", "P10021"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10022", "2020/05/22", "P10022"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10023", "2020/05/23", "P10023"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10024", "2020/05/24", "P10024"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10025", "2020/05/25", "P10025"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10026", "2020/05/26", "P10026"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10027", "2020/05/27", "P10027"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10028", "2020/05/28", "P10028"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10029", "2020/05/29", "P10029"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10030", "2020/05/30", "P10030"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10031", "2020/05/31", "P10031"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10032", "2020/05/32", "P10032"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10033", "2020/05/33", "P10033"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10034", "2020/05/34", "P10034"));
            CControlGeneral.controlDevolucion.ListaLector.Agregar(new CDevolucion("D10035", "2020/05/35", "P10035"));

        }
    }

}
