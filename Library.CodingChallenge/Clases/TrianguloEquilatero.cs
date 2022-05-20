using System;


namespace Library.CodingChallenge.Clases
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        /*
        Clase Concreta TrianguloEquilatero, la cual hereda de FormaGeometrica y
        redefine los metodos para calculo de Area y Perimetro.
        Ademas de asignarle valor a la variable _geoType en su construccion.
        */
        public TrianguloEquilatero(decimal lado) : base(lado)
        {
            _geoType = "triangle"; 
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
    }
}
