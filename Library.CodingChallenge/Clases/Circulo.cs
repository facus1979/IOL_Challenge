using System;

namespace Library.CodingChallenge.Clases
{
    public class Circulo : FormaGeometrica
    {
        public Circulo(decimal lado) : base(lado)
        {
            _geoType = "circle";
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }
    }
}
