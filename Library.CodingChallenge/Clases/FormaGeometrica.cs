using System;

namespace Library.CodingChallenge.Clases
{

    /*
    Clase Abstracta que define la estructura de una forma geometrica con sus 
    metodos para calcular area y perimetro, asi como tambien el parametro GeoType, el cual 
    sera utilizado para regionalizacion y helper para la construccion 
    del reporte.
    */
    public abstract class FormaGeometrica
    {

        protected string _geoType;
        protected decimal _lado;
        /*
        Propiedad para discriminar el nombre del tipo de figura para
        cambiar el idioma y realizar los calculos de sumarizacion en el reporte.
        */
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
