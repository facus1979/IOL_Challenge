using System;


namespace Library.CodingChallenge.Clases
{
    public abstract class FormaGeometrica
    {

        protected string _geoType;
        protected decimal _lado;

        public string GeoType
        {
            get { return _geoType; }
        }

        protected FormaGeometrica(decimal lado)
        {
          
            if (lado<=0)
                throw new ArgumentException(String.Format("El valor del argumento lado debe ser mayor a 0"));

            _lado = lado;
        }

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }
}
