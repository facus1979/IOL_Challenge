using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Library.CodingChallenge.Clases;

namespace Library.CodingChallenge
{
    /*
    Clase Report Manager. 
    La misma permite mediante el metodo Print, generar el nuevo reporte 
    en funcion de la lista de FigurasGeometricas y el tipo de Idioma.
    El idioma esta normalizado mediante el uso de una Enum.,
    utiliza un diccionario de resources para resolver las traducciones, 
    el cual se encuentra en un proyecto referenciado aparte.
    Se utiliza una clase auxiliar (CultureInfoScope) para mantener el scope del cambio de idioma.
    */
    public class ReportManager
    {
        private  Report _report;
        public string Print(List<FormaGeometrica> formas, Idiomas idioma)
        {
            using (CultureInfoScope ci = new CultureInfoScope((idioma == Idiomas.Castellano ? new CultureInfo("ES-AR") : new CultureInfo("EN-US"))))
            {
                Report _report = new Report(formas);
                return _report.BuildAll();
            }
        }
        public enum Idiomas { Castellano = 1, Ingles = 2 };

    }
}
