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
        public void TestResumenListaCon1CuadradoCastellano()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new Cuadrado(1) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Castellano);

            Assert.AreEqual("<html><body><h1>Reporte de Formas</h1>1 Cuadrado | Area 1 | Perimetro 4<br/>TOTAL:<br/> 1 forma Perimetro 4 Area 1</body></html>", resumen);
        }

        public void TestResumenListaCon2CuadradosCastellano()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new Cuadrado(1) , new Cuadrado(2) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Castellano);

            Assert.AreEqual("<html><body><h1>Reporte de Formas</h1>2 Cuadrados | Area 5 | Perimetro 12<br/>TOTAL:<br/> 2 formas Perimetro 12 Area 5</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaCon1CuadradoIngles()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new Cuadrado(1) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Ingles);

            Assert.AreEqual("<html><body><h1>Shapes report</h1>1 Square | Area 1 | Perimeter 4<br/>TOTAL:<br/> 1 shape Perimeter 4 Area 1</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaCon2CuadradosIngles()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new Cuadrado(1), new Cuadrado(2) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Ingles);

            Assert.AreEqual("<html><body><h1>Shapes report</h1>2 Squares | Area 5 | Perimeter 12<br/>TOTAL:<br/> 2 shapes Perimeter 12 Area 5</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaCon1CirculoCastellano()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new Circulo(1) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Castellano);

            Assert.AreEqual("<html><body><h1>Reporte de Formas</h1>1 Círculo | Area 0,79 | Perimetro 3,14<br/>TOTAL:<br/> 1 forma Perimetro 3,14 Area 0,79</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaCon2CirculosCastellano()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new Circulo(1), new Circulo(2) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Castellano);

            Assert.AreEqual("<html><body><h1>Reporte de Formas</h1>2 Círculos | Area 3,93 | Perimetro 9,42<br/>TOTAL:<br/> 2 formas Perimetro 9,42 Area 3,93</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaCon1CirculoIngles()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new Circulo(1) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Ingles);

            Assert.AreEqual("<html><body><h1>Shapes report</h1>1 Circle | Area 0.79 | Perimeter 3.14<br/>TOTAL:<br/> 1 shape Perimeter 3.14 Area 0.79</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaCon2CirculoIngles()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new Circulo(1), new Circulo(2) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Ingles);

            Assert.AreEqual("<html><body><h1>Shapes report</h1>2 Circles | Area 3.93 | Perimeter 9.42<br/>TOTAL:<br/> 2 shapes Perimeter 9.42 Area 3.93</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaCon1TrianguloEquilateroCastellano()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new TrianguloEquilatero(1) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Castellano);

            Assert.AreEqual("<html><body><h1>Reporte de Formas</h1>1 Triángulo | Area 0,43 | Perimetro 3<br/>TOTAL:<br/> 1 forma Perimetro 3 Area 0,43</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaCon2TrianguloEquilateroCastellano()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new TrianguloEquilatero(1), new TrianguloEquilatero(2) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Castellano);

            Assert.AreEqual("<html><body><h1>Reporte de Formas</h1>2 Triángulos | Area 2,17 | Perimetro 9<br/>TOTAL:<br/> 2 formas Perimetro 9 Area 2,17</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaCon1TrianguloEquilateroIngles()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new TrianguloEquilatero(1) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Ingles);

            Assert.AreEqual("<html><body><h1>Shapes report</h1>1 Triangle | Area 0.43 | Perimeter 3<br/>TOTAL:<br/> 1 shape Perimeter 3 Area 0.43</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaCon2TrianguloEquilateroIngles()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> { new TrianguloEquilatero(1), new TrianguloEquilatero(2) };
            var resumen = rm.Print(l, ReportManager.Idiomas.Ingles);

            Assert.AreEqual("<html><body><h1>Shapes report</h1>2 Triangles | Area 2.17 | Perimeter 9<br/>TOTAL:<br/> 2 shapes Perimeter 9 Area 2.17</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaConMultiplesFigurasCastellano()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> {
                new Cuadrado(1),                
                new Circulo(2),
                new Cuadrado(5.4m),
                new TrianguloEquilatero(3),
                new Circulo(12.8m),
                new TrianguloEquilatero(7.7m)
            };
            
            var resumen = rm.Print(l, ReportManager.Idiomas.Castellano);

            Assert.AreEqual("<html><body><h1>Reporte de Formas</h1>2 Cuadrados | Area 30,16 | Perimetro 25,6<br/>2 Círculos | Area 131,82 | Perimetro 46,5<br/>2 Triángulos | Area 29,57 | Perimetro 32,1<br/>TOTAL:<br/> 6 formas Perimetro 104,2 Area 191,55</body></html>", resumen);
        }

        [TestCase]
        public void TestResumenListaConMultiplesFigurasIngles()
        {
            ReportManager rm = new ReportManager();
            var l = new List<FormaGeometrica> {
                new Cuadrado(1),
                new Circulo(2),
                new Cuadrado(5.4m),
                new TrianguloEquilatero(3),
                new Circulo(12.8m),
                new TrianguloEquilatero(7.7m)
            };
            var resumen = rm.Print(l, ReportManager.Idiomas.Ingles);

            Assert.AreEqual("<html><body><h1>Shapes report</h1>2 Squares | Area 30.16 | Perimeter 25.6<br/>2 Circles | Area 131.82 | Perimeter 46.5<br/>2 Triangles | Area 29.57 | Perimeter 32.1<br/>TOTAL:<br/> 6 shapes Perimeter 104.2 Area 191.55</body></html>", resumen);
        }
    }
}
