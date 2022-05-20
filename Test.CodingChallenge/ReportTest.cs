using Library.CodingChallenge;
using Library.CodingChallenge.Clases;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Test.CodingChallenge
{
    [TestFixture]
    public class ReportTest
    {
        [TestCase]
        public void TestResumenListaVaciaCastellano()
        {
            ReportManager rm = new ReportManager();            
            Assert.AreEqual("<html><body><h1>Lista vacía de formas!</h1></body></html>", rm.Print(new List<FormaGeometrica>(), ReportManager.Idiomas.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasIngles()
        {
            ReportManager rm = new ReportManager();
            Assert.AreEqual("<html><body><h1>Empty list of shapes!</h1></body></html>", rm.Print(new List<FormaGeometrica>(), ReportManager.Idiomas.Ingles));
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoCastellano()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new Cuadrado(1) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Castellano);

            Assert.AreEqual("<html><body><h1>Reporte de Formas</h1>1 Cuadrado | Area 1 | Perimetro 4<br/>TOTAL:<br/> 1 formas Perimetro 4 Area 1</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoIngles()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new Cuadrado(1) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Ingles);

            Assert.AreEqual("<html><body><h1>Shapes report</h1>1 Square | Area 1 | Perimeter 4<br/>TOTAL:<br/> 1 shapes Perimeter 4 Area 1</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCirculoCastellano()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new Circulo(1) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Castellano);

            Assert.AreEqual("<html><body><h1>Reporte de Formas</h1>1 Círculo | Area 0,79 | Perimetro 3,14<br/>TOTAL:<br/> 1 formas Perimetro 3,14 Area 0,79</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCirculoIngles()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new Circulo(1) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Ingles);

            Assert.AreEqual("<html><body><h1>Shapes report</h1>1 Circle | Area 0.79 | Perimeter 3.14<br/>TOTAL:<br/> 1 shapes Perimeter 3.14 Area 0.79</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrianguloEquilateroCastellano()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new TrianguloEquilatero(1) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Castellano);

            Assert.AreEqual("<html><body><h1>Reporte de Formas</h1>1 Triángulo | Area 0,43 | Perimetro 3<br/>TOTAL:<br/> 1 formas Perimetro 3 Area 0,43</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrianguloEquilateroIngles()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new TrianguloEquilatero(1) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Ingles);

            Assert.AreEqual("<html><body><h1>Shapes report</h1>1 Triangle | Area 0.43 | Perimeter 3<br/>TOTAL:<br/> 1 shapes Perimeter 3 Area 0.43</body></html>", resumen);
        }
    }
}
