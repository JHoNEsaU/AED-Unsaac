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

            DatosLector();
            DatosTesis();
            DatosPrestamo();
            DatosDevolucion();

        }
        // ==============================================================================================================================
        public static void DatosLector()
        {
            CControlGeneral.controlLector.ListaLector.Agregar(new CLector("210940", "Jhon Esau ", " Pumachoque Choquenaira", "Tinta", "M", "24"));
            CControlGeneral.controlLector.ListaLector.Agregar(new CLector("210941", "David ", "Huacho Cruz", "Apv Campiña alta", "M", "20"));
            CControlGeneral.controlLector.ListaLector.Agregar(new CLector("210233", "Andric Jeremy ", "Bueno Lescano", "Jose olaya", "M", "23"));
            CControlGeneral.controlLector.ListaLector.Agregar(new CLector("210112", "Joseph Timothy", " Calderon Garcia", "C. Angamos", "M", "16"));
            CControlGeneral.controlLector.ListaLector.Agregar(new CLector("210631", "Flor de Liz", " Ccasa Ccahuana", "Intiraymi", "F", "20"));
            CControlGeneral.controlLector.ListaLector.Agregar(new CLector("210665", "Brandon Ccoyo ", "Mejia", "C. Union", "M", "21"));
            CControlGeneral.controlLector.ListaLector.Agregar(new CLector("210923", "Emerson Cordova ", "Ccopa", "AV. Garcilaso", "M", "19"));
            CControlGeneral.controlLector.ListaLector.Agregar(new CLector("210220", "Ibeth Janela", "Felipe Sicus", "AV las mercedes", "F", "18"));
        }
        // ==============================================================================================================================
        public static void DatosPrestamo()
        {
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10035", "12/2/2020", "1/4/2020", "210940", "T10001"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10037", "21/4/2021", "1/5/2021", "210112", "T10002"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10038", "3/6/2021", "2/7/2021", "210941", "T10002"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10039", "5/8/2022", "3/9/2022", "210631", "T10016"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10040", "11/5/2021", "4/8/2021", "210220", "T10012"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10041", "12/3/2022", "5/12/2022", "210220", "T10004"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10042", "23/8/2021", "6/9/2021", "210631", "T10002"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10043", "14/12/2022", "21/12/2022", "210665", "T10014"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10044", "12/3/2020", "3/4/2020", "210112", "T10009"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10045", "12/6/2021", "4/7/2021", "210631", "T10016"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10046", "12/9/2020", "12/11/2020", "210233", "T10007"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10047", "12/7/2020", "21/8/2020", "210940", "T10002"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10048", "12/4/2020", "13/4/2020", "210220", "T10015"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10049", "12/9/2020", "19/10/2020", "210941", "T10004"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10050", "12/7/2022", "25/11/2022", "210923", "T10014"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10051", "12/5/2021", "26/7/2021", "210112", "T10003"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10052", "12/1/2020", "30/4/2020", "210233", "T10011"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10053", "12/4/2021", "21/8/2021", "210940", "T10012"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10054", "12/5/2022", "23/9/2022", "210941", "T10013"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10055", "12/7/2020", "12/10/2020", "210220", "T10002"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10056", "12/8/2021", "19/11/2021", "210112", "T10009"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10057", "12/9/2022", "32/12/2022", "210665", "T10015"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10058", "12/4/2020", "12/9/2020", "210941", "T10005"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10059", "12/3/2022", "31/5/2022", "210923", "T10008"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10060", "12/3/2020", "11/8/2020", "210941", "T10002"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10061", "12/5/2021", "2/7/2021", "210112", "T10006"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10062", "12/7/2020", "4/8/2020", "210233", "T10007"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10063", "12/8/2022", "9/12/2022", "210940", "T10012"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10064", "12/5/2020", "19/7/2020", "210923", "T10005"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10065", "12/3/2021", "12/4/2021", "210941", "T10010"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10066", "12/11/2022", "14/8/2022", "210631", "T10002"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10067", "12/12/2022", "30/12/2022", "210220", "T10013"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10068", "12/10/2022", "13/12/2022", "210631", "T10008"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10069", "12/10/2021", "23/11/2021", "210941", "T10005"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10070", "12/1/2021", "21/4/2021", "210233", "T10015"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10071", "12/3/2022", "15/7/2022", "210923", "T10008"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10072", "12/6/2021", "18/9/2021", "210112", "T10002"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10073", "12/5/2021", "13/6/2021", "210220", "T10013"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10074", "12/4/2022", "12/9/2022", "210233", "T10006"));
            CControlGeneral.controlPrestamo.ListaPrestamo.Agregar(new CPrestamo("P10075", "12/3/2020", "14/7/2020", "210112", "T10016"));
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
        public static void DatosDevolucion()
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
