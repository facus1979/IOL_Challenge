using System;
using System.Globalization;
using System.Threading;

namespace Library.CodingChallenge.Clases
{
    /*
    Clase utilizada para cambiar la regionalidad en el reporte segun la Enum Idioma, 
    y luego volver a la configuracion original.
    (Lo que pasa en las Vegas, se queda en las Vegas)
    */
    public class CultureInfoScope : IDisposable
    {
        private readonly CultureInfo originalCulture;

        public CultureInfoScope(CultureInfo culture)
        {
            this.originalCulture = CultureInfo.CurrentCulture;

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        public void Dispose()
        {
            Thread.CurrentThread.CurrentCulture = this.originalCulture;
            Thread.CurrentThread.CurrentUICulture = this.originalCulture;
        }
    }
}
