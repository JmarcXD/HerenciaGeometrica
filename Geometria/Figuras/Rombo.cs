namespace Geometria.Poligonos
{
    public class Rombo : Poligono
    {
        private double ejeMayor;
        private double ejeMenor;

        public Rombo(string nombre, double ejeMayor, double ejeMenor, double longitudBase) : base(nombre, 4, longitudBase)
        {
            this.ejeMayor = ejeMayor;
            this.ejeMenor = ejeMenor;
        }
        public override double Perimetro()
        {
            return LongitudBase + LongitudBase + LongitudBase + LongitudBase;
        }

        public override double Area()
        {
            return (this.ejeMenor * this.ejeMayor) / 2;
        }

        public override string ToString()
        {
            return $"Eje Mayor {ejeMayor} Eje Menor {ejeMenor}";
        }
    }
}
