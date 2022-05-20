using Library.CodingChallenge.Clases;
using NUnit.Framework;
using System;


namespace Test.CodingChallenge
{
    [TestFixture]
    public class LibraryTest
    {
        [TestCase]
        public void TestCuadradoGeoType()
        {
            Cuadrado f = new Cuadrado(1);       
            Assert.AreEqual("square", f.GeoType);
        }

        [TestCase]
        public void TestCirculoGeoType()
        {
            Circulo f = new Circulo(1);
            Assert.AreEqual("circle", f.GeoType);
        }

        [TestCase]
        public void TestTrianguloGeoType()
        {
            TrianguloEquilatero f = new TrianguloEquilatero(1);
            Assert.AreEqual("triangle", f.GeoType);
        }


        [TestCase]
        public void TestCuadradoPerimetro()
        {
            Cuadrado f = new Cuadrado(2);
            Assert.AreEqual(8, f.CalcularPerimetro());
        }


        [TestCase]
        public void TestCuadradoArea()
        {
            Cuadrado f = new Cuadrado(2);
            Assert.AreEqual(4, f.CalcularArea());
        }

        [TestCase]
        public void TestCirculoPerimetro()
        {
            Circulo f = new Circulo(2);
            Assert.AreEqual("6.28", f.CalcularPerimetro().ToString("0.##"));
        }

        [TestCase]
        public void TestCirculoArea()
        {
            Circulo f = new Circulo(2);
            Assert.AreEqual("3.14", f.CalcularArea().ToString("0.##"));
        }

        [TestCase]
        public void TestTrianguloEquilateroPerimetro()
        {
            TrianguloEquilatero f = new TrianguloEquilatero(2);
            Assert.AreEqual(6, f.CalcularPerimetro());
        }

        [TestCase]
        public void TestTrianguloEquilateroArea()
        {
            TrianguloEquilatero f = new TrianguloEquilatero(2);
            Assert.AreEqual("1.73", f.CalcularArea().ToString("0.##"));
        }

        [TestCase]
        public void TestCuadradoLado0()
        {
            Assert.Throws<ArgumentException>(() => new Cuadrado(0));
        }

        public void TestCirculoLado0()
        {
            Assert.Throws<ArgumentException>(() => new Circulo(0));
        }
        public void TestTrianguloEquilateroLado0()
        {
            Assert.Throws<ArgumentException>(() => new TrianguloEquilatero(0));
        }
    }
}
