using System;

namespace Library.CodingChallenge.Clases
{
    public class Circulo : FormaGeometrica
    {
        /*
        Clase Concreta Circulo, la cual hereda de FormaGeometrica y 
        redefine los metodos para calculo de Area y Perimetro.
        Ademas de asignarle valor a la variable _geoType en su construccion.
        */
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
