using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    public class Diagrama
    {
        private List<Figura> listaFiguras = new List<Figura>();

        public Diagrama(List<Figura> listaFiguras) 
        { 
            this.listaFiguras = listaFiguras;
        }

        public List<Figura> ListaFiguras { get {  return listaFiguras; } set {  listaFiguras = value; } }

        public double PerimetroTotal()
        {
            double total = 0;

            foreach (var figura in listaFiguras)
            {
                total += figura.Perimetro();
            }

            return total;
        }

        public double AreaTotal()
        {
            double total = 0;

            foreach (var figura in listaFiguras)
            {
                total += figura.Area();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();

            foreach (var figura in listaFiguras)
            {
                text.AppendLine(figura.ToString());
            }

            return text.ToString();
        }
    }
}
