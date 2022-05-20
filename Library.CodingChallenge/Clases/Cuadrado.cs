using System;


namespace Library.CodingChallenge.Clases
{
    public class Cuadrado : FormaGeometrica
    {
        public Cuadrado(decimal lado) : base(lado)
        {
            _geoType = "square";
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
