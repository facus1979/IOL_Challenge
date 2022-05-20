using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Library.CodingChallenge.Clases
{
    class Report
    {
        private Hashtable ht;
        private List<FormaGeometrica> formas;

        public Report(List<FormaGeometrica> f)
        {
            ht = new Hashtable();
            this.formas = f;
        }

        public string BuildAll()
        {

            StringBuilder sb = new StringBuilder("<html><body>");

            if (!formas.Any())
            {
                sb.Append(PrintEmpty());
            }
            else
            {

                sb.Append(PrintHeader());

                sb.Append(PrintLines());

            }

            sb.Append("</body></html>");
            return sb.ToString();
        }

 

        private string PrintEmpty()
        {
            
            return "<h1>" + Library.Translation.Language.empty + "</h1>";
        }

        private string PrintHeader()
        {
            return "<h1>" + Library.Translation.Language.title + "</h1>";
        }

        private void ProcessLines(FormaGeometrica f)
        {
            CountObject c;
            if (ht[f.GeoType] == null)
            {
                c = new CountObject();
            }
            else
            {
                c = (CountObject)ht[f.GeoType];
            }

            c.Prefix = f.GeoType;
            c.Cantidad++;
            c.SumaArea += f.CalcularArea();
            c.SumaPerimetro += f.CalcularPerimetro();
            ht[f.GeoType] = c;
        }

        private string PrintLines()
        {
            foreach (FormaGeometrica f in formas)
            {
                ProcessLines(f);
            }

            int totalFormas = 0;
            decimal totalPerimetros = 0m;
            decimal totalAreas = 0m;
            string lines = "";
            //Se cambio el formato de los numeros de #.## a 0.## para expresar correctamente numeros menores a 1
            //la regionalidad tambien adapta los simbolos decimales y de separacion de miles
            foreach (DictionaryEntry entry in ht)
            {
                CountObject c = (CountObject)ht[entry.Key];
                if (c.Cantidad > 0)
                {
                    totalFormas += c.Cantidad;
                    totalAreas += c.SumaArea;
                    totalPerimetros += c.SumaPerimetro;

                    lines += c.Cantidad + " " + (c.Cantidad == 1 ? Library.Translation.Language.ResourceManager.GetString(c.Prefix + "_name") : Library.Translation.Language.ResourceManager.GetString(c.Prefix + "_name_plural")) + " | " +
                             Library.Translation.Language.area + " " + c.SumaArea.ToString("0.##") + " | " + Library.Translation.Language.perimeter + " " + c.SumaPerimetro.ToString("0.##") + "<br/>";

                }
            }

            lines += "TOTAL:<br/> " + totalFormas + " " + Library.Translation.Language.shapes + " " + Library.Translation.Language.perimeter + " " + totalPerimetros.ToString("0.##") + " " +
                    Library.Translation.Language.area + " " + totalAreas.ToString("0.##");


            return lines;
        }

    }

    struct CountObject
    {
        public string Prefix;
        public int Cantidad;
        public decimal SumaArea;
        public decimal SumaPerimetro;
    }
}
