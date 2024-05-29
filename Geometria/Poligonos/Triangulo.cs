namespace Geometria
{
    public class Triangulo : Poligono
    {
        private double longitudAltura;
        public Triangulo(string nombre, double longitudAltura, double longitudBase) : base(nombre, 3, longitudBase)
        {
            this.longitudAltura = longitudAltura;
        }

        public double LongitudAltura { get { return this.longitudAltura; } set { this.longitudAltura = value; } }

        public override double Perimetro()
        {
            return LongitudBase + LongitudBase + LongitudBase;
        }

        public override double Area()
        {
            return (LongitudBase * this.LongitudAltura) / 2;
        }

        public override string ToString()
        {
            return $"Longitud Altura {longitudAltura} Longitud Base {LongitudBase}";
        }
    }
}
