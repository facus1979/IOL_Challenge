using System;


namespace Library.CodingChallenge.Clases
{
    public class Cuadrado : FormaGeometrica
    {
        /*
        Clase Concreta Cuadrado, la cual hereda de FormaGeometrica y
        redefine los metodos para calculo de Area y Perimetro.
        Ademas de asignarle valor a la variable _geoType en su construccion.
        */
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
