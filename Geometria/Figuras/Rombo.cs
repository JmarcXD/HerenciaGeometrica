using System;

namespace Geometria.Poligonos
{
    public class Rombo : Poligono
    {
        private double ejeMayor;
        private double ejeMenor;
        public double EjeMayor { get { return ejeMayor; } set { ejeMayor = value; } }
        public double EjeMenor { get { return ejeMenor; } set {  EjeMayor = value; } }  

        public Rombo(double ejeMayor, double ejeMenor) : base("Rombo", 4, Math.Sqrt((2*(ejeMayor/2)) + (2*(ejeMayor/2))))
        {
            this.ejeMayor = ejeMayor;
            this.ejeMenor = ejeMenor;
        }


        public override double Perimetro()
        {
            return LongitudBase*4;
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
