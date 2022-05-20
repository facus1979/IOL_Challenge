using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Library.CodingChallenge.Clases;

namespace Library.CodingChallenge
{
    public class ReportManager
    {
        private  Report _report;
        public string Print(List<FormaGeometrica> formas, Idiomas idioma)
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = idioma == Idiomas.Castellano ? new CultureInfo("ES-AR") : new CultureInfo("EN-US");

            _report = new Report(formas);

            return _report.BuildAll();
        }
        public enum Idiomas { Castellano = 1, Ingles = 2 };

    }
}
